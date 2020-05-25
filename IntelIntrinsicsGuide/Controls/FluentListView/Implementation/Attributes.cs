﻿/*
 * Attributes - Attributes that can be attached to properties of models to allow columns to be
 *              built from them directly
 *
 * Author: Phillip Piper
 * Date: 15/08/2009 22:01
 *
 * Change log:
 * v2.6
 * 2012-08-16  JPP  - Added [OLVChildren] and [OLVIgnore]
 *                  - OLV attributes can now only be set on properties
 * v2.4
 * 2010-04-14  JPP  - Allow Name property to be set
 * 
 * v2.3
 * 2009-08-15  JPP  - Initial version
 *
 * To do:
 * 
 * Copyright (C) 2009-2014 Phillip Piper
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
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fluent {
	/// <summary>
	/// This attribute is used to mark a property of a model
	/// class that should be noticed by Generator class.
	/// </summary>
	/// <remarks>
	/// All the attributes of this class match their equivilent properties on OLVColumn.
	/// </remarks>
	[AttributeUsage(AttributeTargets.Property)]
	public class OLVColumnAttribute : Attribute {
		#region Constructor

		// There are several property where we actually want nullable value (bool?, int?),
		// but it seems attribute properties can't be nullable types.
		// So we explicitly track if those properties have been set.

		/// <summary>
		/// Create a new OLVColumnAttribute
		/// </summary>
		public OLVColumnAttribute() {
		}

		/// <summary>
		/// Create a new OLVColumnAttribute with the given title
		/// </summary>
		/// <param name="title">The title of the column</param>
		public OLVColumnAttribute(string title) {
			Title = title;
		}

		#endregion

		#region Public properties

		/// <summary>
		/// 
		/// </summary>
		public string AspectToStringFormat {
			get => aspectToStringFormat;
			set => aspectToStringFormat = value;
		}

		private string aspectToStringFormat;

		/// <summary>
		/// 
		/// </summary>
		public bool CheckBoxes {
			get => checkBoxes;
			set {
				checkBoxes = value;
				IsCheckBoxesSet = true;
			}
		}

		private bool checkBoxes;
		internal bool IsCheckBoxesSet = false;

		/// <summary>
		/// 
		/// </summary>
		public int DisplayIndex {
			get => displayIndex;
			set => displayIndex = value;
		}

		private int displayIndex = -1;

		/// <summary>
		/// 
		/// </summary>
		public bool FillsFreeSpace {
			get => fillsFreeSpace;
			set => fillsFreeSpace = value;
		}

		private bool fillsFreeSpace;

		/// <summary>
		/// 
		/// </summary>
		public int FreeSpaceProportion {
			get => freeSpaceProportion;
			set {
				freeSpaceProportion = value;
				IsFreeSpaceProportionSet = true;
			}
		}

		private int freeSpaceProportion;
		internal bool IsFreeSpaceProportionSet = false;

		/// <summary>
		/// An array of IComparables that mark the cutoff points for values when
		/// grouping on this column. 
		/// </summary>
		public object[] GroupCutoffs {
			get => groupCutoffs;
			set => groupCutoffs = value;
		}

		private object[] groupCutoffs;

		/// <summary>
		/// 
		/// </summary>
		public string[] GroupDescriptions {
			get => groupDescriptions;
			set => groupDescriptions = value;
		}

		private string[] groupDescriptions;

		/// <summary>
		/// 
		/// </summary>
		public string GroupWithItemCountFormat {
			get => groupWithItemCountFormat;
			set => groupWithItemCountFormat = value;
		}

		private string groupWithItemCountFormat;

		/// <summary>
		/// 
		/// </summary>
		public string GroupWithItemCountSingularFormat {
			get => groupWithItemCountSingularFormat;
			set => groupWithItemCountSingularFormat = value;
		}

		private string groupWithItemCountSingularFormat;

		/// <summary>
		/// 
		/// </summary>
		public bool Hyperlink {
			get => hyperlink;
			set => hyperlink = value;
		}

		private bool hyperlink;

		/// <summary>
		/// 
		/// </summary>
		public string ImageAspectName {
			get => imageAspectName;
			set => imageAspectName = value;
		}

		private string imageAspectName;

		/// <summary>
		/// 
		/// </summary>
		public bool IsEditable {
			get => isEditable;
			set {
				isEditable = value;
				IsEditableSet = true;
			}
		}

		private bool isEditable = true;
		internal bool IsEditableSet = false;

		/// <summary>
		/// 
		/// </summary>
		public bool IsVisible {
			get => isVisible;
			set => isVisible = value;
		}

		private bool isVisible = true;

		/// <summary>
		/// 
		/// </summary>
		public bool IsTileViewColumn {
			get => isTileViewColumn;
			set => isTileViewColumn = value;
		}

		private bool isTileViewColumn;

		/// <summary>
		/// 
		/// </summary>
		public int MaximumWidth {
			get => maximumWidth;
			set => maximumWidth = value;
		}

		private int maximumWidth = -1;

		/// <summary>
		/// 
		/// </summary>
		public int MinimumWidth {
			get => minimumWidth;
			set => minimumWidth = value;
		}

		private int minimumWidth = -1;

		/// <summary>
		/// 
		/// </summary>
		public string Name {
			get => name;
			set => name = value;
		}

		private string name;

		/// <summary>
		/// 
		/// </summary>
		public HorizontalAlignment TextAlign {
			get => textAlign;
			set {
				textAlign = value;
				IsTextAlignSet = true;
			}
		}

		private HorizontalAlignment textAlign = HorizontalAlignment.Left;
		internal bool IsTextAlignSet = false;

		/// <summary>
		/// 
		/// </summary>
		public string Tag {
			get => tag;
			set => tag = value;
		}

		private string tag;

		/// <summary>
		/// 
		/// </summary>
		public string Title {
			get => title;
			set => title = value;
		}

		private string title;

		/// <summary>
		/// 
		/// </summary>
		public string ToolTipText {
			get => toolTipText;
			set => toolTipText = value;
		}

		private string toolTipText;

		/// <summary>
		/// 
		/// </summary>
		public bool TriStateCheckBoxes {
			get => triStateCheckBoxes;
			set {
				triStateCheckBoxes = value;
				IsTriStateCheckBoxesSet = true;
			}
		}

		private bool triStateCheckBoxes;
		internal bool IsTriStateCheckBoxesSet = false;

		/// <summary>
		/// 
		/// </summary>
		public bool UseInitialLetterForGroup {
			get => useInitialLetterForGroup;
			set => useInitialLetterForGroup = value;
		}

		private bool useInitialLetterForGroup;

		/// <summary>
		/// 
		/// </summary>
		public int Width {
			get => width;
			set => width = value;
		}

		private int width = 150;

		#endregion
	}

	/// <summary>
	/// Properties marked with [OLVChildren] will be used as the children source in a TreeListView.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class OLVChildrenAttribute : Attribute {
	}

	/// <summary>
	/// Properties marked with [OLVIgnore] will not have columns generated for them.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class OLVIgnoreAttribute : Attribute {
	}
}