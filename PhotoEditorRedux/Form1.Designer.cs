﻿namespace SpeedyPhotoEditor
{
    partial class Form1
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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.posStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.canvasStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.brushTrack = new System.Windows.Forms.TrackBar();
            this.brushTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.layerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.layerNameHeader = new System.Windows.Forms.Label();
            this.layerPicHeader = new System.Windows.Forms.Label();
            this.SwatchContainer = new System.Windows.Forms.Panel();
            this.deselectLayer = new System.Windows.Forms.Button();
            this.swatch4 = new System.Windows.Forms.Button();
            this.swatch3 = new System.Windows.Forms.Button();
            this.swatch2 = new System.Windows.Forms.Button();
            this.swatch1 = new System.Windows.Forms.Button();
            this.swatch0 = new System.Windows.Forms.Button();
            this.colorHolder = new System.Windows.Forms.TableLayoutPanel();
            this.tpTxt = new System.Windows.Forms.TextBox();
            this.blueTrack = new System.Windows.Forms.TrackBar();
            this.redTxt = new System.Windows.Forms.TextBox();
            this.greenTxt = new System.Windows.Forms.TextBox();
            this.blueTxt = new System.Windows.Forms.TextBox();
            this.redTrack = new System.Windows.Forms.TrackBar();
            this.greenTrack = new System.Windows.Forms.TrackBar();
            this.tpTrack = new System.Windows.Forms.TrackBar();
            this.brushShape = new System.Windows.Forms.ComboBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.subLayer = new System.Windows.Forms.Button();
            this.visLayer = new System.Windows.Forms.Button();
            this.addLayer = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsButton = new System.Windows.Forms.ToolStripButton();
            this.brushButton = new System.Windows.Forms.ToolStripButton();
            this.selectButton = new System.Windows.Forms.ToolStripButton();
            this.pickerButton = new System.Windows.Forms.ToolStripButton();
            this.eraseButton = new System.Windows.Forms.ToolStripButton();
            this.cropButton = new System.Windows.Forms.ToolStripButton();
            this.rotate90Button = new System.Windows.Forms.ToolStripButton();
            this.invertButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundButton = new System.Windows.Forms.ToolStripButton();
            this.layerCheck = new System.Windows.Forms.ToolStripButton();
            this.debugButton = new System.Windows.Forms.ToolStripButton();
            this.StatusBar.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushTrack)).BeginInit();
            this.panel2.SuspendLayout();
            this.layerContainer.SuspendLayout();
            this.SwatchContainer.SuspendLayout();
            this.colorHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posStatus,
            this.canvasStatus,
            this.selectionStatus,
            this.msg});
            this.StatusBar.Location = new System.Drawing.Point(0, 492);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(784, 22);
            this.StatusBar.TabIndex = 0;
            // 
            // posStatus
            // 
            this.posStatus.Name = "posStatus";
            this.posStatus.Size = new System.Drawing.Size(87, 17);
            this.posStatus.Text = "Position: 0, 0px";
            // 
            // canvasStatus
            // 
            this.canvasStatus.DoubleClickEnabled = true;
            this.canvasStatus.Name = "canvasStatus";
            this.canvasStatus.Size = new System.Drawing.Size(110, 17);
            this.canvasStatus.Text = "Canvas size: 0 x 0px";
            this.canvasStatus.DoubleClick += new System.EventHandler(this.canvasStatus_DoubleClick);
            // 
            // selectionStatus
            // 
            this.selectionStatus.Name = "selectionStatus";
            this.selectionStatus.Size = new System.Drawing.Size(98, 17);
            this.selectionStatus.Text = "Selection: 0 x 0px";
            // 
            // msg
            // 
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 17);
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.saveAsButton,
            this.toolStripSeparator,
            this.brushButton,
            this.selectButton,
            this.pickerButton,
            this.eraseButton,
            this.toolStripSeparator1,
            this.cropButton,
            this.rotate90Button,
            this.invertButton,
            this.toolStripSeparator2,
            this.backgroundButton,
            this.layerCheck,
            this.debugButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(784, 31);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.brushShape, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(7, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 405);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.brushTrack, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.brushTxt, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(578, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // brushTrack
            // 
            this.brushTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brushTrack.LargeChange = 10;
            this.brushTrack.Location = new System.Drawing.Point(35, 0);
            this.brushTrack.Margin = new System.Windows.Forms.Padding(0);
            this.brushTrack.Maximum = 100;
            this.brushTrack.Minimum = 1;
            this.brushTrack.Name = "brushTrack";
            this.brushTrack.Size = new System.Drawing.Size(543, 40);
            this.brushTrack.TabIndex = 0;
            this.brushTrack.TabStop = false;
            this.brushTrack.Value = 1;
            this.brushTrack.Scroll += new System.EventHandler(this.brushTrack_Scroll);
            // 
            // brushTxt
            // 
            this.brushTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brushTxt.Location = new System.Drawing.Point(0, 10);
            this.brushTxt.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.brushTxt.MaxLength = 3;
            this.brushTxt.Name = "brushTxt";
            this.brushTxt.Size = new System.Drawing.Size(35, 20);
            this.brushTxt.TabIndex = 0;
            this.brushTxt.Text = "1";
            this.brushTxt.TextChanged += new System.EventHandler(this.brushTxt_TextChanged);
            this.brushTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.layerContainer);
            this.panel2.Controls.Add(this.SwatchContainer);
            this.panel2.Controls.Add(this.colorHolder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(582, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 415);
            this.panel2.TabIndex = 2;
            // 
            // layerContainer
            // 
            this.layerContainer.AutoScroll = true;
            this.layerContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.layerContainer.ColumnCount = 3;
            this.layerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.layerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layerContainer.Controls.Add(this.layerNameHeader, 2, 0);
            this.layerContainer.Controls.Add(this.layerPicHeader, 1, 0);
            this.layerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerContainer.Location = new System.Drawing.Point(0, 215);
            this.layerContainer.Name = "layerContainer";
            this.layerContainer.RowCount = 2;
            this.layerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layerContainer.Size = new System.Drawing.Size(200, 200);
            this.layerContainer.TabIndex = 5;
            this.layerContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.layerContainer_MouseDown);
            // 
            // layerNameHeader
            // 
            this.layerNameHeader.AutoSize = true;
            this.layerNameHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerNameHeader.Location = new System.Drawing.Point(68, 2);
            this.layerNameHeader.Margin = new System.Windows.Forms.Padding(0);
            this.layerNameHeader.Name = "layerNameHeader";
            this.layerNameHeader.Size = new System.Drawing.Size(130, 40);
            this.layerNameHeader.TabIndex = 1;
            this.layerNameHeader.Text = "Name";
            // 
            // layerPicHeader
            // 
            this.layerPicHeader.AutoSize = true;
            this.layerPicHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerPicHeader.Location = new System.Drawing.Point(26, 2);
            this.layerPicHeader.Margin = new System.Windows.Forms.Padding(0);
            this.layerPicHeader.Name = "layerPicHeader";
            this.layerPicHeader.Size = new System.Drawing.Size(40, 40);
            this.layerPicHeader.TabIndex = 0;
            this.layerPicHeader.Text = "Thumb";
            // 
            // SwatchContainer
            // 
            this.SwatchContainer.Controls.Add(this.subLayer);
            this.SwatchContainer.Controls.Add(this.visLayer);
            this.SwatchContainer.Controls.Add(this.addLayer);
            this.SwatchContainer.Controls.Add(this.deselectLayer);
            this.SwatchContainer.Controls.Add(this.swatch4);
            this.SwatchContainer.Controls.Add(this.swatch3);
            this.SwatchContainer.Controls.Add(this.swatch2);
            this.SwatchContainer.Controls.Add(this.swatch1);
            this.SwatchContainer.Controls.Add(this.swatch0);
            this.SwatchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwatchContainer.Location = new System.Drawing.Point(0, 152);
            this.SwatchContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SwatchContainer.Name = "SwatchContainer";
            this.SwatchContainer.Size = new System.Drawing.Size(200, 63);
            this.SwatchContainer.TabIndex = 1;
            // 
            // deselectLayer
            // 
            this.deselectLayer.Location = new System.Drawing.Point(61, 40);
            this.deselectLayer.Name = "deselectLayer";
            this.deselectLayer.Size = new System.Drawing.Size(136, 23);
            this.deselectLayer.TabIndex = 6;
            this.deselectLayer.Text = "Deselect";
            this.deselectLayer.UseVisualStyleBackColor = true;
            this.deselectLayer.Click += new System.EventHandler(this.deselectLayer_Click);
            // 
            // swatch4
            // 
            this.swatch4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swatch4.Location = new System.Drawing.Point(163, 3);
            this.swatch4.Name = "swatch4";
            this.swatch4.Size = new System.Drawing.Size(34, 34);
            this.swatch4.TabIndex = 5;
            this.swatch4.UseVisualStyleBackColor = true;
            this.swatch4.Click += new System.EventHandler(this.swatch4_Click);
            // 
            // swatch3
            // 
            this.swatch3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swatch3.Location = new System.Drawing.Point(123, 3);
            this.swatch3.Name = "swatch3";
            this.swatch3.Size = new System.Drawing.Size(34, 34);
            this.swatch3.TabIndex = 4;
            this.swatch3.UseVisualStyleBackColor = true;
            this.swatch3.Click += new System.EventHandler(this.swatch3_Click);
            // 
            // swatch2
            // 
            this.swatch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swatch2.Location = new System.Drawing.Point(83, 3);
            this.swatch2.Name = "swatch2";
            this.swatch2.Size = new System.Drawing.Size(34, 34);
            this.swatch2.TabIndex = 3;
            this.swatch2.UseVisualStyleBackColor = true;
            this.swatch2.Click += new System.EventHandler(this.swatch2_Click);
            // 
            // swatch1
            // 
            this.swatch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swatch1.Location = new System.Drawing.Point(43, 3);
            this.swatch1.Name = "swatch1";
            this.swatch1.Size = new System.Drawing.Size(34, 34);
            this.swatch1.TabIndex = 2;
            this.swatch1.UseVisualStyleBackColor = true;
            this.swatch1.Click += new System.EventHandler(this.swatch1_Click);
            // 
            // swatch0
            // 
            this.swatch0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swatch0.Location = new System.Drawing.Point(3, 3);
            this.swatch0.Name = "swatch0";
            this.swatch0.Size = new System.Drawing.Size(34, 34);
            this.swatch0.TabIndex = 1;
            this.swatch0.UseVisualStyleBackColor = true;
            this.swatch0.Click += new System.EventHandler(this.swatch0_Click);
            // 
            // colorHolder
            // 
            this.colorHolder.ColumnCount = 2;
            this.colorHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.colorHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.colorHolder.Controls.Add(this.tpTxt, 0, 3);
            this.colorHolder.Controls.Add(this.blueTrack, 1, 2);
            this.colorHolder.Controls.Add(this.redTxt, 0, 0);
            this.colorHolder.Controls.Add(this.greenTxt, 0, 1);
            this.colorHolder.Controls.Add(this.blueTxt, 0, 2);
            this.colorHolder.Controls.Add(this.redTrack, 1, 0);
            this.colorHolder.Controls.Add(this.greenTrack, 1, 1);
            this.colorHolder.Controls.Add(this.tpTrack, 1, 3);
            this.colorHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorHolder.Location = new System.Drawing.Point(0, 0);
            this.colorHolder.Name = "colorHolder";
            this.colorHolder.RowCount = 4;
            this.colorHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.colorHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.colorHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.colorHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.colorHolder.Size = new System.Drawing.Size(200, 152);
            this.colorHolder.TabIndex = 0;
            // 
            // tpTxt
            // 
            this.tpTxt.BackColor = System.Drawing.Color.White;
            this.tpTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpTxt.Location = new System.Drawing.Point(0, 119);
            this.tpTxt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tpTxt.MaxLength = 3;
            this.tpTxt.Name = "tpTxt";
            this.tpTxt.Size = new System.Drawing.Size(35, 20);
            this.tpTxt.TabIndex = 3;
            this.tpTxt.Leave += new System.EventHandler(this.tpTxt_Leave);
            this.tpTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // blueTrack
            // 
            this.blueTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueTrack.LargeChange = 32;
            this.blueTrack.Location = new System.Drawing.Point(35, 76);
            this.blueTrack.Margin = new System.Windows.Forms.Padding(0);
            this.blueTrack.Maximum = 255;
            this.blueTrack.Name = "blueTrack";
            this.blueTrack.Size = new System.Drawing.Size(165, 38);
            this.blueTrack.TabIndex = 0;
            this.blueTrack.TabStop = false;
            this.blueTrack.Scroll += new System.EventHandler(this.blueTrack_Scroll);
            // 
            // redTxt
            // 
            this.redTxt.BackColor = System.Drawing.Color.Salmon;
            this.redTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redTxt.Location = new System.Drawing.Point(0, 5);
            this.redTxt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.redTxt.MaxLength = 3;
            this.redTxt.Name = "redTxt";
            this.redTxt.Size = new System.Drawing.Size(35, 20);
            this.redTxt.TabIndex = 0;
            this.redTxt.Leave += new System.EventHandler(this.redTxt_Leave);
            this.redTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // greenTxt
            // 
            this.greenTxt.BackColor = System.Drawing.Color.PaleGreen;
            this.greenTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenTxt.Location = new System.Drawing.Point(0, 43);
            this.greenTxt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.greenTxt.MaxLength = 3;
            this.greenTxt.Name = "greenTxt";
            this.greenTxt.Size = new System.Drawing.Size(35, 20);
            this.greenTxt.TabIndex = 1;
            this.greenTxt.Leave += new System.EventHandler(this.greenTxt_Leave);
            this.greenTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // blueTxt
            // 
            this.blueTxt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.blueTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueTxt.Location = new System.Drawing.Point(0, 81);
            this.blueTxt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.blueTxt.MaxLength = 3;
            this.blueTxt.Name = "blueTxt";
            this.blueTxt.Size = new System.Drawing.Size(35, 20);
            this.blueTxt.TabIndex = 2;
            this.blueTxt.Leave += new System.EventHandler(this.blueTxt_Leave);
            this.blueTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // redTrack
            // 
            this.redTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redTrack.LargeChange = 32;
            this.redTrack.Location = new System.Drawing.Point(35, 0);
            this.redTrack.Margin = new System.Windows.Forms.Padding(0);
            this.redTrack.Maximum = 255;
            this.redTrack.Name = "redTrack";
            this.redTrack.Size = new System.Drawing.Size(165, 38);
            this.redTrack.TabIndex = 0;
            this.redTrack.TabStop = false;
            this.redTrack.Scroll += new System.EventHandler(this.redTrack_Scroll);
            // 
            // greenTrack
            // 
            this.greenTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenTrack.LargeChange = 32;
            this.greenTrack.Location = new System.Drawing.Point(35, 38);
            this.greenTrack.Margin = new System.Windows.Forms.Padding(0);
            this.greenTrack.Maximum = 255;
            this.greenTrack.Name = "greenTrack";
            this.greenTrack.Size = new System.Drawing.Size(165, 38);
            this.greenTrack.TabIndex = 0;
            this.greenTrack.TabStop = false;
            this.greenTrack.Scroll += new System.EventHandler(this.greenTrack_Scroll);
            // 
            // tpTrack
            // 
            this.tpTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpTrack.LargeChange = 32;
            this.tpTrack.Location = new System.Drawing.Point(35, 114);
            this.tpTrack.Margin = new System.Windows.Forms.Padding(0);
            this.tpTrack.Maximum = 255;
            this.tpTrack.Name = "tpTrack";
            this.tpTrack.Size = new System.Drawing.Size(165, 38);
            this.tpTrack.TabIndex = 4;
            this.tpTrack.TabStop = false;
            this.tpTrack.Value = 255;
            this.tpTrack.Scroll += new System.EventHandler(this.tpTrack_Scroll);
            // 
            // brushShape
            // 
            this.brushShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brushShape.FormattingEnabled = true;
            this.brushShape.Items.AddRange(new object[] {
            "Line",
            "Circle",
            "Diamond",
            "Spraypaint"});
            this.brushShape.Location = new System.Drawing.Point(585, 12);
            this.brushShape.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.brushShape.Name = "brushShape";
            this.brushShape.Size = new System.Drawing.Size(194, 21);
            this.brushShape.TabIndex = 0;
            this.brushShape.SelectedIndexChanged += new System.EventHandler(this.brushShape_SelectedIndexChanged);
            // 
            // previewBox
            // 
            this.previewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previewBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.previewBox.Location = new System.Drawing.Point(741, 0);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(30, 30);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewBox.TabIndex = 3;
            this.previewBox.TabStop = false;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic.BackgroundImage = global::SpeedyPhotoEditor.Properties.Resources.tile;
            this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(400, 400);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // subLayer
            // 
            this.subLayer.BackgroundImage = global::SpeedyPhotoEditor.Properties.Resources.sub;
            this.subLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.subLayer.Location = new System.Drawing.Point(61, 40);
            this.subLayer.Name = "subLayer";
            this.subLayer.Size = new System.Drawing.Size(23, 23);
            this.subLayer.TabIndex = 9;
            this.subLayer.UseVisualStyleBackColor = true;
            this.subLayer.Visible = false;
            this.subLayer.Click += new System.EventHandler(this.subLayer_Click);
            // 
            // visLayer
            // 
            this.visLayer.BackgroundImage = global::SpeedyPhotoEditor.Properties.Resources.eye;
            this.visLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.visLayer.Location = new System.Drawing.Point(3, 40);
            this.visLayer.Name = "visLayer";
            this.visLayer.Size = new System.Drawing.Size(23, 23);
            this.visLayer.TabIndex = 8;
            this.visLayer.UseVisualStyleBackColor = true;
            this.visLayer.Click += new System.EventHandler(this.visLayer_Click);
            // 
            // addLayer
            // 
            this.addLayer.BackgroundImage = global::SpeedyPhotoEditor.Properties.Resources.add;
            this.addLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addLayer.Location = new System.Drawing.Point(32, 40);
            this.addLayer.Name = "addLayer";
            this.addLayer.Size = new System.Drawing.Size(23, 23);
            this.addLayer.TabIndex = 7;
            this.addLayer.UseVisualStyleBackColor = true;
            this.addLayer.Click += new System.EventHandler(this.addLayer_Click);
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = global::SpeedyPhotoEditor.Properties.Resources.file;
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(28, 28);
            this.newButton.Text = "New";
            this.newButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newButton_MouseUp);
            this.newButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newButton_MouseDown);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = global::SpeedyPhotoEditor.Properties.Resources.upload;
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(28, 28);
            this.openButton.Text = "Open";
            this.openButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openButton_MouseUp);
            this.openButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openButton_MouseDown);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::SpeedyPhotoEditor.Properties.Resources.save;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(28, 28);
            this.saveButton.Text = "Save";
            this.saveButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseUp);
            this.saveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseDown);
            // 
            // saveAsButton
            // 
            this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsButton.Image = global::SpeedyPhotoEditor.Properties.Resources.saveas;
            this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(28, 28);
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.ToolTipText = "Save As";
            this.saveAsButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveAsButton_MouseUp);
            this.saveAsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saveAsButton_MouseDown);
            // 
            // brushButton
            // 
            this.brushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushButton.Image = global::SpeedyPhotoEditor.Properties.Resources.brush;
            this.brushButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(28, 28);
            this.brushButton.Text = "Brush";
            this.brushButton.ToolTipText = "Brush";
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectButton.Image = global::SpeedyPhotoEditor.Properties.Resources.selectsel;
            this.selectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(28, 28);
            this.selectButton.Text = "Select";
            this.selectButton.ToolTipText = "Select";
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // pickerButton
            // 
            this.pickerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickerButton.Image = global::SpeedyPhotoEditor.Properties.Resources.picker;
            this.pickerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickerButton.Name = "pickerButton";
            this.pickerButton.Size = new System.Drawing.Size(28, 28);
            this.pickerButton.Text = "Color Picker";
            this.pickerButton.Click += new System.EventHandler(this.pickerButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraseButton.Image = global::SpeedyPhotoEditor.Properties.Resources.erase;
            this.eraseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(28, 28);
            this.eraseButton.Text = "Erase";
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // cropButton
            // 
            this.cropButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cropButton.Image = global::SpeedyPhotoEditor.Properties.Resources.crop;
            this.cropButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cropButton.Name = "cropButton";
            this.cropButton.Size = new System.Drawing.Size(28, 28);
            this.cropButton.Text = "Crop To Selection";
            this.cropButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cropButton_MouseUp);
            this.cropButton.Click += new System.EventHandler(this.cropButton_Click);
            // 
            // rotate90Button
            // 
            this.rotate90Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotate90Button.Image = global::SpeedyPhotoEditor.Properties.Resources.rotate90;
            this.rotate90Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotate90Button.Name = "rotate90Button";
            this.rotate90Button.Size = new System.Drawing.Size(28, 28);
            this.rotate90Button.Text = "Rotate 90 Degrees";
            this.rotate90Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rotate90Button_MouseUp);
            this.rotate90Button.Click += new System.EventHandler(this.Rotate90_Click);
            // 
            // invertButton
            // 
            this.invertButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invertButton.Image = global::SpeedyPhotoEditor.Properties.Resources.invert;
            this.invertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(28, 28);
            this.invertButton.Text = "Invert";
            this.invertButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.invertButton_MouseUp);
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // backgroundButton
            // 
            this.backgroundButton.BackColor = System.Drawing.Color.Transparent;
            this.backgroundButton.BackgroundImage = global::SpeedyPhotoEditor.Properties.Resources.bg1;
            this.backgroundButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundButton.Image = global::SpeedyPhotoEditor.Properties.Resources.bg;
            this.backgroundButton.ImageTransparentColor = System.Drawing.SystemColors.ScrollBar;
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(28, 28);
            this.backgroundButton.Text = "Background Preview Color";
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // layerCheck
            // 
            this.layerCheck.Image = global::SpeedyPhotoEditor.Properties.Resources.cl;
            this.layerCheck.ImageTransparentColor = System.Drawing.SystemColors.ScrollBar;
            this.layerCheck.Name = "layerCheck";
            this.layerCheck.Size = new System.Drawing.Size(140, 28);
            this.layerCheck.Text = "Layer added images";
            this.layerCheck.ToolTipText = "Layer added images";
            this.layerCheck.Click += new System.EventHandler(this.layerCheck_Click);
            // 
            // debugButton
            // 
            this.debugButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.debugButton.Image = global::SpeedyPhotoEditor.Properties.Resources.magic;
            this.debugButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(28, 28);
            this.debugButton.Text = "magic";
            this.debugButton.ToolTipText = "debugButton";
            this.debugButton.Visible = false;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 514);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.StatusBar);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "Speedy Photo Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushTrack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.layerContainer.ResumeLayout(false);
            this.layerContainer.PerformLayout();
            this.SwatchContainer.ResumeLayout(false);
            this.colorHolder.ResumeLayout(false);
            this.colorHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar brushTrack;
        private System.Windows.Forms.TextBox brushTxt;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton saveAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton brushButton;
        private System.Windows.Forms.ToolStripButton selectButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel colorHolder;
        private System.Windows.Forms.TextBox redTxt;
        private System.Windows.Forms.TextBox greenTxt;
        private System.Windows.Forms.TextBox blueTxt;
        private System.Windows.Forms.TrackBar redTrack;
        private System.Windows.Forms.TrackBar blueTrack;
        private System.Windows.Forms.TrackBar greenTrack;
        private System.Windows.Forms.ToolStripStatusLabel posStatus;
        private System.Windows.Forms.ToolStripStatusLabel canvasStatus;
        private System.Windows.Forms.ToolStripStatusLabel selectionStatus;
        private System.Windows.Forms.Panel SwatchContainer;
        private System.Windows.Forms.Button swatch0;
        private System.Windows.Forms.Button swatch4;
        private System.Windows.Forms.Button swatch3;
        private System.Windows.Forms.Button swatch2;
        private System.Windows.Forms.Button swatch1;
        private System.Windows.Forms.ComboBox brushShape;
        private System.Windows.Forms.ToolStripStatusLabel msg;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cropButton;
        private System.Windows.Forms.ToolStripButton rotate90Button;
        private System.Windows.Forms.TableLayoutPanel layerContainer;
        private System.Windows.Forms.ToolStripButton debugButton;
        private System.Windows.Forms.Label layerNameHeader;
        private System.Windows.Forms.Label layerPicHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton layerCheck;
        private System.Windows.Forms.ToolStripButton pickerButton;
        private System.Windows.Forms.ToolStripButton backgroundButton;
        private System.Windows.Forms.Button deselectLayer;
        private System.Windows.Forms.ToolStripButton eraseButton;
        private System.Windows.Forms.TextBox tpTxt;
        private System.Windows.Forms.TrackBar tpTrack;
        private System.Windows.Forms.Button addLayer;
        private System.Windows.Forms.Button visLayer;
        private System.Windows.Forms.ToolStripButton invertButton;
        private System.Windows.Forms.Button subLayer;
    }
}

