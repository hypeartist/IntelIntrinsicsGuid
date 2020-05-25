﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fluent.Lists;
using System.Linq;

namespace Fluent {
	/// <summary>
	/// FluentListView is a C# wrapper around a .NET ListView, supporting model-bound lists,
	/// in-place item editing, drag and drop, icons, themes, trees &amp; data grids, and much more.
	/// 
	/// If required, an AdvancedListView is created internally, otherwise a lightweight FastListView is created.
	/// </summary>
	public class FluentListView : UserControl {
		private AdvancedListView InnerAdvList;
		private FastListView InnerFastList;
		private IList items = new List<object>();
		private FluentListProperties properties = new FluentListProperties();

		/// <summary>
		/// The items that are bound to this list. You only need to set this once.
		/// When adding and removing items, please call AddItem and RemoveItem instead of modifying this list directly.
		/// </summary>
		[Browsable(false)]
		public IList Items {
			get => items;
			set {

				// FIX: suppress invalid data set during InitializeControl, due to codegen by Visual Studio Designer
				if (this.ParentForm != null) {

					// accept the items and redraw the list
					items = value;
					Redraw();
				}
			}
		}


		/// <summary>
		/// You need to set these to configure which properties of your objects display as the Name, Icon and Description.
		/// You can optionally add a list of Columns, to have those properties show as additional columns in the list.
		/// </summary>
		[Browsable(false)]
		public FluentListProperties Properties => properties;

		/// <summary>
		/// Whether the list will use a SimpleDragSource to initiate drags.
		/// </summary>
		public bool EnableDragDropItems { get; set; }

		/// <summary>
		/// Whether the list will use a SimpleDropSink to accept dropping items from other sources.
		/// </summary>
		public bool EnableDrop { get; set; }

		/// <summary>
		/// Whether the list will accept dropping of files from Explorer.
		/// </summary>
		public bool EnableDropFiles { get; set; }

		/// <summary>
		/// Which visual theme to use to render items.
		/// </summary>
		public OLVTheme Theme { get; set; }

		/// <summary>
		/// The font used to display list items. Affects row height.
		/// </summary>
		public Font ItemFont { get; set; }

		/// <summary>
		/// The width of additional columns.
		/// </summary>
		public int ColumnWidth { get; set; }

		/// <summary>
		/// You need to set this if you are using EnableDragDropItems or EnableDrop, but not if you are using EnableDropFiles.
		/// </summary>
		public Func<OlvDropEventArgs, bool> OnCanDrop;

		/// <summary>
		/// You need to set this if you are using EnableDragDropItems or EnableDrop, but not if you are using EnableDropFiles.
		/// </summary>
		public Action<OlvDropEventArgs> OnDropped;

		/// You need to set this if you are using EnableDropFiles.
		/// </summary>
		public Action<List<string>> OnDroppedFiles;

		/// <summary>
		/// You need to set this if you are using drag or drag-drop.
		/// </summary>
		public DropTargetLocation EnableDropOnLocations;


		/// <summary>
		/// WIP. Will show an icon near the name.
		/// </summary>
		public bool ShowIcons { get; set; }

		/// <summary>
		/// WIP. Will show a description line below the name.
		/// </summary>
		public bool ShowDescription { get; set; }

		/// <summary>
		/// Used to control if additional columns are displayed based on Properties.Columns.
		/// </summary>
		public bool ShowColumns { get; set; }

		/// <summary>
		/// WIP. Will group up the items on a given property.
		/// </summary>
		public bool ShowGroups { get; set; }

		/// <summary>
		/// WIP. Only used to select between AdvancedListView and FastListView.
		/// </summary>
		public bool EnableGifs { get; set; }

		/// <summary>
		/// WIP. Only used to select between AdvancedListView and FastListView.
		/// </summary>
		public bool EnableTileView { get; set; }

		/// <summary>
		/// WIP. Only used to select between AdvancedListView and FastListView.
		/// </summary>
		public bool EnableRenaming { get; set; }

		/// <summary>
		/// WIP. Only used to select between AdvancedListView and FastListView.
		/// </summary>
		public bool EnableCellEditing { get; set; }

		/// <summary>
		/// Gets the underlying AdvancedListView or FastListView UI control.
		/// </summary>
		[Browsable(false)]
		public AdvancedListView InnerList {
			get {
				if (InnerAdvList != null) {
					return InnerAdvList;
				}

				if (InnerFastList != null) {
					return InnerFastList;
				}

				return null;
			}
		}

