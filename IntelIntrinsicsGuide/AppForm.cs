using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fluent;
using Fluent.Lists;
using IntelIntrinsicsGuide.Controls.HtmlRenderer.Core.Utils;
using IntelIntrinsicsGuide.Core;

namespace IntelIntrinsicsGuide
{
	public partial class AppForm : Form
	{
		private IEnumerable<IntelIntrinsicInfo> _intelIntrinsicData;
		private readonly List<InstructionSet> _checkedTechnologies = new List<InstructionSet>();
		private readonly List<InstructionCategory> _checkedCategories = new List<InstructionCategory>();
		private IntelIntrinsicInfo _currentIntrinsicInfo;
		private string _searchString;
		private Func<IntelIntrinsicInfo, string, bool> _searchValueGetter = (o, s) => true;

		private sealed class ColumnRenderer : BaseRenderer
		{
			private readonly Color _textColor;

			public ColumnRenderer(Color textColor) => _textColor = textColor;

			public override void Render(Graphics g, Rectangle r)
			{
				if (_textColor == default)
				{
					if (!(RowObject is IntelIntrinsicInfo item)) return;
					g.FillRectangle(new SolidBrush(item.GetColor()), r);
				}
				else
				{
					DrawBackground(g, r);
					g.DrawString(GetText(), Font, new SolidBrush(_textColor), r);
				}
			}
		}

		public AppForm()
		{
			InitializeComponent();

			olvColumn3.Renderer = new ColumnRenderer(default);
			olvColumn1.Renderer = new ColumnRenderer(Color.Blue);
			olvColumn2.Renderer = new ColumnRenderer(Color.Brown);
			olvColumn4.Renderer = new ColumnRenderer(Color.DarkSlateGray);

			_hlblSignture.Text = string.Empty;
			_lblHeader.Text = string.Empty;
			_lblInstruction.Text = string.Empty;
			_lblCpuid.Text = string.Empty;
			_hlblNetCoreSignture.Text = string.Empty;

			_tlpTechnology.RowStyles.Clear();
			_tlpTechnology.Controls.Clear();
			_tlpTechnology.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			_tlpTechnology.Controls.Add(_lblTechnology);
			foreach (var ev in Enum.GetValues(typeof(InstructionSet)).OfType<InstructionSet>())
			{
				var descr = ev.GetEnumDescriptionByValue();
				if (string.IsNullOrEmpty(descr)) continue;
				var color = ev.GetColorByValue();

				var checkBox = new CheckBox
				{
					Text = descr,
					Dock = DockStyle.Fill,
					Margin = new Padding(0),
					Padding = new Padding(10, 1, 0, 0),
					Tag = ev
				};
				checkBox.CheckedChanged += (sender, args) =>
				{
					if (!(sender is CheckBox chk)) return;
					var instructionSet = (InstructionSet) (chk.Tag ?? InstructionSet.Undefined);
					if (instructionSet == InstructionSet.Undefined) return;
					if (chk.Checked)
					{
						if (!_checkedTechnologies.Contains(instructionSet))
						{
							_checkedTechnologies.Add(instructionSet);
						}
					}
					else
					{
						if (_checkedTechnologies.Contains(instructionSet))
						{
							_checkedTechnologies.Remove(instructionSet);
						}
					}

					FilterData().ConfigureAwait(false);
				};

				var panel = new Panel
				{
					Margin = new Padding(0),
					Padding = new Padding(10, 1, 0, 1),
					Height = 19,
					Controls =
					{
						new Panel
						{
							Dock = DockStyle.Left,
							Width = 5,
							BackColor = color,
							Margin = new Padding(0),
							Padding = new Padding(0)
						},
						checkBox
					}
				};

				_tlpTechnology.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				_tlpTechnology.Controls.Add(panel, 0, _tlpTechnology.RowStyles.Count - 1);
			}

			_tlpCategory.RowStyles.Clear();
			_tlpCategory.Controls.Clear();
			_tlpCategory.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			_tlpCategory.Controls.Add(_lblCategory);
			foreach (var ev in Enum.GetValues(typeof(InstructionCategory)).OfType<InstructionCategory>())
			{
				var descr = ev.GetEnumDescriptionByValue();
				if (string.IsNullOrEmpty(descr)) continue;
				var checkBox = new CheckBox
				{
					Text = descr,
					Dock = DockStyle.Top,
					Margin = new Padding(0),
					Padding = new Padding(10, 0, 0, 0),
					Height = 19,
					Tag = ev
				};
				checkBox.CheckedChanged += (sender, args) =>
				{
					if (!(sender is CheckBox chk)) return;
					var category = (InstructionCategory) (chk.Tag ?? InstructionCategory.Undefined);
					if (category == InstructionCategory.Undefined) return;
					if (chk.Checked)
					{
						if (!_checkedCategories.Contains(category))
						{
							_checkedCategories.Add(category);
						}
					}
					else
					{
						if (_checkedCategories.Contains(category))
						{
							_checkedCategories.Remove(category);
						}
					}

					FilterData().ConfigureAwait(false);
				};
				_tlpCategory.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				_tlpCategory.Controls.Add(checkBox, 0, _tlpCategory.RowStyles.Count - 1);
			}

			olvColumn1.AspectGetter = o => ((IntelIntrinsicInfo) o).Name;
			olvColumn4.AspectGetter = o => ((IntelIntrinsicInfo) o).InstructionsAsText;

			On_rbSearchBy_CheckedChanged(_rbIntel, EventArgs.Empty);
		}

