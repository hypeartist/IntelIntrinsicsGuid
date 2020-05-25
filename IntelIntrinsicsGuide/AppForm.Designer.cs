using Fluent;
using Fluent.Lists;
using IntelIntrinsicsGuide.Controls.FastColoredTextBox;
using IntelIntrinsicsGuide.Controls.HintTextBox;
using IntelIntrinsicsGuide.Controls.HtmlRenderer.WinForms;

namespace IntelIntrinsicsGuide
{
	partial class AppForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this._tlpFilters = new System.Windows.Forms.TableLayoutPanel();
			this._tlpTechnology = new System.Windows.Forms.TableLayoutPanel();
			this._lblTechnology = new System.Windows.Forms.Label();
			this._tlpCategory = new System.Windows.Forms.TableLayoutPanel();
			this._lblCategory = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this._tlpInfo = new System.Windows.Forms.TableLayoutPanel();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._tcOutput = new System.Windows.Forms.TabControl();
			this._tpSearchResults = new System.Windows.Forms.TabPage();
			this._tpInfo = new System.Windows.Forms.TabPage();
			this._tlpOutput = new System.Windows.Forms.TableLayoutPanel();
			this._tlpSynopsis = new System.Windows.Forms.TableLayoutPanel();
			this.label15 = new System.Windows.Forms.Label();
			this._lblCpuid = new System.Windows.Forms.Label();
			this._cmsMiscOps = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label12 = new System.Windows.Forms.Label();
			this._lblHeader = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._lblInstruction = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._lblDescription = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this._rbIntel = new System.Windows.Forms.RadioButton();
			this._rbInstruction = new System.Windows.Forms.RadioButton();
			this._flvSearchResults = new Fluent.Lists.FastListView();
			this.olvColumn3 = new Fluent.OLVColumn();
			this.olvColumn1 = new Fluent.OLVColumn();
			this.olvColumn2 = new Fluent.OLVColumn();
			this.olvColumn4 = new Fluent.OLVColumn();
			this._hlblSignture = new IntelIntrinsicsGuide.Controls.HtmlRenderer.WinForms.HtmlLabel();
			this._hlblNetCoreSignture = new IntelIntrinsicsGuide.Controls.HtmlRenderer.WinForms.HtmlLabel();
			this._fctbOperation = new IntelIntrinsicsGuide.Controls.FastColoredTextBox.FastColoredTextBox();
			this._htbSearch = new IntelIntrinsicsGuide.Controls.HintTextBox.HintTextBox(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel1.SuspendLayout();
			this._tlpFilters.SuspendLayout();
			this._tlpTechnology.SuspendLayout();
			this._tlpCategory.SuspendLayout();
			this.panel2.SuspendLayout();
			this._tlpInfo.SuspendLayout();
			this._tcOutput.SuspendLayout();
			this._tpInfo.SuspendLayout();
			this._tlpOutput.SuspendLayout();
			this._tlpSynopsis.SuspendLayout();
			this._cmsMiscOps.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._flvSearchResults)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._fctbOperation)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this._tlpFilters);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(6, 5);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(212, 805);
			this.panel1.TabIndex = 0;
			// 
			// _tlpFilters
			// 
			this._tlpFilters.ColumnCount = 1;
			this._tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpFilters.Controls.Add(this._tlpTechnology, 0, 0);
			this._tlpFilters.Controls.Add(this._tlpCategory, 0, 1);
			this._tlpFilters.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpFilters.Location = new System.Drawing.Point(0, 0);
			this._tlpFilters.Margin = new System.Windows.Forms.Padding(0);
			this._tlpFilters.Name = "_tlpFilters";
			this._tlpFilters.RowCount = 2;
			this._tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpFilters.Size = new System.Drawing.Size(212, 805);
			this._tlpFilters.TabIndex = 2;
			// 
			// _tlpTechnology
			// 
			this._tlpTechnology.AutoSize = true;
			this._tlpTechnology.BackColor = System.Drawing.SystemColors.Control;
			this._tlpTechnology.ColumnCount = 1;
			this._tlpTechnology.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpTechnology.Controls.Add(this._lblTechnology, 0, 0);
			this._tlpTechnology.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpTechnology.Location = new System.Drawing.Point(0, 0);
			this._tlpTechnology.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this._tlpTechnology.Name = "_tlpTechnology";
			this._tlpTechnology.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this._tlpTechnology.RowCount = 1;
			this._tlpTechnology.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpTechnology.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this._tlpTechnology.Size = new System.Drawing.Size(212, 35);
			this._tlpTechnology.TabIndex = 0;
			// 
			// _lblTechnology
			// 
			this._lblTechnology.AutoSize = true;
			this._lblTechnology.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this._lblTechnology.Dock = System.Windows.Forms.DockStyle.Top;
			this._lblTechnology.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this._lblTechnology.Location = new System.Drawing.Point(0, 0);
			this._lblTechnology.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this._lblTechnology.Name = "_lblTechnology";
			this._lblTechnology.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this._lblTechnology.Size = new System.Drawing.Size(212, 25);
			this._lblTechnology.TabIndex = 0;
			this._lblTechnology.Text = "Technology";
			// 
			// _tlpCategory
			// 
			this._tlpCategory.AutoSize = true;
			this._tlpCategory.ColumnCount = 1;
			this._tlpCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpCategory.Controls.Add(this._lblCategory, 0, 0);
			this._tlpCategory.Dock = System.Windows.Forms.DockStyle.Top;
			this._tlpCategory.Location = new System.Drawing.Point(0, 40);
			this._tlpCategory.Margin = new System.Windows.Forms.Padding(0);
			this._tlpCategory.Name = "_tlpCategory";
			this._tlpCategory.RowCount = 1;
			this._tlpCategory.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this._tlpCategory.Size = new System.Drawing.Size(212, 30);
			this._tlpCategory.TabIndex = 1;
			// 
			// _lblCategory
			// 
			this._lblCategory.AutoSize = true;
			this._lblCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this._lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this._lblCategory.Location = new System.Drawing.Point(0, 0);
			this._lblCategory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this._lblCategory.Name = "_lblCategory";
			this._lblCategory.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this._lblCategory.Size = new System.Drawing.Size(212, 25);
			this._lblCategory.TabIndex = 1;
			this._lblCategory.Text = "Category";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this._tlpInfo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(218, 5);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.panel2.Size = new System.Drawing.Size(699, 805);
			this.panel2.TabIndex = 1;
			// 
			// _tlpInfo
			// 
			this._tlpInfo.ColumnCount = 1;
			this._tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpInfo.Controls.Add(this.label8, 0, 0);
			this._tlpInfo.Controls.Add(this.label1, 0, 1);
			this._tlpInfo.Controls.Add(this._tcOutput, 0, 3);
			this._tlpInfo.Controls.Add(this.panel3, 0, 2);
			this._tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpInfo.Location = new System.Drawing.Point(6, 0);
			this._tlpInfo.Name = "_tlpInfo";
			this._tlpInfo.RowCount = 4;
			this._tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpInfo.Size = new System.Drawing.Size(693, 805);
			this._tlpInfo.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label8.Size = new System.Drawing.Size(693, 25);
			this.label8.TabIndex = 1;
			this.label8.Text = "Info";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.BurlyWood;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(0, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(5);
			this.label1.Size = new System.Drawing.Size(693, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "The Intel Intrinsics Guide is an interactive reference tool for Intel intrinsic instructions, which are C style functions that provide access to many Intel instructions - including Intel® SSE, AVX, AVX-512, and more - without the need to write assembly code.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _tcOutput
			// 
			this._tcOutput.Controls.Add(this._tpSearchResults);
			this._tcOutput.Controls.Add(this._tpInfo);
			this._tcOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tcOutput.Location = new System.Drawing.Point(0, 100);
			this._tcOutput.Margin = new System.Windows.Forms.Padding(0);
			this._tcOutput.Name = "_tcOutput";
			this._tcOutput.SelectedIndex = 0;
			this._tcOutput.Size = new System.Drawing.Size(693, 713);
			this._tcOutput.TabIndex = 25;
			// 
			// _tpSearchResults
			// 
			this._tpSearchResults.Controls.Add(this._flvSearchResults);
			this._tpSearchResults.Location = new System.Drawing.Point(4, 24);
			this._tpSearchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this._tpSearchResults.Name = "_tpSearchResults";
			this._tpSearchResults.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this._tpSearchResults.Size = new System.Drawing.Size(685, 685);
			this._tpSearchResults.TabIndex = 0;
			this._tpSearchResults.Text = "Search results";
			this._tpSearchResults.UseVisualStyleBackColor = true;
			// 
			// _flvSearchResults
			// 
			this._flvSearchResults.AllColumns.Add(this.olvColumn3);
			this._flvSearchResults.AllColumns.Add(this.olvColumn1);
			this._flvSearchResults.AllColumns.Add(this.olvColumn2);
			this._flvSearchResults.AllColumns.Add(this.olvColumn4);
			this._flvSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._flvSearchResults.CellEditUseWholeCell = false;
			this._flvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.olvColumn3,
			this.olvColumn1,
			this.olvColumn2,
			this.olvColumn4});
			this._flvSearchResults.Cursor = System.Windows.Forms.Cursors.Default;
			this._flvSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flvSearchResults.FullRowSelect = true;
			this._flvSearchResults.GridLines = true;
			this._flvSearchResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this._flvSearchResults.HideSelection = false;
			this._flvSearchResults.Location = new System.Drawing.Point(3, 2);
			this._flvSearchResults.MultiSelect = false;
			this._flvSearchResults.Name = "_flvSearchResults";
			this._flvSearchResults.ShowGroups = false;
			this._flvSearchResults.Size = new System.Drawing.Size(679, 681);
			this._flvSearchResults.TabIndex = 0;
			this._flvSearchResults.UseCompatibleStateImageBehavior = false;
			this._flvSearchResults.View = System.Windows.Forms.View.Details;
			this._flvSearchResults.VirtualMode = true;
			this._flvSearchResults.DoubleClick += new System.EventHandler(this.On_flvSearchResults_DoubleClick);
			// 
			// olvColumn3
			// 
			this.olvColumn3.Width = 5;
			// 
			// olvColumn1
			// 
			this.olvColumn1.AspectName = "";
			this.olvColumn1.Groupable = false;
			this.olvColumn1.IsEditable = false;
			this.olvColumn1.Text = "Intel Name";
			this.olvColumn1.Width = 200;
			// 
			// olvColumn2
			// 
			this.olvColumn2.AspectName = "";
			this.olvColumn2.Text = ".NET Name";
			this.olvColumn2.Width = 300;
			// 
			// olvColumn4
			// 
			this.olvColumn4.AspectName = "";
			this.olvColumn4.FillsFreeSpace = true;
			this.olvColumn4.Text = "x86 Instruction";
			this.olvColumn4.Width = 100;
			// 
			// _tpInfo
			// 
			this._tpInfo.Controls.Add(this._tlpOutput);
			this._tpInfo.Location = new System.Drawing.Point(4, 24);
			this._tpInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this._tpInfo.Name = "_tpInfo";
			this._tpInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this._tpInfo.Size = new System.Drawing.Size(685, 685);
			this._tpInfo.TabIndex = 1;
			this._tpInfo.Text = "Intrinsic summary";
			this._tpInfo.UseVisualStyleBackColor = true;
			// 
			// _tlpOutput
			// 
			this._tlpOutput.ColumnCount = 2;
			this._tlpOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this._tlpOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpOutput.Controls.Add(this._tlpSynopsis, 1, 1);
			this._tlpOutput.Controls.Add(this.label6, 1, 4);
			this._tlpOutput.Controls.Add(this._lblDescription, 1, 3);
			this._tlpOutput.Controls.Add(this.label4, 1, 2);
			this._tlpOutput.Controls.Add(this.label2, 1, 0);
			this._tlpOutput.Controls.Add(this._fctbOperation, 1, 5);
			this._tlpOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpOutput.Location = new System.Drawing.Point(3, 2);
			this._tlpOutput.Margin = new System.Windows.Forms.Padding(0);
			this._tlpOutput.Name = "_tlpOutput";
			this._tlpOutput.RowCount = 6;
			this._tlpOutput.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpOutput.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpOutput.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpOutput.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpOutput.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpOutput.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpOutput.Size = new System.Drawing.Size(679, 681);
			this._tlpOutput.TabIndex = 3;
			this._tlpOutput.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.On_tlpOutput_CellPaint);
			// 
			// _tlpSynopsis
			// 
			this._tlpSynopsis.AutoSize = true;
			this._tlpSynopsis.ColumnCount = 2;
			this._tlpSynopsis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tlpSynopsis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpSynopsis.Controls.Add(this.label15, 0, 3);
			this._tlpSynopsis.Controls.Add(this._hlblSignture, 1, 0);
			this._tlpSynopsis.Controls.Add(this._lblCpuid, 1, 3);
			this._tlpSynopsis.Controls.Add(this.label12, 0, 2);
			this._tlpSynopsis.Controls.Add(this._lblHeader, 1, 1);
			this._tlpSynopsis.Controls.Add(this.label7, 0, 1);
			this._tlpSynopsis.Controls.Add(this.label3, 0, 0);
			this._tlpSynopsis.Controls.Add(this._lblInstruction, 1, 2);
			this._tlpSynopsis.Controls.Add(this._hlblNetCoreSignture, 1, 5);
			this._tlpSynopsis.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpSynopsis.Location = new System.Drawing.Point(5, 25);
			this._tlpSynopsis.Margin = new System.Windows.Forms.Padding(0);
			this._tlpSynopsis.Name = "_tlpSynopsis";
			this._tlpSynopsis.RowCount = 6;
			this._tlpSynopsis.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpSynopsis.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpSynopsis.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpSynopsis.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpSynopsis.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpSynopsis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tlpSynopsis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tlpSynopsis.Size = new System.Drawing.Size(674, 125);
			this._tlpSynopsis.TabIndex = 26;
			this._tlpSynopsis.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.On_tlpSynopsis_CellPaint);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.AntiqueWhite;
			this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label15.Location = new System.Drawing.Point(0, 63);
			this.label15.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.label15.Name = "label15";
			this.label15.Padding = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.label15.Size = new System.Drawing.Size(101, 20);
			this.label15.TabIndex = 7;
			this.label15.Text = "CPUID Flags:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _hlblSignture
			// 
			this._hlblSignture.BackColor = System.Drawing.SystemColors.Control;
			this._hlblSignture.BaseStylesheet = null;
			this._hlblSignture.Dock = System.Windows.Forms.DockStyle.Left;
			this._hlblSignture.Location = new System.Drawing.Point(104, 3);
			this._hlblSignture.Name = "_hlblSignture";
			this._hlblSignture.Size = new System.Drawing.Size(0, 15);
			this._hlblSignture.TabIndex = 12;
			this._hlblSignture.Text = null;
			// 
			// _lblCpuid
			// 
			this._lblCpuid.AutoSize = true;
			this._lblCpuid.BackColor = System.Drawing.Color.Transparent;
			this._lblCpuid.ContextMenuStrip = this._cmsMiscOps;
			this._lblCpuid.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblCpuid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this._lblCpuid.ForeColor = System.Drawing.Color.RosyBrown;
			this._lblCpuid.Location = new System.Drawing.Point(101, 63);
			this._lblCpuid.Margin = new System.Windows.Forms.Padding(0);
			this._lblCpuid.Name = "_lblCpuid";
			this._lblCpuid.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this._lblCpuid.Size = new System.Drawing.Size(573, 21);
			this._lblCpuid.TabIndex = 6;
			this._lblCpuid.Text = "SSE2";
			this._lblCpuid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _cmsMiscOps
			// 
			this._cmsMiscOps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.copyToClipboardToolStripMenuItem});
			this._cmsMiscOps.Name = "_cmsMiscOps";
			this._cmsMiscOps.Size = new System.Drawing.Size(170, 26);
			this._cmsMiscOps.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.On_cmsMiscOps_ItemClicked);
			// 
			// copyToClipboardToolStripMenuItem
			// 
			this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
			this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.AntiqueWhite;
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Location = new System.Drawing.Point(0, 42);
			this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.label12.Name = "label12";
			this.label12.Padding = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.label12.Size = new System.Drawing.Size(101, 20);
			this.label12.TabIndex = 4;
			this.label12.Text = "Instruction:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _lblHeader
			// 
			this._lblHeader.AutoSize = true;
			this._lblHeader.BackColor = System.Drawing.Color.Transparent;
			this._lblHeader.ContextMenuStrip = this._cmsMiscOps;
			this._lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this._lblHeader.ForeColor = System.Drawing.Color.Black;
			this._lblHeader.Location = new System.Drawing.Point(101, 21);
			this._lblHeader.Margin = new System.Windows.Forms.Padding(0);
			this._lblHeader.Name = "_lblHeader";
			this._lblHeader.Size = new System.Drawing.Size(573, 21);
			this._lblHeader.TabIndex = 3;
			this._lblHeader.Text = "emmintrin.h";
			this._lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.AntiqueWhite;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(0, 21);
			this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.label7.Size = new System.Drawing.Size(101, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Header:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(10, 3, 0, 2);
			this.label3.Size = new System.Drawing.Size(101, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Signature:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _lblInstruction
			// 
			this._lblInstruction.AutoSize = true;
			this._lblInstruction.BackColor = System.Drawing.Color.Transparent;
			this._lblInstruction.ContextMenuStrip = this._cmsMiscOps;
			this._lblInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblInstruction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this._lblInstruction.ForeColor = System.Drawing.Color.Black;
			this._lblInstruction.Location = new System.Drawing.Point(101, 42);
			this._lblInstruction.Margin = new System.Windows.Forms.Padding(0);
			this._lblInstruction.Name = "_lblInstruction";
			this._lblInstruction.Size = new System.Drawing.Size(573, 21);
			this._lblInstruction.TabIndex = 5;
			this._lblInstruction.Text = "mfence";
			this._lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _hlblNetCoreSignture
			// 
			this._hlblNetCoreSignture.AutoSize = true;
			this._hlblNetCoreSignture.BackColor = System.Drawing.SystemColors.Control;
			this._hlblNetCoreSignture.BaseStylesheet = null;
			this._hlblNetCoreSignture.Dock = System.Windows.Forms.DockStyle.Fill;
			this._hlblNetCoreSignture.Location = new System.Drawing.Point(104, 108);
			this._hlblNetCoreSignture.Name = "_hlblNetCoreSignture";
			this._hlblNetCoreSignture.Size = new System.Drawing.Size(0, 14);
			this._hlblNetCoreSignture.TabIndex = 11;
			this._hlblNetCoreSignture.Text = null;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(5, 200);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label6.Size = new System.Drawing.Size(674, 25);
			this.label6.TabIndex = 4;
			this.label6.Text = "Operation";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _lblDescription
			// 
			this._lblDescription.AutoSize = true;
			this._lblDescription.BackColor = System.Drawing.Color.Beige;
			this._lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
			this._lblDescription.Location = new System.Drawing.Point(5, 175);
			this._lblDescription.Margin = new System.Windows.Forms.Padding(0);
			this._lblDescription.Name = "_lblDescription";
			this._lblDescription.Padding = new System.Windows.Forms.Padding(10, 5, 6, 5);
			this._lblDescription.Size = new System.Drawing.Size(674, 25);
			this._lblDescription.TabIndex = 4;
			this._lblDescription.Text = "Some text";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(5, 150);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label4.Size = new System.Drawing.Size(674, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Description";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label2.Size = new System.Drawing.Size(674, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Synopsis";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _fctbOperation
			// 
			this._fctbOperation.AutoCompleteBracketsList = new char[] {
		'(',
		')',
		'{',
		'}',
		'[',
		']',
		'\"',
		'\"',
		'\'',
		'\''};
			this._fctbOperation.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
	"(?<range>:)\\s*(?<range>[^;]+);";
			this._fctbOperation.AutoScrollMinSize = new System.Drawing.Size(2, 14);
			this._fctbOperation.AutoSize = true;
			this._fctbOperation.BackBrush = null;
			this._fctbOperation.BackColor = System.Drawing.Color.WhiteSmoke;
			this._fctbOperation.CharHeight = 14;
			this._fctbOperation.CharWidth = 7;
			this._fctbOperation.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._fctbOperation.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this._fctbOperation.Dock = System.Windows.Forms.DockStyle.Fill;
			this._fctbOperation.Font = new System.Drawing.Font("Consolas", 9F);
			this._fctbOperation.IsReplaceMode = false;
			this._fctbOperation.Location = new System.Drawing.Point(8, 228);
			this._fctbOperation.Name = "_fctbOperation";
			this._fctbOperation.Paddings = new System.Windows.Forms.Padding(0);
			this._fctbOperation.ReadOnly = true;
			this._fctbOperation.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this._fctbOperation.ServiceColors = null;
			this._fctbOperation.Size = new System.Drawing.Size(668, 450);
			this._fctbOperation.TabIndex = 5;
			this._fctbOperation.Zoom = 100;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this._htbSearch);
			this.panel3.Controls.Add(this._rbIntel);
			this.panel3.Controls.Add(this._rbInstruction);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 70);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.panel3.Size = new System.Drawing.Size(693, 30);
			this.panel3.TabIndex = 26;
			// 
			// _htbSearch
			// 
			this._htbSearch.AcceptsReturn = true;
			this._htbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this._htbSearch.EnterToTab = false;
			this._htbSearch.ForeColor = System.Drawing.Color.Gray;
			this._htbSearch.HintColor = System.Drawing.Color.Gray;
			this._htbSearch.HintValue = "Search...";
			this._htbSearch.Location = new System.Drawing.Point(0, 5);
			this._htbSearch.Margin = new System.Windows.Forms.Padding(0);
			this._htbSearch.Name = "_htbSearch";
			this._htbSearch.Size = new System.Drawing.Size(509, 23);
			this._htbSearch.TabIndex = 1;
			this._htbSearch.Text = "Search...";
			this._htbSearch.TextForeColor = System.Drawing.Color.Black;
			this._htbSearch.Value = "";
			this._htbSearch.TextChanged += new System.EventHandler(this.On_htbSearch_TextChanged);
			// 
			// _rbIntel
			// 
			this._rbIntel.AutoSize = true;
			this._rbIntel.Checked = true;
			this._rbIntel.Dock = System.Windows.Forms.DockStyle.Right;
			this._rbIntel.Location = new System.Drawing.Point(509, 5);
			this._rbIntel.Margin = new System.Windows.Forms.Padding(0);
			this._rbIntel.Name = "_rbIntel";
			this._rbIntel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this._rbIntel.Size = new System.Drawing.Size(53, 25);
			this._rbIntel.TabIndex = 4;
			this._rbIntel.TabStop = true;
			this._rbIntel.Text = "Intel";
			this._rbIntel.UseVisualStyleBackColor = true;
			this._rbIntel.CheckedChanged += new System.EventHandler(this.On_rbSearchBy_CheckedChanged);
			// 
			// _rbInstruction
			// 
			this._rbInstruction.AutoSize = true;
			this._rbInstruction.Dock = System.Windows.Forms.DockStyle.Right;
			this._rbInstruction.Location = new System.Drawing.Point(611, 5);
			this._rbInstruction.Margin = new System.Windows.Forms.Padding(0);
			this._rbInstruction.Name = "_rbInstruction";
			this._rbInstruction.Size = new System.Drawing.Size(82, 25);
			this._rbInstruction.TabIndex = 3;
			this._rbInstruction.Text = "Instruction";
			this._rbInstruction.UseVisualStyleBackColor = true;
			this._rbInstruction.CheckedChanged += new System.EventHandler(this.On_rbSearchBy_CheckedChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.AllowMerge = false;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripProgressBar1});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(6, 810);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
			this.statusStrip1.Size = new System.Drawing.Size(911, 24);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripProgressBar1.MarqueeAnimationSpeed = 30;
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(116, 18);
			this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// AppForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(923, 839);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AppForm";
			this.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Intrinsics Guide";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this._tlpFilters.ResumeLayout(false);
			this._tlpFilters.PerformLayout();
			this._tlpTechnology.ResumeLayout(false);
			this._tlpTechnology.PerformLayout();
			this._tlpCategory.ResumeLayout(false);
			this._tlpCategory.PerformLayout();
			this.panel2.ResumeLayout(false);
			this._tlpInfo.ResumeLayout(false);
			this._tlpInfo.PerformLayout();
			this._tcOutput.ResumeLayout(false);
			this._tpSearchResults.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._flvSearchResults)).EndInit();
			this._tpInfo.ResumeLayout(false);
			this._tlpOutput.ResumeLayout(false);
			this._tlpOutput.PerformLayout();
			this._tlpSynopsis.ResumeLayout(false);
			this._tlpSynopsis.PerformLayout();
			this._cmsMiscOps.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._fctbOperation)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TableLayoutPanel _tlpOutput;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label _lblDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.TabControl _tcOutput;
		private System.Windows.Forms.TabPage _tpInfo;
		private System.Windows.Forms.TabPage _tpSearchResults;
		private FastColoredTextBox _fctbOperation;
		private System.Windows.Forms.TableLayoutPanel _tlpSynopsis;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label _lblHeader;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label _lblInstruction;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label _lblCpuid;
		private System.Windows.Forms.ContextMenuStrip _cmsMiscOps;
		private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
		private HtmlLabel _hlblNetCoreSignture;
		private HtmlLabel _hlblSignture;
		private FastListView _flvSearchResults;
		private OLVColumn olvColumn1;
		private System.Windows.Forms.ImageList imageList1;
		private OLVColumn olvColumn3;
		private System.Windows.Forms.TableLayoutPanel _tlpFilters;
		private System.Windows.Forms.TableLayoutPanel _tlpTechnology;
		private System.Windows.Forms.TableLayoutPanel _tlpCategory;
		private System.Windows.Forms.Label _lblTechnology;
		private System.Windows.Forms.Label _lblCategory;
		private System.Windows.Forms.TableLayoutPanel _tlpInfo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton _rbIntel;
		private HintTextBox _htbSearch;
		private System.Windows.Forms.RadioButton _rbInstruction;
		private OLVColumn olvColumn2;
		private OLVColumn olvColumn4;
	}
}