		/// <summary>
		/// Gets or sets the selected item.
		/// </summary>
		[Browsable(false)]
		public object SelectedItem {
			get {
				if (InnerList != null) {
					return InnerList.SelectedObject;
				}

				return null;
			}
			set {
				if (InnerList != null) {
					InnerList.SelectObject(value, true);
					InnerList.EnsureModelVisible(value);
				}
			}
		}

		/// <summary>
		/// Gets or sets the selected items.
		/// </summary>
		[Browsable(false)]
		public IList SelectedItems {
			get {
				if (InnerList != null) {
					return InnerList.SelectedObjects;
				}

				return null;
			}
			set {
				if (InnerList != null) {
					InnerList.SelectedObjects = value;
				}
			}
		}


		/// <summary>
		/// Displays the items as a list. Call this when the items have been added/removed to force-redraw.
		/// </summary>
		public void Redraw() {
			if (items == null) {
				return;
			}

			CreateDestroyList();

			RedrawItems();
		}

		/// <summary>
		/// Call this when the item column values have changed, and you want to simply update the view.
		/// </summary>
		public void RedrawValues() {
			if (InnerList == null) {
				return;
			}

			InnerList.RedrawItems(0, Items.Count - 1, false);
		}

		private void RedrawItems() {
			SuspendLayout();

			if (InnerAdvList != null) {
				InnerAdvList.SetObjects(items);
			}

			if (InnerFastList != null) {
				InnerFastList.SetObjects(items);
			}

			ResumeLayout();
		}

		private void CreateDestroyList() {
			SuspendLayout();

			if (ShouldCreateAdvancedListView()) {
				// create advanced list if required
				if (InnerAdvList == null) {
					InnerAdvList = new AdvancedListView();
					ConfigureList(InnerAdvList);
				}

				// destroy fast list if created
				if (InnerFastList != null) {
					Controls.Remove(InnerFastList);
					InnerFastList.Dispose();
					InnerFastList = null;
				}
			}
			else {
				// else create fast list
				if (InnerFastList == null) {
					InnerFastList = new FastListView();
					ConfigureList(InnerFastList);
				}

				// destroy advanced list if created
				if (InnerAdvList != null) {
					Controls.Remove(InnerAdvList);
					InnerAdvList.Dispose();
					InnerAdvList = null;
				}
			}

			ResumeLayout();
		}

		private bool ShouldCreateAdvancedListView() {
			return EnableGifs || EnableTileView || EnableRenaming || EnableCellEditing;
		}

		private void ConfigureList(AdvancedListView list) {
			// basics
			list.Size = Size;
			list.Name = "InnerList";
			list.Visible = true;
			list.BackColor = BackColor;
			list.ForeColor = ForeColor;
			list.BorderStyle = BorderStyle;
			list.HideSelection = false;

			// add headers
			var showHeaders = false;
			list.AllColumns = GetColumns(out showHeaders);
			list.RebuildColumns();

			// setup header view
			list.ShowHeaderInAllViews = showHeaders;
			if (!showHeaders) {
				list.HeaderStyle = ColumnHeaderStyle.None;
			}

			// setup view
			list.View = View.Details;
			list.FullRowSelect = true;
			list.UseExplorerTheme = true;

			// setup theme
			if (Theme == OLVTheme.Vista) {
				list.UseTranslucentSelection = true;
				list.UseTranslucentHotItem = true;
			}
			else if (Theme == OLVTheme.VistaExplorer) {
				list.UseExplorerTheme = true;
			}

			if (ItemFont != null) {
				list.Font = ItemFont;
			}

			// add and resize
			Controls.Add(list);
			list.Dock = DockStyle.Fill;

			// configure drag & drop
			if (EnableDragDropItems) {
				list.IsSimpleDragSource = true;
			}

			if (EnableDragDropItems || EnableDrop || EnableDropFiles) {
				// drop locations allowed
				list.AllowDrop = true;
				list.IsSimpleDropSink = true;
				((SimpleDropSink) list.DropSink).AcceptableLocations = EnableDropOnLocations;
				((SimpleDropSink) list.DropSink).CanDropOnBackground = Enum.IsDefined(typeof(DropTargetLocation), DropTargetLocation.Background);

				// drop event handling
				list.CanDrop += delegate(object sender, OlvDropEventArgs args) {
					// if dropping files is enabled, internally manage the drop handling of files
					if (EnableDropFiles) {
						var files = GetDroppedFiles(args);
						if (files != null) {
							args.Effect = DragDropEffects.Copy;
							return;
						}
					}

					// call the user handler for drag/drop
					if (OnCanDrop != null) {
						var drop = OnCanDrop(args);
						if (drop) {
							args.Effect = DragDropEffects.Copy;
							return;
						}
					}
				};

				// when dropped
				list.Dropped += delegate(object sender, OlvDropEventArgs args) {
					// if dropping files is enabled, internally manage the drop handling of files
					if (EnableDropFiles) {
						var files = GetDroppedFiles(args);
						if (files != null) {
							if (OnDroppedFiles != null) {
								OnDroppedFiles(files);
							}
						}
					}

					// call the user handler for drag/drop
					if (OnDropped != null) {
						OnDropped(args);
					}
				};
			}
		}

