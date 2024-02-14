using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Speedy_Photo_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private Form1 _instance = null;
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if(_instance == null)
            {
                _instance = new Form1();
                _instance.Show();
            }
            else
            {
                _instance.Activate();
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "Pictures";
                openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                Canvas.Image = Image.FromFile(filePath);
                Canvas.Size = Image.FromFile(filePath).Size;
            }
            Text = filePath;
            
        }
        bool clicked = false;
        private void layercheck_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                layercheck.Image = Image.FromFile("C:\\Users\\legos\\OneDrive\\Pictures\\uncl.png");
                clicked = false;

            }
            else
            {
                layercheck.Image = Image.FromFile("C:\\Users\\legos\\OneDrive\\Pictures\\cl.png");
                clicked = true;
            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = "" + trackBar1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Int32.Parse(textBox1.Text);
        }


        private void Canvas_Resize(object sender, EventArgs e)
        {

        }
    }
}
