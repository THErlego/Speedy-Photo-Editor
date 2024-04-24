namespace SpeedyPhotoEditor
{
    partial class ResizeForm
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
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.ratioCheck = new System.Windows.Forms.CheckBox();
            this.resizeCheck = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.Button();
            this.px = new System.Windows.Forms.Label();
            this.px2 = new System.Windows.Forms.Label();
            this.aspTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(13, 16);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(55, 13);
            this.widthBox.MaxLength = 5;
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 1;
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            this.widthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthBox_KeyPress);
            this.widthBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthBox_Validating);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(13, 55);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(55, 52);
            this.heightBox.MaxLength = 5;
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 3;
            this.heightBox.TextChanged += new System.EventHandler(this.HeightBox_TextChanged);
            this.heightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightBox_KeyPress);
            this.heightBox.Validating += new System.ComponentModel.CancelEventHandler(this.heightBox_Validating);
            // 
            // ratioCheck
            // 
            this.ratioCheck.AutoSize = true;
            this.ratioCheck.Location = new System.Drawing.Point(16, 78);
            this.ratioCheck.Name = "ratioCheck";
            this.ratioCheck.Size = new System.Drawing.Size(130, 17);
            this.ratioCheck.TabIndex = 4;
            this.ratioCheck.Text = "Maintain Aspect Ratio";
            this.ratioCheck.UseVisualStyleBackColor = true;
            this.ratioCheck.CheckedChanged += new System.EventHandler(this.ratioCheck_CheckedChanged);
            // 
            // resizeCheck
            // 
            this.resizeCheck.AutoSize = true;
            this.resizeCheck.Checked = true;
            this.resizeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resizeCheck.Location = new System.Drawing.Point(16, 101);
            this.resizeCheck.Name = "resizeCheck";
            this.resizeCheck.Size = new System.Drawing.Size(90, 17);
            this.resizeCheck.TabIndex = 5;
            this.resizeCheck.Text = "Resize Image";
            this.resizeCheck.UseVisualStyleBackColor = true;
            this.resizeCheck.CheckedChanged += new System.EventHandler(this.resizeCheck_CheckedChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(97, 129);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // px
            // 
            this.px.AutoSize = true;
            this.px.Location = new System.Drawing.Point(154, 16);
            this.px.Name = "px";
            this.px.Size = new System.Drawing.Size(18, 13);
            this.px.TabIndex = 7;
            this.px.Text = "px";
            // 
            // px2
            // 
            this.px2.AutoSize = true;
            this.px2.Location = new System.Drawing.Point(154, 55);
            this.px2.Name = "px2";
            this.px2.Size = new System.Drawing.Size(18, 13);
            this.px2.TabIndex = 8;
            this.px2.Text = "px";
            // 
            // aspTxt
            // 
            this.aspTxt.AutoSize = true;
            this.aspTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspTxt.Location = new System.Drawing.Point(55, 36);
            this.aspTxt.Name = "aspTxt";
            this.aspTxt.Size = new System.Drawing.Size(72, 13);
            this.aspTxt.TabIndex = 9;
            this.aspTxt.Text = "Aspect Ratio: ";
            // 
            // ResizeForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 164);
            this.Controls.Add(this.aspTxt);
            this.Controls.Add(this.px2);
            this.Controls.Add(this.px);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.resizeCheck);
            this.Controls.Add(this.ratioCheck);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.widthLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Size";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.CheckBox ratioCheck;
        private System.Windows.Forms.CheckBox resizeCheck;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label px;
        private System.Windows.Forms.Label px2;
        private System.Windows.Forms.Label aspTxt;
    }
}