		private List<OLVColumn> GetColumns(out bool showHeaders) {
			var columns = new List<OLVColumn>();

			// ensure valid values given
			if (Properties.Name == null) {
				throw new ArgumentNullException("You need to set 'FluentListView.Properties.Name' to the property you wish to use as the display text for the objects! Set it to a blank string to call the ToString() method on the objects.");
			}

			if (ShowIcons && properties.Icon == null) {
				throw new ArgumentNullException("You need to set 'FluentListView.Properties.Icon' to the property that contains an Icon or Bitmap object for the objects!");
			}

			if (ShowDescription && properties.Description == null) {
				throw new ArgumentNullException("You need to set 'FluentListView.Properties.Description' to the property you wish to use as the description text for the objects!");
			}

			// always add a name property
			columns.Add(new OLVColumn {
				Name = "Name",
				Text = "Name",
				FillsFreeSpace = true,
				Groupable = Properties.GroupBy == Properties.Name,

				//UseInitialLetterForGroup = true,
				AspectName = properties.Name,
				IsVisible = true,
				Width = 300,
			});
			showHeaders = false;

			// add icon
			if (ShowIcons) {
			}

			// add description
			if (ShowDescription) {
			}

			// add columns
			if (ShowColumns && properties.Columns != null) {
				showHeaders = true;
				for (var c = 0; c < properties.Columns.Count; c++) {
					var colProp = properties.Columns[c];
					var colName = properties.ColumnNames != null ? properties.ColumnNames[c] : colProp;
					var colWidth = ColumnWidth > 0 ? ColumnWidth : 100;

					columns.Add(new OLVColumn {
						Name = colProp,
						Text = colName,
						Groupable = Properties.GroupBy == colProp,
						AspectName = colProp,
						IsVisible = true,
						FillsFreeSpace = false,

						//MaximumWidth = colWidth,
						//MinimumWidth = colWidth,
						Width = colWidth,
					});
				}
			}

			return columns;
		}

		/// <summary>
		/// Quickly adds an item to the list.
		/// </summary>
		public void AddItem(object item) {
			items.Add(item);

			// redraw the whole list if never done it before
			if (InnerAdvList == null && InnerFastList == null) {
				Redraw();
			}
			else {
				// quickly just add the object to the list
				if (InnerAdvList != null) {
					InnerAdvList.AddObject(item);
				}

				if (InnerFastList != null) {
					InnerFastList.AddObject(item);
				}
			}
		}

		/// <summary>
		/// Quickly removes an item from the list.
		/// </summary>
		public void RemoveItem(object item) {
			// if the item is found in the array
			if (items.Contains(item)) {
				items.Remove(item);

				// redraw the whole list if never done it before
				if (InnerAdvList == null && InnerFastList == null) {
					Redraw();
				}
				else {
					// quickly just add the object to the list
					if (InnerAdvList != null) {
						InnerAdvList.RemoveObject(item);
					}

					if (InnerFastList != null) {
						InnerFastList.RemoveObject(item);
					}
				}
			}
		}

		/// <summary>
		/// Quickly removes multiple items from the list.
		/// </summary>
		public void RemoveItems(IList items) {
			if (items != null) {
				foreach (var item in items) {
					RemoveItem(item);
				}
			}
		}

		/// <summary>
		/// Returns an array of file paths, when given an argument object recieved by the OnCanDrop and OnDropped events.
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public List<string> GetDroppedFiles(OlvDropEventArgs args) {
			try {
				return ((string[]) args.DragEventArgs.Data.GetData(DataFormats.FileDrop)).ToList<string>();
			}
			catch (Exception) {
			}

			return null;
		}
	}

	public enum OLVTheme {
		/// <summary>
		/// This will style your list like the old Windows XP theme.
		/// </summary>
		XP = 1,

		/// <summary>
		/// This will give a selection and hot item mechanism that is similar to that used by Vista. It is not the same, I know. Do not complain.
		/// </summary>
		Vista = 2,

		/// <summary>
		/// If you absolutely have to look like Vista, this is your property. But it only works on Windows Vista and later, and does not work well with AlternateRowBackColors or HotItemStyles.
		/// </summary>
		VistaExplorer = 3
	}
}