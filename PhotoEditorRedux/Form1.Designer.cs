namespace SpeedyPhotoEditor
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
            this.swatch4 = new System.Windows.Forms.Button();
            this.swatch3 = new System.Windows.Forms.Button();
            this.swatch2 = new System.Windows.Forms.Button();
            this.swatch1 = new System.Windows.Forms.Button();
            this.swatch0 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.blueTrack = new System.Windows.Forms.TrackBar();
            this.redTxt = new System.Windows.Forms.TextBox();
            this.greenTxt = new System.Windows.Forms.TextBox();
            this.blueTxt = new System.Windows.Forms.TextBox();
            this.redTrack = new System.Windows.Forms.TrackBar();
            this.greenTrack = new System.Windows.Forms.TrackBar();
            this.brushShape = new System.Windows.Forms.ComboBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.DB2 = new System.Windows.Forms.PictureBox();
            this.DB1 = new System.Windows.Forms.PictureBox();
            this.DB = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsButton = new System.Windows.Forms.ToolStripButton();
            this.brushButton = new System.Windows.Forms.ToolStripButton();
            this.selectButton = new System.Windows.Forms.ToolStripButton();
            this.pickerButton = new System.Windows.Forms.ToolStripButton();
            this.cropButton = new System.Windows.Forms.ToolStripButton();
            this.rotate90Button = new System.Windows.Forms.ToolStripButton();
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
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.LightGray;
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
            this.canvasStatus.Name = "canvasStatus";
            this.canvasStatus.Size = new System.Drawing.Size(110, 17);
            this.canvasStatus.Text = "Canvas size: 0 x 0px";
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
            this.ToolBar.BackColor = System.Drawing.Color.LightGray;
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
            this.toolStripSeparator1,
            this.cropButton,
            this.rotate90Button,
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
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
            this.panel1.Size = new System.Drawing.Size(554, 405);
            this.panel1.TabIndex = 0;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 40);
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
            this.brushTrack.Size = new System.Drawing.Size(529, 40);
            this.brushTrack.TabIndex = 0;
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
            this.brushTxt.TabIndex = 1;
            this.brushTxt.Text = "1";
            this.brushTxt.TextChanged += new System.EventHandler(this.brushTxt_TextChanged);
            this.brushTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.brushTxt_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.layerContainer);
            this.panel2.Controls.Add(this.DB2);
            this.panel2.Controls.Add(this.DB1);
            this.panel2.Controls.Add(this.DB);
            this.panel2.Controls.Add(this.SwatchContainer);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(568, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 415);
            this.panel2.TabIndex = 2;
            // 
            // layerContainer
            // 
            this.layerContainer.AutoScroll = true;
            this.layerContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.layerContainer.ColumnCount = 3;
            this.layerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layerContainer.Controls.Add(this.layerNameHeader, 2, 0);
            this.layerContainer.Controls.Add(this.layerPicHeader, 1, 0);
            this.layerContainer.Location = new System.Drawing.Point(3, 161);
            this.layerContainer.Name = "layerContainer";
            this.layerContainer.RowCount = 2;
            this.layerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.layerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layerContainer.Size = new System.Drawing.Size(194, 201);
            this.layerContainer.TabIndex = 5;
            // 
            // layerNameHeader
            // 
            this.layerNameHeader.AutoSize = true;
            this.layerNameHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerNameHeader.Location = new System.Drawing.Point(66, 2);
            this.layerNameHeader.Margin = new System.Windows.Forms.Padding(0);
            this.layerNameHeader.Name = "layerNameHeader";
            this.layerNameHeader.Size = new System.Drawing.Size(126, 16);
            this.layerNameHeader.TabIndex = 1;
            this.layerNameHeader.Text = "Name";
            // 
            // layerPicHeader
            // 
            this.layerPicHeader.AutoSize = true;
            this.layerPicHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerPicHeader.Location = new System.Drawing.Point(24, 2);
            this.layerPicHeader.Margin = new System.Windows.Forms.Padding(0);
            this.layerPicHeader.Name = "layerPicHeader";
            this.layerPicHeader.Size = new System.Drawing.Size(40, 16);
            this.layerPicHeader.TabIndex = 0;
            this.layerPicHeader.Text = "Thumb";
            // 
            // SwatchContainer
            // 
            this.SwatchContainer.Controls.Add(this.swatch4);
            this.SwatchContainer.Controls.Add(this.swatch3);
            this.SwatchContainer.Controls.Add(this.swatch2);
            this.SwatchContainer.Controls.Add(this.swatch1);
            this.SwatchContainer.Controls.Add(this.swatch0);
            this.SwatchContainer.Location = new System.Drawing.Point(0, 117);
            this.SwatchContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SwatchContainer.Name = "SwatchContainer";
            this.SwatchContainer.Size = new System.Drawing.Size(200, 40);
            this.SwatchContainer.TabIndex = 1;
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.blueTrack, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.redTxt, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.greenTxt, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.blueTxt, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.redTrack, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.greenTrack, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 114);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // blueTrack
            // 
            this.blueTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueTrack.LargeChange = 32;
            this.blueTrack.Location = new System.Drawing.Point(35, 76);
            this.blueTrack.Margin = new System.Windows.Forms.Padding(0);
            this.blueTrack.Maximum = 255;
            this.blueTrack.Name = "blueTrack";
            this.blueTrack.Size = new System.Drawing.Size(179, 38);
            this.blueTrack.TabIndex = 5;
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
            this.redTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.redTxt_KeyPress);
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
            this.greenTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.greenTxt_KeyPress);
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
            this.blueTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blueTxt_KeyPress);
            // 
            // redTrack
            // 
            this.redTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redTrack.LargeChange = 32;
            this.redTrack.Location = new System.Drawing.Point(35, 0);
            this.redTrack.Margin = new System.Windows.Forms.Padding(0);
            this.redTrack.Maximum = 255;
            this.redTrack.Name = "redTrack";
            this.redTrack.Size = new System.Drawing.Size(179, 38);
            this.redTrack.TabIndex = 3;
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
            this.greenTrack.Size = new System.Drawing.Size(179, 38);
            this.greenTrack.TabIndex = 4;
            this.greenTrack.Scroll += new System.EventHandler(this.greenTrack_Scroll);
            // 
            // brushShape
            // 
            this.brushShape.FormattingEnabled = true;
            this.brushShape.Items.AddRange(new object[] {
            "Line",
            "Circle",
            "Diamond"});
            this.brushShape.Location = new System.Drawing.Point(571, 12);
            this.brushShape.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.brushShape.Name = "brushShape";
            this.brushShape.Size = new System.Drawing.Size(194, 21);
            this.brushShape.TabIndex = 3;
            this.brushShape.Text = "Line";
            this.brushShape.SelectedIndexChanged += new System.EventHandler(this.brushShape_SelectedIndexChanged);
            // 
            // previewBox
            // 
            this.previewBox.BackColor = System.Drawing.Color.LightGray;
            this.previewBox.Location = new System.Drawing.Point(752, 1);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(30, 30);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewBox.TabIndex = 3;
            this.previewBox.TabStop = false;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(437, 309);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // DB2
            // 
            this.DB2.BackColor = System.Drawing.Color.Transparent;
            this.DB2.Image = global::SpeedyPhotoEditor.Properties.Resources._936996628718563379;
            this.DB2.Location = new System.Drawing.Point(0, 368);
            this.DB2.Name = "DB2";
            this.DB2.Size = new System.Drawing.Size(46, 47);
            this.DB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DB2.TabIndex = 4;
            this.DB2.TabStop = false;
            // 
            // DB1
            // 
            this.DB1.Image = global::SpeedyPhotoEditor.Properties.Resources._936996628718563379;
            this.DB1.Location = new System.Drawing.Point(90, 368);
            this.DB1.Name = "DB1";
            this.DB1.Size = new System.Drawing.Size(47, 49);
            this.DB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DB1.TabIndex = 3;
            this.DB1.TabStop = false;
            // 
            // DB
            // 
            this.DB.BackColor = System.Drawing.Color.Transparent;
            this.DB.Image = global::SpeedyPhotoEditor.Properties.Resources._936996628718563379;
            this.DB.Location = new System.Drawing.Point(43, 368);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(47, 47);
            this.DB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DB.TabIndex = 2;
            this.DB.TabStop = false;
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
            // backgroundButton
            // 
            this.backgroundButton.BackColor = System.Drawing.Color.Transparent;
            this.backgroundButton.BackgroundImage = global::SpeedyPhotoEditor.Properties.Resources.bg1;
            this.backgroundButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundButton.Image = global::SpeedyPhotoEditor.Properties.Resources.bg;
            this.backgroundButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(28, 28);
            this.backgroundButton.Text = "Background Color";
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // layerCheck
            // 
            this.layerCheck.Image = global::SpeedyPhotoEditor.Properties.Resources.cl;
            this.layerCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
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
            this.debugButton.Text = "toolStripButton1";
            this.debugButton.ToolTipText = "debugButton";
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
            this.MinimumSize = new System.Drawing.Size(200, 100);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
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
        private System.Windows.Forms.PictureBox DB;
        private System.Windows.Forms.PictureBox DB2;
        private System.Windows.Forms.PictureBox DB1;
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
    }
}

