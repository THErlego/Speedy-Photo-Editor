namespace Speedy_Photo_Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            Position = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            layercheck = new ToolStripButton();
            body = new TableLayoutPanel();
            BrushControl = new FlowLayoutPanel();
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            CanContainer = new Panel();
            Canvas = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            body.SuspendLayout();
            BrushControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            CanContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.LightGray;
            statusStrip1.Items.AddRange(new ToolStripItem[] { Position });
            statusStrip1.Location = new Point(0, 533);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // Position
            // 
            Position.Name = "Position";
            Position.Size = new Size(56, 17);
            Position.Text = "Hovering";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.LightGray;
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, printToolStripButton, toolStripSeparator, cutToolStripButton, copyToolStripButton, pasteToolStripButton, toolStripSeparator1, layercheck });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += newToolStripButton_Click;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 22);
            openToolStripButton.Text = "&Open";
            openToolStripButton.Click += openToolStripButton_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(23, 22);
            printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = (Image)resources.GetObject("cutToolStripButton.Image");
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(23, 22);
            cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = (Image)resources.GetObject("copyToolStripButton.Image");
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(23, 22);
            copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = (Image)resources.GetObject("pasteToolStripButton.Image");
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(23, 22);
            pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // layercheck
            // 
            layercheck.Image = (Image)resources.GetObject("layercheck.Image");
            layercheck.ImageTransparentColor = Color.Magenta;
            layercheck.Name = "layercheck";
            layercheck.Size = new Size(161, 22);
            layercheck.Text = "Add new layer for images";
            layercheck.Click += layercheck_Click;
            // 
            // body
            // 
            body.ColumnCount = 2;
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            body.Controls.Add(BrushControl, 0, 0);
            body.Controls.Add(CanContainer, 0, 1);
            body.Dock = DockStyle.Fill;
            body.Location = new Point(0, 25);
            body.Name = "body";
            body.RowCount = 2;
            body.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            body.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            body.Size = new Size(800, 508);
            body.TabIndex = 2;
            // 
            // BrushControl
            // 
            BrushControl.BackColor = Color.Transparent;
            BrushControl.Controls.Add(textBox1);
            BrushControl.Controls.Add(trackBar1);
            BrushControl.Dock = DockStyle.Top;
            BrushControl.Location = new Point(3, 3);
            BrushControl.Name = "BrushControl";
            BrushControl.Size = new Size(614, 30);
            BrushControl.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Location = new Point(3, 3);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(39, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.ControlLight;
            trackBar1.Location = new Point(48, 3);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(556, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // CanContainer
            // 
            CanContainer.AutoScroll = true;
            CanContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CanContainer.Controls.Add(Canvas);
            CanContainer.Dock = DockStyle.Fill;
            CanContainer.Location = new Point(3, 39);
            CanContainer.Name = "CanContainer";
            CanContainer.Size = new Size(614, 466);
            CanContainer.TabIndex = 2;
            // 
            // Canvas
            // 
            Canvas.BackColor = SystemColors.ControlLightLight;
            Canvas.Cursor = Cursors.Cross;
            Canvas.Location = new Point(0, -4);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(500, 261);
            Canvas.TabIndex = 1;
            Canvas.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 555);
            Controls.Add(body);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(100, 100);
            Name = "Form1";
            Text = "Speedy Photo Editor";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            body.ResumeLayout(false);
            BrushControl.ResumeLayout(false);
            BrushControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            CanContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Position;
        private ToolStrip toolStrip1;
        private TableLayoutPanel body;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton layercheck;
        private FlowLayoutPanel BrushControl;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox Canvas;
        private Panel CanContainer;
    }
}
