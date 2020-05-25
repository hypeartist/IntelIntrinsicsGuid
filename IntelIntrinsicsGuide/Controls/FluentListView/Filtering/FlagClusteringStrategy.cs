/*
 * FlagClusteringStrategy - Implements a clustering strategy for a field which is a single integer 
 *                          containing an XOR'ed collection of bit flags
 *
 * Author: Phillip Piper
 * Date: 23-March-2012 8:33 am
 *
 * Change log:
 * 2012-03-23  JPP  - First version
 * 
 * Copyright (C) 2012 Phillip Piper
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 * If you wish to use this code in a closed source application, please contact phillip.piper@gmail.com.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Fluent {
	/// <summary>
	/// Instances of this class cluster model objects on the basis of a
	/// property that holds an xor-ed collection of bit flags.
	/// </summary>
	public class FlagClusteringStrategy : ClusteringStrategy {
		#region Life and death

		/// <summary>
		/// Create a clustering strategy that operates on the flags of the given enum
		/// </summary>
		/// <param name="enumType"></param>
		public FlagClusteringStrategy(Type enumType) {
			if (enumType == null) {
				throw new ArgumentNullException("enumType");
			}

			if (!enumType.IsEnum) {
				throw new ArgumentException("Type must be enum", "enumType");
			}

			if (enumType.GetCustomAttributes(typeof(FlagsAttribute), false) == null) {
				throw new ArgumentException("Type must have [Flags] attribute", "enumType");
			}

			var flags = new List<long>();
			foreach (var x in Enum.GetValues(enumType)) {
				flags.Add(Convert.ToInt64(x));
			}

			var flagLabels = new List<string>();
			foreach (var x in Enum.GetNames(enumType)) {
				flagLabels.Add(x);
			}

			SetValues(flags.ToArray(), flagLabels.ToArray());
		}

		/// <summary>
		/// Create a clustering strategy around the given collections of flags and their display labels.
		/// There must be the same number of elements in both collections.
		/// </summary>
		/// <param name="values">The list of flags. </param>
		/// <param name="labels"></param>
		public FlagClusteringStrategy(long[] values, string[] labels) {
			SetValues(values, labels);
		}

		#endregion

		#region Implementation

		/// <summary>
		/// Gets the value that will be xor-ed to test for the presence of a particular value.
		/// </summary>
		public long[] Values {
			get => values;
			private set => values = value;
		}

		private long[] values;

		/// <summary>
		/// Gets the labels that will be used when the corresponding Value is XOR present in the data.
		/// </summary>
		public string[] Labels {
			get => labels;
			private set => labels = value;
		}

		private string[] labels;

		private void SetValues(long[] flags, string[] flagLabels) {
			if (flags == null || flags.Length == 0) {
				throw new ArgumentNullException("flags");
			}

			if (flagLabels == null || flagLabels.Length == 0) {
				throw new ArgumentNullException("flagLabels");
			}

			if (flags.Length != flagLabels.Length) {
				throw new ArgumentException("values and labels must have the same number of entries", "flags");
			}

			Values = flags;
			Labels = flagLabels;
		}

		#endregion

		#region Implementation of IClusteringStrategy

		/// <summary>
		/// Get the cluster key by which the given model will be partitioned by this strategy
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public override object GetClusterKey(object model) {
			var flags = new List<long>();
			try {
				var modelValue = Convert.ToInt64(Column.GetValue(model));
				foreach (var x in Values) {
					if ((x & modelValue) == x) {
						flags.Add(x);
					}
				}

				return flags;
			}
			catch (InvalidCastException ex) {
				System.Diagnostics.Debug.Write(ex);
				return flags;
			}
			catch (FormatException ex) {
				System.Diagnostics.Debug.Write(ex);
				return flags;
			}
		}

		/// <summary>
		/// Gets the display label that the given cluster should use
		/// </summary>
		/// <param name="cluster"></param>
		/// <returns></returns>
		public override string GetClusterDisplayLabel(ICluster cluster) {
			var clusterKeyAsUlong = Convert.ToInt64(cluster.ClusterKey);
			for (var i = 0; i < Values.Length; i++) {
				if (clusterKeyAsUlong == Values[i]) {
					return ApplyDisplayFormat(cluster, Labels[i]);
				}
			}

			return ApplyDisplayFormat(cluster, clusterKeyAsUlong.ToString(CultureInfo.CurrentUICulture));
		}

		/// <summary>
		/// Create a filter that will include only model objects that
		/// match one or more of the given values.
		/// </summary>
		/// <param name="valuesChosenForFiltering"></param>
		/// <returns></returns>
		public override IModelFilter CreateFilter(IList valuesChosenForFiltering) {
			return new FlagBitSetFilter(GetClusterKey, valuesChosenForFiltering);
		}

		#endregion
	}
}