		private IEnumerable<IntelIntrinsicInfo> IntelIntrinsicData
		{
			set
			{
				void OnSet()
				{
					_intelIntrinsicData = value;
					toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
					FilterData().ConfigureAwait(false);
				}

				if (InvokeRequired)
				{
					Invoke(new Action(OnSet));
					return;
				}

				OnSet();
			}
		}

		private IntelIntrinsicInfo CurrentIntrinsicInfo
		{
			set
			{
				static string FormatSignature(IIntrinsicInfo intr)
				{
					var html = new StringBuilder();
					html.Append(@"<span style='font-family: Consolas,serif; font-size: 12px; padding: 0; margin: 0; line-height: 12px; vertical-align: center;'>");
					html.Append($@"<span style='color:blue;'>{HtmlUtils.EncodeHtml(intr.ReturnType)}</span>");
					html.Append(@"<span>&nbsp;</span>");
					html.Append($@"<span style='font-weight: bold; color:firebrick;'>{intr.Name}</span>");
					html.Append(@"<span style='font-weight: bold; color:darkgoldenrod;'>(</span>");
					html.Append(string.Join(@"<span style='font-weight: bold; color:darkgoldenrod;'>,&nbsp;</span>", intr.Parameters.Select(p => $@"<span style='color:blue;'>{HtmlUtils.EncodeHtml(p.Type)}</span><span>&nbsp;</span><span style='color:black; text-decoration: underline'>{p.Name}</span>")));
					html.Append(@"<span style='font-weight: bold; color:darkgoldenrod;'>)</span>");
					return html.ToString();
				}

				_currentIntrinsicInfo = value;

				_hlblSignture.Text = FormatSignature(_currentIntrinsicInfo);
				_lblHeader.Text = _currentIntrinsicInfo.Header;
				_lblInstruction.Text = string.Join(Environment.NewLine, _currentIntrinsicInfo.Instructions.Select(i => i.ToString()));
				_lblCpuid.Text = string.Join(Environment.NewLine, _currentIntrinsicInfo.CPUIDs);
				_lblCpuid.ForeColor = _currentIntrinsicInfo.GetColor();
				// _hlblNetCoreSignture.Text = _lblNetCoreClass.Text = string.Empty;
				// var netCoreIntrinsics = _netCoreIntrinsicData.Where(i => i.IntelName == _currentIntrinsicInfo.Name);
				// _hlblNetCoreSignture.Text = string.Join("<br>", netCoreIntrinsics.Select(FormatSignature));

				_lblDescription.Text = _currentIntrinsicInfo.Description;
				_fctbOperation.Text = string.Join(Environment.NewLine, _currentIntrinsicInfo.Operations.Select(o => o.Description)).Trim();
				_tlpOutput.Invalidate();

				if (!_tcOutput.TabPages.Contains(_tpInfo))
				{
					_tcOutput.TabPages.Add(_tpInfo);
				}

				_tcOutput.SelectedTab = _tpInfo;
				_tcOutput.Visible = true;
			}
		}

		protected override async void OnLoad(EventArgs e)
		{
			IntelIntrinsicData = await IntelIntrinsicInfo.Collect();
		}

		private async void On_htbSearch_TextChanged(object sender, EventArgs e)
		{
			var tmp = _htbSearch.Text.Trim();
			if (tmp == _htbSearch.HintValue)
			{
				tmp = string.Empty;
			}

			_searchString = tmp.ToLower();
			await FilterData();
		}


