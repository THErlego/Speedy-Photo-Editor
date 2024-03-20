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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            canvasStatus.Text = "Canvas size: " + pic.Width + " x " + pic.Height + "px";
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            pic.Image = bm;
            //config load
            configLoad();
            
        }

        Bitmap bm; //initial image
        Bitmap rm; //saved image
        Bitmap dim;//temp crop image
        Graphics g;
        Graphics SelectedGraphics = null;
        Bitmap SelectedImage = null;
        private Form1 _instance = null;
        bool select = true;
        bool md = false;
        bool shiftHold = false;
        int re,gr,bl = 0;
        int alpha = 255;
        Point px, py;
        Pen brush = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
        SolidBrush brushFill = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
        SpeedyPhotoEditor.IniFile settings = new IniFile("Settings.ini");

        public void configCreate()
        {
            settings.Write("Canvas_Width", "400", "Canvas");
            settings.Write("Canvas_Height", "400", "Canvas");
            settings.Write("Brush_Width", "1", "Brush");
            settings.Write("Brush_Type", "Line", "Brush");
        }
        public void configLoad()
        {

            try
            {
                pic.Width = Int32.Parse(settings.Read("Canvas_Width", "Canvas"));
                pic.Height = Int32.Parse(settings.Read("Canvas_Height", "Canvas"));
                brush.Width = Int32.Parse(settings.Read("Brush_Width", "Brush"));
                brushTrack.Value = Int32.Parse(settings.Read("Brush_Width", "Brush"));
                brushTxt.Text = settings.Read("Brush_Width", "Brush");
                brushShape.Text = settings.Read("Brush_Type", "Brush");
            }
            catch
            {
                configCreate();
            }
        }
        //KEYS
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (!md) return;
                md = false;

                // Stop selecting.
                SelectedImage = null;
                SelectedGraphics = null;
                pic.Image = rm;
                pic.Refresh();
            }
            if (e.KeyChar == 102)
            {
                if (select)
                {
                    brushButton.Image = Properties.Resources.brushsel;
                    selectButton.Image = Properties.Resources.select;
                    select = false;
                }
                else
                {
                    brushButton.Image = Properties.Resources.brush;
                    selectButton.Image = Properties.Resources.selectsel;
                    select = true;
                }
            }
            if (e.KeyChar == 8 && select == true)
            {
                g.DrawRectangle(new Pen(Color.White), new Rectangle(20, 20, 20, 20));
                
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 16)
            {
                shiftHold = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 16)
            {
                shiftHold = false;
            }
        }
        //BRUSH
        private void brushButton_Click(object sender, EventArgs e)
        {
            brushButton.Image = Properties.Resources.brushsel;
            selectButton.Image = Properties.Resources.select;
            select = false;
        }

        //SELECT
        private void selectButton_Click(object sender, EventArgs e)
        {
            brushButton.Image = Properties.Resources.brush;
            selectButton.Image = Properties.Resources.selectsel;
            select = true;
        }

        //NEW
        private void newButton_MouseDown(object sender, MouseEventArgs e)
        {

            newButton.Image = Properties.Resources.filesel;
            if (_instance == null)
            {
                _instance = new Form1();
                _instance.Show();
                
            }
            else
            {
                _instance.Activate();
            }
        }

        //OPEN
        bool imgFirst = false;
        String filePath;
        bool imgDrop = false;
        private void openButton_MouseDown(object sender, MouseEventArgs e)
        {
            openButton.Image = Properties.Resources.uploadsel;
            filePath = string.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "Pictures";
                ofd.Filter = "Image Files (*.jpg;*I.jpeg;*.png;*.bmp)|*.jpg;*I.jpeg;*.png;*.bmp|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                //open
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    var fileStream = ofd.OpenFile();
                }
                openButton.Image = Properties.Resources.upload;
                //insert
                if (!imgFirst)
                {
                    pic.Size = Image.FromFile(filePath).Size;
                    rm = new Bitmap(bm, new Size(Image.FromFile(filePath).Width, Image.FromFile(filePath).Height));
                    pic.Image = rm;
                    g = Graphics.FromImage(rm);
                    imgFirst = true;
                    g.DrawImage(Bitmap.FromFile(filePath), 0, 0);
                }
                else
                {
                    imgDrop = true;
                    msg.Text = "Select a location to drop image, SHIFT to paste multiple";
                    previewBox.Image = Image.FromFile(filePath); 
                    
                    //if (pic.Width < Image.FromFile(filePath).Width || pic.Height < Image.FromFile(filePath).Height)
                    //{ 
                    //    pic.Size = Image.FromFile(filePath).Size;
                    //}
                    //rm = new Bitmap(rm, pic.Size, System.Drawing.Imaging.PixelFormat );
                    //pic.Image = rm;
                    //g = Graphics.FromImage(rm);
                    //createSelection(new Point(Image.FromFile(filePath).Width, Image.FromFile(filePath).Height),new Point(20, 10));
                    canvasStatus.Text = "Canvas size: " + pic.Width + " x " + pic.Height + "px";
                }
                settings.Write("Canvas_Width", pic.Width + "", "Canvas");
                settings.Write("Canvas_Height", pic.Height + "", "Canvas");
                pic.Refresh();
            }
        }

        //SAVE
        String saveloc = "";
        public void saveFile()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG(*.PNG)|*.png";

            if (save.ShowDialog() == DialogResult.OK)
            {
                pic.Image.Save(save.FileName);
                saveloc = save.FileName;
                Text = saveloc;
            }
        }
        private void saveButton_MouseDown(object sender, MouseEventArgs e)
        {
            saveButton.Image = Properties.Resources.savesel;
            if (saveloc == "")
            {
                saveFile();
            }
            else
            {
                pic.Image.Save(saveloc);
            }
        }
        
        //SAVEAS
        private void saveAsButton_MouseDown(object sender, MouseEventArgs e)
        {
            saveAsButton.Image = Properties.Resources.saveassel;
            saveFile();
        }
        //CROP TO SELECTION
        private void cropButton_Click(object sender, EventArgs e)
        {
            cropButton.Image = Properties.Resources.cropsel;
            //if selection is made
            if (selectBox != null && selectBox.Width > 1 && selectBox.Height > 1)
            {
                rm = dim;
                pic.Size = selectBox.Size;
                pic.Image = rm;
                canvasStatus.Text = "Canvas size: " + pic.Width + " x " + pic.Height + "px";
                pic.Refresh();
            }
        }
        //ROTATE 90
        private Bitmap ModifiedBitmap(Image original_image, RotateFlipType rotate_flip_type)
        {
            // Copy the Bitmap.
            Bitmap new_bitmap = new Bitmap(original_image);

            // Rotate and flip.
            new_bitmap.RotateFlip(rotate_flip_type);

            // Return the result.
            return new_bitmap;
        }
        private void Rotate90_Click(object sender, EventArgs e)
        {
            rotate90Button.Image = Properties.Resources.rotate90sel;
            if (selectBox != null && selectBox.Width > 1 && selectBox.Height > 1)
            {
                int wid = selectBox.Width;
                int hei = selectBox.Height;
                selectBox.Width = hei;
                selectBox.Height = wid;
                selectBox.Image = ModifiedBitmap(selectBox.Image, RotateFlipType.Rotate90FlipNone);
                dim = ModifiedBitmap(dim, RotateFlipType.Rotate90FlipNone);
                selectBox.Refresh();
            }
        }
        //BRUSH WIDTH
        private void brushTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void brushTxt_TextChanged(object sender, EventArgs e)
        {
            if (brushTxt.Text != "")
            {
                if (Int16.Parse(brushTxt.Text) <= 100)
                {
                    brushTrack.Value = Int16.Parse(brushTxt.Text);
                    brush.Width = brushTrack.Value;
                    settings.Write("Brush_Width", brush.Width + "", "Brush");
                }
                else
                {
                    brushTrack.Value = 100;
                    brush.Width = brushTrack.Value;
                }
            }
        }
        private void brushTrack_Scroll(object sender, EventArgs e)
        {
            brushTxt.Text = "" + brushTrack.Value;
            brush.Width = brushTrack.Value;
            settings.Write("Brush_Width", brush.Width + "", "Brush");
        }
        //BRUSH TYPE

        private void brushShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.Write("Brush_Type", brushShape.Text, "Brush");
        }
        //MOUSEUP STYLES
        private void newButton_MouseUp(object sender, MouseEventArgs e)
        {
            newButton.Image = Properties.Resources.file;
        }
        private void openButton_MouseUp(object sender, MouseEventArgs e)
        {
            openButton.Image = Properties.Resources.upload;
        }
        private void saveButton_MouseUp(object sender, MouseEventArgs e)
        {
            saveButton.Image = Properties.Resources.save;
        }
        private void saveAsButton_MouseUp(object sender, MouseEventArgs e)
        {
            saveAsButton.Image = Properties.Resources.saveas;
        }
        private void cropButton_MouseUp(object sender, MouseEventArgs e)
        {
            cropButton.Image = Properties.Resources.crop;
        }
        private void rotate90Button_MouseUp(object sender, MouseEventArgs e)
        {
            rotate90Button.Image = Properties.Resources.rotate90;
        }

        //CANVAS PICTURE
        int dx, dy, mx, my;
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            DB.Image = pic.Image;
            DB1.Image = rm;
            md = true;
            dx = e.X;
            dy = e.Y;
            py = e.Location;
            if (imgDrop)
            {
                g.DrawImage(Bitmap.FromFile(filePath), dx, dy);
                pic.Refresh();
                if (shiftHold) { return; }
                imgDrop = false;
                msg.Text = "";
                previewBox.Image = null;
            }
            if (select)
            {
                if (rm == null) { rm = bm;  }
                SelectedImage = new Bitmap(rm);
                SelectedGraphics = Graphics.FromImage(SelectedImage);
                pic.Image = SelectedImage;
            }
            else
            {
                swatch(brush.Color);
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            mx = e.X;
            my = e.Y;
            DB.Image = pic.Image;
            DB1.Image = rm;
            posStatus.Text = "Position: " + e.X + "," + e.Y + "px";
            //this is for inserting image
            if (imgDrop)
            {
                selectionStatus.Text = "Inserting: " + Image.FromFile(filePath).Width + " x " + Image.FromFile(filePath).Height + "px";
            }
            //all below is for dragging select box OR brush tool
            if (!md) return;
            if (shiftHold) return;
            if (select)

            {
                selectionStatus.Text = "Selection: " + Math.Abs(dx - mx) + " x " + Math.Abs(dy - my) + "px";
                SelectedGraphics.DrawImage(rm, 0, 0);
                using (Pen select_pen = new Pen(Color.Red))
                {
                    select_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    Rectangle rect = MakeRectangle(dx, dy, mx, my);
                    SelectedGraphics.DrawRectangle(select_pen, rect);
                }

                pic.Refresh();
            }
            else if (selectBox == null || selectBox.Width < 2 && selectBox.Height < 2)
            {
                px = e.Location;
                if (brushShape.Text == "Line") 
                { 
                    g.DrawLine(brush, px, py); 
                }
                else if (brushShape.Text == "Circle")
                { 
                    g.DrawEllipse(brush, e.Location.X, e.Location.Y, brush.Width/2, brush.Width/2);
                    g.FillEllipse(brushFill, e.Location.X, e.Location.Y, brush.Width / 2, brush.Width / 2);
                }
                else if (brushShape.Text == "Diamond")
                {
                    g.DrawEllipse(brush, (e.Location.X), (e.Location.Y), 1, 1);
                    g.FillRectangle(brushFill, new Rectangle(e.Location.X - (int)(brush.Width / 3), e.Location.Y - (int)(brush.Width / 3), (int)(brush.Width / 1.5), (int)(brush.Width / 1.5)));
                }
                py = px;
            }
            pic.Refresh();

        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            DB1.Image = rm;
            if (!md) return;
            md = false;
            if (select)
            {
                SelectedImage = null;
                SelectedGraphics = null;
                pic.Image = rm;
                if (selectBox != null)
                {
                    if (selectBox.Width > 2 && selectBox.Height > 2)
                    {
                        g.DrawImage(dim, selectBox.Location.X, selectBox.Location.Y);
                    }
                    
                }
                createSelection(MakeRectangle(dx, dy, e.X, e.Y));
                if (selectBox.Width == 0) { selectionStatus.Text = "Selection: 0 x 0px"; }
                pic.Refresh();
                ImageScale = 1.0f;
            }
            else
            {

            }
        }
        //SELECTBOX MAGIC
        private Rectangle MakeRectangle(int x0, int y0, int x1, int y1)
        {
            return new Rectangle(
                Math.Min(x0, x1),
                Math.Min(y0, y1),
                Math.Abs(x0 - x1),
                Math.Abs(y0 - y1));
        }
        /*
        public void createSelection(Point heiwei, Point loc)
        {
            if (selectBox == null) { selectBox = new PictureBox(); }
            selectBox.Cursor = Cursors.Hand;
            selectBox.Size = new Size(heiwei);
            selectBox.BackColor = Color.Transparent;
            selectBox.Location = loc;
            pic.Controls.Add(selectBox);
            selectBox.Paint += this.selectBox_Paint;
        }
         */
        PictureBox selectBox;
        private Graphics DisplayGraphics;
        public void createSelection(Rectangle selRect)
        {
            if (selectBox == null) { selectBox = new PictureBox(); }
            selectBox.Cursor = Cursors.Hand;
            selectBox.Size = selRect.Size;
            selectBox.BackColor = Color.Transparent;
            selectBox.Location = selRect.Location;
            //image stuff
            Rectangle source_rect = new Rectangle(selectBox.Location.X, selectBox.Location.Y, selectBox.Width, selectBox.Height);
            Rectangle dest_rect = new Rectangle(0, 0, selectBox.Width, selectBox.Height);
            if (selectBox.Width > 2 && selectBox.Height > 2)
            {
                dim = new Bitmap(selectBox.Width, selectBox.Height);
                DisplayGraphics = Graphics.FromImage(dim);
                DisplayGraphics.DrawImage(rm, dest_rect, source_rect, GraphicsUnit.Pixel);
                DisplayGraphics = Graphics.FromImage(dim);
                selectBox.Image = dim;
                DB2.Image = dim;

                ImageWidth = selectBox.Image.Width;
                ImageHeight = selectBox.Image.Height;
                selectBox.SizeMode = PictureBoxSizeMode.Zoom;
                selectBox.Size = new Size(ImageWidth, ImageHeight);
                this.MouseWheel += new MouseEventHandler(picImage_MouseWheel);
            };

            
            //create
            pic.Controls.Add(selectBox);

            

            //events
            selectBox.Paint += this.selectBox_Paint;
            selectBox.MouseDown += this.selectBox_MouseDown;
            selectBox.MouseMove += this.selectBox_MouseMove;
            selectBox.MouseUp += this.selectBox_MouseUp;
        }
        private void selectBox_Paint(object sender, PaintEventArgs e)
        {
            Pen pesel = new Pen(Color.Blue, 2);
            pesel.DashPattern = new float[] { 5, 5 };
            e.Graphics.DrawRectangle(pesel, 0, 0, selectBox.Width, selectBox.Height);
            
            
        }

        int sx, sy, ex, ey;
        bool selectDrag = false;
        protected void selectBox_MouseDown(object sender, MouseEventArgs e)
        {
            selectDrag = true;
            sx = e.Location.X;
            sy = e.Location.Y;
        }
        protected void selectBox_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (!selectDrag) return;
            if (select)
            {
                ex = e.X - sx;
                ey = e.Y - sy;
                //selectBox.Location = new Point(selectBox.Location.X + ex, selectBox.Location.Y + ey);
                msg.Text = selectBox.Location.X + " " + sx + " " + ex;
            }

            //draw
            else if (!select)
            {
                px = e.Location;
                Graphics gr = Graphics.FromImage(dim);
                if (brushShape.Text == "Line") 
                { 
                    gr.DrawLine(brush, px, py); 
                }
                else if (brushShape.Text == "Circle")
                { 
                    gr.DrawEllipse(brush, e.Location.X, e.Location.Y, brush.Width/2, brush.Width/2);
                    gr.FillEllipse(brushFill, e.Location.X, e.Location.Y, brush.Width / 2, brush.Width / 2);
                }
                else if (brushShape.Text == "Diamond")
                {
                    gr.DrawEllipse(brush, (e.Location.X), (e.Location.Y), 1, 1);
                    gr.FillRectangle(brushFill, new Rectangle(e.Location.X - (int)(brush.Width / 3), e.Location.Y - (int)(brush.Width / 3), (int)(brush.Width / 1.5), (int)(brush.Width / 1.5)));
                }
                py = px;
                selectBox.Refresh();
                
            }

        }
        protected void selectBox_MouseUp(object sender, MouseEventArgs e)
        {
            selectDrag = false;
            selectBox.Location = new Point(selectBox.Location.X + ex, selectBox.Location.Y + ey);
            ex = 0;
            ey = 0;
            sx = 0;
            sy = 0;
            
        }
        //SCROLLS
        private int ImageWidth, ImageHeight;
        private float ImageScale = 1.0f;
        private void picImage_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!select) { return; }
            // The amount by which we adjust scale per wheel click.
            const float scale_per_delta = 0.1f / 120;

            // Update the drawing based upon the mouse wheel scrolling.
            ImageScale += e.Delta * scale_per_delta;
            if (ImageScale < 0) ImageScale = 0;

            // Size the image.
            selectBox.Size = new Size(
                (int)(ImageWidth * ImageScale),
                (int)(ImageHeight * ImageScale));
            if (selectBox.Width > 1)
            {
                dim = new Bitmap(dim, selectBox.Size);
            }
        }


        //COLORS
        private void redTrack_Scroll(object sender, EventArgs e)
        {
            re = redTrack.Value;
            Color col = Color.FromArgb(alpha, re, gr, bl);
            brush.Color = col;
            brushFill.Color = col;
            redTxt.Text = re + "";
            //settings.Write("Red", re + "", "Color");
        }
        private void greenTrack_Scroll(object sender, EventArgs e)
        {
            gr = greenTrack.Value;
            Color col = Color.FromArgb(alpha, re, gr, bl);
            brush.Color = col;
            brushFill.Color = col;
            greenTxt.Text = gr + "";
            //settings.Write("Green", gr + "", "Color");
        }
        private void blueTrack_Scroll(object sender, EventArgs e)
        {
            bl = blueTrack.Value;
            Color col = Color.FromArgb(alpha, re, gr, bl);
            brush.Color = col;
            brushFill.Color = col;
            blueTxt.Text = bl + "";
            //settings.Write("Blue", bl + "", "Color");
        }
        private void redTxt_Leave(object sender, EventArgs e)
        {
            if (redTxt.Text == "") { return; }
            if (Int16.Parse(redTxt.Text) > 255)
            {
                redTxt.Text = 255 + "";
            }
            re = Int16.Parse(redTxt.Text);
            redTrack.Value = re;
            Color col = Color.FromArgb(alpha, re, gr, bl);
            brush.Color = col;
            brushFill.Color = col;
            //settings.Write("Red", re + "", "Color");
        }
        private void redTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void greenTxt_Leave(object sender, EventArgs e)
        {
            if (greenTxt.Text == "") { return; }
            if (Int16.Parse(greenTxt.Text) > 255)
            {
                greenTxt.Text = 255 + "";
            }
            gr = Int16.Parse(greenTxt.Text);
            greenTrack.Value = gr;
            Color col = Color.FromArgb(alpha, re, gr, bl);
            brush.Color = col;
            brushFill.Color = col;
            //settings.Write("Green", gr + "", "Color");
        }
        private void greenTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void blueTxt_Leave(object sender, EventArgs e)
        {
            if (blueTxt.Text == "") { return; }
            if (Int16.Parse(blueTxt.Text) > 255)
            {
                blueTxt.Text = 255 + "";
            }
            bl = Int16.Parse(blueTxt.Text);
            blueTrack.Value = bl;
            Color col = Color.FromArgb(alpha, re, gr, bl);
            brush.Color = col;
            brushFill.Color = col;
            //settings.Write("Blue", bl + "", "Color");
        }
        private void blueTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // SWATCH COLORS
        public void swatch(Color inColor)
        {
            if (inColor != swatch0.BackColor)
            {
                if (swatch3.BackColor != DefaultBackColor)
                {
                    swatch4.BackColor = swatch3.BackColor;
                }
                if (swatch2.BackColor != DefaultBackColor)
                {
                    swatch3.BackColor = swatch2.BackColor;
                }
                if (swatch1.BackColor != DefaultBackColor)
                {
                    swatch2.BackColor = swatch1.BackColor;
                }
                if (swatch0.BackColor != DefaultBackColor)
                {
                    swatch1.BackColor = swatch0.BackColor;
                }
                swatch0.BackColor = inColor;
            }
            
        }
        private void swatch0_Click(object sender, EventArgs e)
        {
            var a = swatch0.BackColor;
            brush.Color = a;
            redTrack.Value = a.R;
            greenTrack.Value = a.G;
            blueTrack.Value = a.B;
            redTxt.Text = a.R + "";
            greenTxt.Text = a.G + "";
            blueTxt.Text = a.B + "";
        }
        private void swatch1_Click(object sender, EventArgs e)
        {
            var a = swatch1.BackColor;
            brush.Color = a;
            redTrack.Value = a.R;
            greenTrack.Value = a.G;
            blueTrack.Value = a.B;
            redTxt.Text = a.R + "";
            greenTxt.Text = a.G + "";
            blueTxt.Text = a.B + "";
        }
        private void swatch2_Click(object sender, EventArgs e)
        {
            var a = swatch2.BackColor;
            brush.Color = a;
            redTrack.Value = a.R;
            greenTrack.Value = a.G;
            blueTrack.Value = a.B;
            redTxt.Text = a.R + "";
            greenTxt.Text = a.G + "";
            blueTxt.Text = a.B + "";
        }
        private void swatch3_Click(object sender, EventArgs e)
        {
            var a = swatch3.BackColor;
            brush.Color = a;
            redTrack.Value = a.R;
            greenTrack.Value = a.G;
            blueTrack.Value = a.B;
            redTxt.Text = a.R + "";
            greenTxt.Text = a.G + "";
            blueTxt.Text = a.B + "";
        }
        private void swatch4_Click(object sender, EventArgs e)
        {
            var a = swatch4.BackColor;
            brush.Color = a;
            redTrack.Value = a.R;
            greenTrack.Value = a.G;
            blueTrack.Value = a.B;
            redTxt.Text = a.R + "";
            greenTxt.Text = a.G + "";
            blueTxt.Text = a.B + "";
        }

        

        

        
        

        
    }
}
