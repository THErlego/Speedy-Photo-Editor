using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpeedyPhotoEditor
{
    public partial class ResizeForm : Form
    {
        SpeedyPhotoEditor.IniFile settings = new IniFile("Settings.ini");
        float aspe;
        bool wb, hb; //selection statuses
        public ResizeForm(int wi, int he, float asp)
        {
            aspe = asp;
            InitializeComponent();
            aspTxt.Text = "Aspect Ratio: " + asp;
            widthBox.Text = wi + "";
            heightBox.Text = he + "";
            ratioCheck.Checked = bool.Parse(settings.Read("Keep_Ratio", "Resize"));
            resizeCheck.Checked = bool.Parse(settings.Read("Keep_Resize", "Resize"));
            OK.DialogResult = DialogResult.OK;
        }
        private void widthBox_TextChanged(object sender, EventArgs e)
        {
            if (widthBox.Text != "")
            {
                if (ratioCheck.Checked && wb)
                {
                    heightBox.Text = (int)(Int32.Parse(widthBox.Text) / aspe) + "";
                }
            }
            
        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            if (heightBox.Text != "")
            {
                if (ratioCheck.Checked && hb)
                {
                    widthBox.Text = (int)(Int32.Parse(heightBox.Text) * aspe) + "";
                }
            }
            
        }
        public int getWidth()
        {
            return (Int32.Parse(widthBox.Text));
        }
        public int getHeight()
        {
            return (Int32.Parse(heightBox.Text));
        }
        public bool getResizeStatus()
        {
            return resizeCheck.Checked;
        }
        public bool getRatioStatus()
        {
            return ratioCheck.Checked;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void widthBox_Validating(object sender, CancelEventArgs e)
        {
            wb = true;
            hb = false;
        }

        private void heightBox_Validating(object sender, CancelEventArgs e)
        {
            wb = false;
            hb = true;
        }

        private void widthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void heightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ratioCheck_CheckedChanged(object sender, EventArgs e)
        {
            settings.Write("Keep_Ratio", ratioCheck.Checked.ToString(), "Resize");
        }

        private void resizeCheck_CheckedChanged(object sender, EventArgs e)
        {
            settings.Write("Keep_Resize", resizeCheck.Checked.ToString(), "Resize");
        }

    }
}