		private void On_cmsMiscOps_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			static Control FindControlAtPoint(Control container, Point pos)
			{
				foreach (Control c in container.Controls)
				{
					if (!c.Visible || !c.Bounds.Contains(pos)) continue;
					var child = FindControlAtPoint(c, new Point(pos.X - c.Left, pos.Y - c.Top));
					return child ?? c;
				}

				return null;
			}

			static Control FindControlAtCursor(Form form)
			{
				var pos = Cursor.Position;
				return form.Bounds.Contains(pos) ? FindControlAtPoint(form, form.PointToClient(pos)) : null;
			}

			if (!(FindControlAtCursor(this) is Label lbl)) return;
			Clipboard.SetText(lbl.Text);
		}

		private void On_tlpOutput_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			if (e.Column == 0 && _currentIntrinsicInfo != null)
			{
				e.Graphics.FillRectangle(new SolidBrush(_currentIntrinsicInfo.GetColor()), e.CellBounds);
			}
		}

		private void On_tlpSynopsis_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, e.CellBounds, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid);
		}

		private void On_flvSearchResults_DoubleClick(object sender, EventArgs e)
		{
			if (!((sender as FastListView)?.SelectedItem.RowObject is IntelIntrinsicInfo data)) return;
			CurrentIntrinsicInfo = data;
		}

		private async void On_rbSearchBy_CheckedChanged(object sender, EventArgs e)
		{
			if (!(sender is RadioButton rb)) return;
			if (rb == _rbIntel)
			{
				_searchValueGetter = (o, s) => o.Name.ToLower().StartsWith(s.ToLower());
			}
			else
			{
				_searchValueGetter = (o, s) => o.InstructionsAsText.ToLower().Contains(s.ToLower());
			}

			await FilterData();
		}

		private async Task FilterData()
		{
			void Do()
			{
				if (_intelIntrinsicData == null) return;
				var filteredData = _intelIntrinsicData.Where(i => (string.IsNullOrEmpty(_searchString) || _searchValueGetter(i, _searchString)) && (_checkedTechnologies.Count == 0 || _checkedTechnologies.Any(t => t == i.Technology.GetEnumValueByDescription<InstructionSet>())) && (_checkedCategories.Count == 0 || _checkedCategories.Any(c => i.Categories.Contains(c.GetEnumDescriptionByValue())))).ToList();
				_flvSearchResults.Objects = filteredData;
				_tcOutput.SelectedTab = _tpSearchResults;
			}

			await Task.Run(() =>
			{
				if (InvokeRequired)
				{
					Invoke(new Action(Do));
					return;
				}

				Do();
			});
		}
	}

	internal static class EnumExtensions
	{
		public static TEnum GetEnumValueByDescription<TEnum>(this string descr)
			where TEnum : struct, IComparable, IFormattable, IConvertible
		{
			var enumType = typeof(TEnum);
			foreach (TEnum enumValue in Enum.GetValues(enumType))
			{
				var enumValueMemberInfo = enumType.GetMember(enumValue.ToString())[0];
				if (Attribute.IsDefined(enumValueMemberInfo, typeof(DescriptionAttribute)) && enumValueMemberInfo.GetCustomAttribute<DescriptionAttribute>()?.Description == descr)
				{
					return enumValue;
				}
			}

			return default;
		}

		public static string GetEnumDescriptionByValue<TEnum>(this TEnum value)
			where TEnum : struct, IComparable, IFormattable, IConvertible
		{
			var enumType = typeof(TEnum);
			var enumValueMemberInfo = enumType.GetMember(value.ToString())[0];
			return Attribute.IsDefined(enumValueMemberInfo, typeof(DescriptionAttribute)) ? enumValueMemberInfo.GetCustomAttribute<DescriptionAttribute>()?.Description : default;
		}

		internal static Color GetColorByValue(this InstructionSet value)
		{
			var enumType = typeof(InstructionSet);
			var enumValueMemberInfo = enumType.GetMember(value.ToString())[0];
			return Attribute.IsDefined(enumValueMemberInfo, typeof(UniqueColorAttribute)) ? enumValueMemberInfo.GetCustomAttribute<UniqueColorAttribute>().Color : default;
		}

		internal static Color GetColor(this IntelIntrinsicInfo intelIntrinsic)
		{
			var instrCat = intelIntrinsic.Technology.GetEnumValueByDescription<InstructionSet>();
			return GetColorByValue(instrCat);
		}
	}
}
