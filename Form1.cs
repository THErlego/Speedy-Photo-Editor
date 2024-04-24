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
            InitializeComponent(); //create UI
            configLoad(); //config load
            bm = new Bitmap(pic.Width, pic.Height); //blank image
            g = Graphics.FromImage(bm); //allows draw/select tool to work
            pic.Image = bm; //sets canvas to blank image
            canvasStatus.Text = "Canvas size: " + pic.Width + " x " + pic.Height + "px";
            layerContainer.RowCount = 1; //add row code only works if init components starts at 2?????

            
        }

        Bitmap bm; //initial image
        Bitmap rm; //saved image
        Bitmap dim;//temp crop image
        Graphics g;
        Graphics SelectedGraphics = null; //for selection
        Bitmap SelectedImage = null; //for selection
        private Form1 _instance = null; //for new button
        int select = 1; //default selected tool 0=draw, 1=select, 2=eyedropper
        bool md = false; //mouse down
        bool shiftHold = false; //shift down
        bool layerMode = true; //layer checkbox switch
        //Pen Tool
        int re,gr,bl = 0; //color slider vars
        int alpha = 255; //transparency value (always 100%)
        Point px, py; //mouse location when clicking down
        Pen brush = new Pen(Color.FromArgb(255, 0, 0, 0), 1); //brush outer section, color | width
        SolidBrush brushFill = new SolidBrush(Color.FromArgb(255, 0, 0, 0)); //brush inner fill, color

        SpeedyPhotoEditor.IniFile settings = new IniFile("Settings.ini"); //init settings

        public void configCreate() //create settings file if unavailable
        {
            settings.Write("Canvas_Width", "400", "Canvas");
            settings.Write("Canvas_Height", "400", "Canvas");
            settings.Write("Brush_Width", "1", "Brush");
            settings.Write("Brush_Type", "Line", "Brush");
            settings.Write("Red", "0", "Color");
            settings.Write("Green", "0", "Color");
            settings.Write("Blue", "0", "Color");
            settings.Write("Keep_Ratio", "False", "Resize");
            settings.Write("Keep_Resize", "True", "Resize");
            settings.Write("Layers", "True", "Layers");

            settings.Write("s4", "[Control]", "Color");
            settings.Write("s3", "[Control]", "Color");
            settings.Write("s2", "[Control]", "Color");
            settings.Write("s1", "[Control]", "Color");
            settings.Write("s0", "[Control]", "Color");
        }
        public void configLoad() //load settings file
        {
            try
            {
                pic.Width = Int32.Parse(settings.Read("Canvas_Width", "Canvas"));
                pic.Height = Int32.Parse(settings.Read("Canvas_Height", "Canvas"));
                brush.Width = Int32.Parse(settings.Read("Brush_Width", "Brush"));
                brushTrack.Value = Int32.Parse(settings.Read("Brush_Width", "Brush"));
                brushTxt.Text = settings.Read("Brush_Width", "Brush");
                brushShape.Text = settings.Read("Brush_Type", "Brush");
                redTrack.Value = Int32.Parse(settings.Read("Red", "Color"));
                redTxt.Text = settings.Read("Red", "Color");
                greenTrack.Value = Int32.Parse(settings.Read("Green", "Color"));
                greenTxt.Text = settings.Read("Green", "Color");
                blueTrack.Value = Int32.Parse(settings.Read("Blue", "Color"));
                blueTxt.Text = settings.Read("Blue", "Color");
                Color col = Color.FromArgb(alpha, redTrack.Value, greenTrack.Value, blueTrack.Value);
                brushFill.Color = col;
                brush.Color = col;
                string krtmp = settings.Read("Keep_Ratio", "Resize"); //will never be used
                string krztmp = settings.Read("Keep_Resize", "Resize"); //will never be used
                layerMode = bool.Parse(settings.Read("Layers", "Layers"));
                if (layerMode == true) { layerMode = false; layerCheck.Image = Properties.Resources.uncl; }
                else { layerMode = true; layerCheck.Image = Properties.Resources.cl; }
                swatch0.BackColor = swatchStringSplit("s0");
                swatch1.BackColor = swatchStringSplit("s1");
                swatch2.BackColor = swatchStringSplit("s2");
                swatch3.BackColor = swatchStringSplit("s3");
                swatch4.BackColor = swatchStringSplit("s4");
                
            }
            catch
            {
                configCreate();
            }
        }
        //KEYS
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //reads key inputs
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e) //single activation when held down
        {
            if (e.KeyChar == 27) // escape
            {
                if (!md) return;
                md = false;

                // Stop selecting
                SelectedImage = null;
                SelectedGraphics = null;
                pic.Image = rm;
                pic.Refresh();
            }
            if (e.KeyChar == 102) // shortcut to toggle between modes
            {
                switch (select)
                {
                    case 0: //paint to sel
                        changeMenuButton(1);
                        break;
                    case 1: //sel to eye
                        changeMenuButton(2);
                        break;
                    case 2: //eye to erase
                        changeMenuButton(3);
                        break;
                    case 3: //erase to paint
                        changeMenuButton(0);
                        break;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) //rapidfire activates as key is held
        {
            if (e.KeyValue == 16) //shift
            {
                shiftHold = true;
            }
            if (e.KeyData == (Keys.Add)) //make brush bigger
            {
                brushTrack.Value++;
                brushTxt.Text = "" + brushTrack.Value;
                brush.Width = brushTrack.Value;
                settings.Write("Brush_Width", brush.Width + "", "Brush");
            }
            if (e.KeyData == (Keys.Subtract)) //make brush smaller
            {
                brushTrack.Value--;
                brushTxt.Text = "" + brushTrack.Value;
                brush.Width = brushTrack.Value;
                settings.Write("Brush_Width", brush.Width + "", "Brush");
            }
            if (e.KeyData == Keys.Space && select == 0) //allows painting with spacebar
            {
                md = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e) //activates after last keydown
        {
            if (e.KeyValue == 16) //shift
            {
                shiftHold = false;
            }
            if (e.KeyData == (Keys.N | Keys.Control)) //CTRL N / new
            {
                _instance = new Form1();
                _instance.Show();
            }
            if (e.KeyData == (Keys.S | Keys.Control)) //CTRL S / save
            {
                saveFile();
            }
            if (e.KeyData == (Keys.C | Keys.Control)) //CTRL C / copy
            {
                Clipboard.SetImage(dim);
                e.Handled = true;
            }
            if (e.KeyData == (Keys.V | Keys.Control)) //CTRL V / paste
            {
                try
                {
                    if (!imgFirst)
                    {
                        pic.Size = Clipboard.GetImage().Size; //resize canvas
                        rm = new Bitmap(bm, new Size(Clipboard.GetImage().Width, Clipboard.GetImage().Height)); //new base image
                        pic.Image = rm;
                        g = Graphics.FromImage(rm);
                        imgFirst = true;
                        g.DrawImage(Clipboard.GetImage(), 0, 0);
                        canvasStatus.Text = "Canvas size: " + pic.Width + " x " + pic.Height + "px";
                    }
                    else
                    {
                        g.DrawImage(Clipboard.GetImage(), mx, my);
                    }
                    pic.Refresh();
                }
                catch
                {
                    msg.Text = "Not a valid image";
                }
                e.Handled = true;
            }
            if (e.KeyData == (Keys.A | Keys.Control)) //CTRL A / select all
            {
                SelectedImage = null;
                SelectedGraphics = null;

                dim = new Bitmap(rm, pic.Size);

                createSelection(MakeRectangle(0, 0, pic.Width, pic.Height), rm);
                if (selectBox.Width == 0) { selectionStatus.Text = "Selection: 0 x 0px"; }
                pic.Refresh();
                ImageScale = 1.0f;
                e.Handled = true;
            }
            if (e.KeyData == Keys.Space) //allows painting with spacebar
            {
                md = false;
            }

        }
        //selection changer
        private void changeMenuButton(int num)
        {
            switch (num)
            {
                case 0:
                    brushButton.Image = Properties.Resources.brushsel;
                    selectButton.Image = Properties.Resources.select;
                    pickerButton.Image = Properties.Resources.picker;
                    eraseButton.Image = Properties.Resources.erase;
                    select = 0;
                    break;
                case 1:
                    brushButton.Image = Properties.Resources.brush;
                    selectButton.Image = Properties.Resources.selectsel;
                    pickerButton.Image = Properties.Resources.picker;
                    eraseButton.Image = Properties.Resources.erase;
                    select = 1;
                    break;
                case 2:
                    brushButton.Image = Properties.Resources.brush;
                    selectButton.Image = Properties.Resources.select;
                    pickerButton.Image = Properties.Resources.pickersel;
                    eraseButton.Image = Properties.Resources.erase;
                    select = 2;
                    break;
                case 3:
                    brushButton.Image = Properties.Resources.brush;
                    selectButton.Image = Properties.Resources.select;
                    pickerButton.Image = Properties.Resources.picker;
                    eraseButton.Image = Properties.Resources.erasesel;
                    select = 3;
                    break;
            }
        }
        //BRUSH
        private void brushButton_Click(object sender, EventArgs e)
        {
            changeMenuButton(0);
        }
        //SELECT
        private void selectButton_Click(object sender, EventArgs e)
        {
            changeMenuButton(1);
        }
        //PICKER
        private void pickerButton_Click(object sender, EventArgs e)
        {
            changeMenuButton(2);
        }
        //ERASE
        private void eraseButton_Click(object sender, EventArgs e)
        {
            changeMenuButton(3);
        }


        //NEW WINDOW
        private void newButton_MouseDown(object sender, MouseEventArgs e)
        {
            newButton.Image = Properties.Resources.filesel;
            //if window closed, stopped working
            /*if (_instance == null)
            {
                _instance = new Form1();
                _instance.Show();
            }
            else
            {
                _instance.Activate();
            }*/
            _instance = new Form1();
            _instance.Show();
        }



        //OPEN
        bool imgFirst = false; //first inserted image flag
        String filePath, fileName; //EX: C:\users\admin\pictures\bob.png, bob.png
        bool imgDrop = false; //inserting image flag, disables other actions
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
                    fileName = ofd.SafeFileName;
                    var fileStream = ofd.OpenFile();
                }
                openButton.Image = Properties.Resources.upload;
                //insert
                if (!imgFirst) //first inserted image
                {
                    try
                    {
                        pic.Size = Image.FromFile(filePath).Size; //resize canvas
                        rm = new Bitmap(bm, new Size(Image.FromFile(filePath).Width, Image.FromFile(filePath).Height)); //new base image
                        pic.Image = rm; 
                        g = Graphics.FromImage(rm);
                        imgFirst = true;
                        g.DrawImage(Bitmap.FromFile(filePath), 0, 0);
                        canvasStatus.Text = "Canvas size: " + pic.Width + " x " + pic.Height + "px";
                    }
                    catch
                    {
                        msg.Text = "Image Cancelled"; 
                    }
                }
                else //2+ image inserts
                {
                    imgDrop = true;
                    msg.Text = "Select a location to drop image, SHIFT to paste multiple";
                    try
                    {
                        previewBox.Image = Image.FromFile(filePath);
                    }
                    catch
                    {
                        msg.Text = "Image Cancelled";
                    }
                    canvasStatus.Text = "Canvas size: " + pic.Width + " x " + pic.Height + "px";
                }
                settings.Write("Canvas_Width", pic.Width + "", "Canvas");
                settings.Write("Canvas_Height", pic.Height + "", "Canvas");
                pic.Refresh();
            }
        }



        //SAVE
        String saveloc = "";
        public void saveFile() //opens save dialog
        {
            //merge layers
            Image merged = pic.Image;
            for (int i = 1; i < rc+1; i++)
            {
                sbox = (PictureBox)this.Controls.Find("pc" + i, true)[0];
                g.DrawImage(sbox.Image, sbox.Location);
            }
            
            //save
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG(*.PNG)|*.png";

            if (save.ShowDialog() == DialogResult.OK)
            {
                pic.Image.Save(save.FileName); //saves image
                saveloc = save.FileName;
                Text = saveloc;
                saveButton.Image = Properties.Resources.save;
            }
            pic.Image = merged; //return to normal
        }
        private void saveButton_MouseDown(object sender, MouseEventArgs e) //opens save dialog if not yet saved, then just saves file in background
        {
            saveButton.Image = Properties.Resources.savesel;
            if (saveloc == "")
            {
                saveFile();
            }
            else
            {
                //merge layers
                Image merged = pic.Image;
                for (int i = 1; i < rc + 1; i++)
                {
                    sbox = (PictureBox)this.Controls.Find("pc" + i, true)[0];
                    g.DrawImage(sbox.Image, sbox.Location);
                }
                pic.Image.Save(saveloc); //saves image
                pic.Image = merged; //return to normal
            }
        }
        


        //SAVEAS
        private void saveAsButton_MouseDown(object sender, MouseEventArgs e) //always opens save dialog
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
                SelectedImage = null;
                SelectedGraphics = null;
                createSelection(MakeRectangle(0, 0, 0, 0), rm);
                canvasStatus.Text = "Canvas size: " + pic.Width + " x " + pic.Height + "px";
                g = Graphics.FromImage(rm);
                pic.Refresh();
            }
        }



        //ROTATE 90 DEGREES
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
                dim = ModifiedBitmap(dim, RotateFlipType.Rotate90FlipNone); //makes dim the rotated image
                selectBox.Refresh();
            }
        }



        //BRUSH WIDTH
        private void brushTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //removes non numerics from textboxes
            }
        }
        private void brushTxt_TextChanged(object sender, EventArgs e)
        {
            if (brushTxt.Text != "") //blank text is ignored
            {
                if (Int16.Parse(brushTxt.Text) <= 100) //100 is max limit of slider
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



        //LAYER CHECKBOX
        private void layerCheck_Click(object sender, EventArgs e)
        {
            settings.Write("Layers", layerMode + "", "Layers");
            if (layerMode == true)
            {
                layerMode = false;
                layerCheck.Image = Properties.Resources.uncl;
            }
            else
            {
                layerMode = true;
                layerCheck.Image = Properties.Resources.cl;
            }
        }



        //MAKE ICONS NOT BLUE AFTER CLICKING
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
        int dx, dy, mx, my; //d is location as mouse down, m is location as mouse moves
        Color eraseCol; //color eraser picks when erasing
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            picv.Image = pic.Image; //debug feature
            rmv.Image = rm; //debug feature
            md = true;
            dx = e.X;
            dy = e.Y;
            py = e.Location;
            if (imgDrop) //inserting image
            {
                if (layerMode) //for when layer toggle is on
                {
                    AddItem(Bitmap.FromFile(filePath), fileName);
                    
                }
                else //no layer toggle
                {
                    g.DrawImage(Bitmap.FromFile(filePath), dx, dy);
                }
                
                pic.Refresh();
                if (shiftHold) { return; } //if you are holding shift, it repeats the above section
                imgDrop = false;
                msg.Text = "";
                previewBox.Image = null;
            }
            if (select == 0) //draw
            {
                swatch(brush.Color);
                if (shiftHold)
                {
                    g.DrawLine(brush, px, py);
                    px = e.Location;
                    
                }
                else if (selectBox == null || selectBox.Width < 2 && selectBox.Height < 2)
                {
                    px = e.Location;
                    lilBrushes(g);
                }
                pic.Refresh();
            }
            else if (select == 1) //select
            {
                if (selLayer) { return; } // select is disabled when using a layer
                if (rm == null) { rm = bm;  }
                if (selectBox != null && selectBox.Width > 2)
                {
                    dim = new Bitmap(dim, selectBox.Size);
                }
                SelectedImage = new Bitmap(rm);
                SelectedGraphics = Graphics.FromImage(SelectedImage);
                pic.Image = SelectedImage;
            }
            else if (select == 2) //color pick
            {
                if (rm == null)
                {
                    re = 255;
                    gr = 255;
                    bl = 255;
                }
                else
                {
                    re = rm.GetPixel(dx, dy).R;
                    gr = rm.GetPixel(dx, dy).G;
                    bl = rm.GetPixel(dx, dy).B;
                }
                redTrack.Value = re;
                greenTrack.Value = gr;
                blueTrack.Value = bl;
                redTxt.Text = re + "";
                greenTxt.Text = gr + "";
                blueTxt.Text = bl + "";
                Color col = Color.FromArgb(alpha, re, gr, bl);
                brush.Color = col;
                brushFill.Color = col;
                select = 0;
                brushButton.Image = Properties.Resources.brushsel;
                selectButton.Image = Properties.Resources.select;
                pickerButton.Image = Properties.Resources.picker;
            }
            else if (select == 3) //erase
            {
                px = e.Location;
                if (rm == null)
                {
                    eraseCol = Color.White;
                }
                else
                {
                    eraseCol = rm.GetPixel(dx,dy);
                }
                g.FillRectangle(new SolidBrush(eraseCol), new Rectangle(mx, my, (int)brush.Width, (int)brush.Width));
                pic.Refresh();
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            mx = e.X;
            my = e.Y;
            picv.Image = pic.Image; //debug feature
            rmv.Image = rm; //debug feature
            posStatus.Text = "Position: " + e.X + "," + e.Y + "px";
            //this is for inserting image
            if (imgDrop)
            {
                try
                {
                    selectionStatus.Text = "Inserting: " + Image.FromFile(filePath).Width + " x " + Image.FromFile(filePath).Height + "px";
                }
                catch
                {
                    msg.Text = "Image Cancelled";
                }

            }
            //all below is for dragging select box OR brush tool
            if (!md) return;
            if (shiftHold) return;
            if (select == 1) //select
            {
                if (selLayer) { return; } // select is disabled when using a layer
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
            else if (select == 0 && (selectBox == null || selectBox.Width < 2 && selectBox.Height < 2)) //draw
            {
                px = e.Location;
                lilBrushes(g);
            }
            else if (select == 3) //erase
            {
                px = e.Location;
                g.FillRectangle(new SolidBrush(eraseCol), new Rectangle(mx, my, (int)brush.Width, (int)brush.Width));
            }
            pic.Refresh();
        }
        private void lilBrushes(Graphics g)
        {
            
            if (brushShape.Text == "Line")
            {
                g.DrawLine(brush, px, py);
            }
            else if (brushShape.Text == "Circle")
            {
                g.DrawEllipse(brush, mx, my, brush.Width / 2, brush.Width / 2);
                g.FillEllipse(brushFill, mx, my, brush.Width / 2, brush.Width / 2);
            }
            else if (brushShape.Text == "Diamond")
            {
                g.DrawEllipse(brush, (mx), (my), 1, 1);
                g.FillRectangle(brushFill, new Rectangle(mx - (int)(brush.Width / 3), my - (int)(brush.Width / 3), (int)(brush.Width / 1.5), (int)(brush.Width / 1.5)));
            }
            else if (brushShape.Text == "Spraypaint")
            {
                var ran = new Random();
                var bw = (int)brush.Width;
                for( int i = 0; i < brush.Width/4; i++)
                {
                    g.FillEllipse(brushFill, (mx + ran.Next(bw)), (my + ran.Next(bw)),2,2);
                    g.FillEllipse(brushFill, (mx - ran.Next(bw)), (my + ran.Next(bw)),2,2);
                    g.FillEllipse(brushFill, (mx + ran.Next(bw)), (my - ran.Next(bw)),2,2);
                    g.FillEllipse(brushFill, (mx - ran.Next(bw)), (my - ran.Next(bw)),2,2);
                }
            }
            py = px;
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            rmv.Image = rm; //debug feature
            if (!md) return;
            md = false;
            if (select == 1)
            {
                if (selLayer) { return; }
                SelectedImage = null;
                SelectedGraphics = null;
                pic.Image = rm;
                if (selectBox != null) //image preview in sbox
                {
                    if (selectBox.Width > 2 && selectBox.Height > 2)
                    {
                        g.DrawImage(dim, selectBox.Location.X, selectBox.Location.Y);
                    }
                    
                }
                createSelection(MakeRectangle(dx, dy, e.X, e.Y), rm);
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

        PictureBox selectBox;
        private Graphics DisplayGraphics;
        public void createSelection(Rectangle selRect, Bitmap img)
        {
            if (selectBox == null) { selectBox = new PictureBox(); }
            selectBox.Cursor = Cursors.Hand;
            selectBox.Size = selRect.Size;
            selectBox.BackColor = Color.Transparent;
            selectBox.Location = selRect.Location;
            selectBox.BringToFront();
            //image stuff
            Rectangle source_rect = new Rectangle(selectBox.Location.X, selectBox.Location.Y, selectBox.Width, selectBox.Height);
            Rectangle dest_rect = new Rectangle(0, 0, selectBox.Width, selectBox.Height);
            
            if (selectBox.Width > 2 && selectBox.Height > 2)
            {
                dim = new Bitmap(selectBox.Width, selectBox.Height);
                DisplayGraphics = Graphics.FromImage(dim);
                DisplayGraphics.DrawImage(img, dest_rect, source_rect, GraphicsUnit.Pixel);
                DisplayGraphics = Graphics.FromImage(dim);
                selectBox.Image = dim;
                sboxv.Image = dim; //debug feature

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
            dx = e.X;
            dy = e.Y;
            if (select == 0)
            {
                swatch(brush.Color);
            }
        }
        protected void selectBox_MouseMove(object sender, MouseEventArgs e)
        {
            mx = e.X;
            my = e.Y;
            
            if (!selectDrag) return;
            if (select == 1)
            {
                ex = e.X - sx;
                ey = e.Y - sy;
                //msg.Text = selectBox.Location.X + " " + sx + " " + ex;
            }

            //draw
            else if (select == 0)
            {
                px = e.Location;
                Graphics g = Graphics.FromImage(dim);
                lilBrushes(g);
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
            if (select == 0) { return; }
            // The amount by which we adjust scale per wheel click.
            const float scale_per_delta = 0.1f / 120;

            // Update the drawing based upon the mouse wheel scrolling.
            ImageScale += e.Delta * scale_per_delta;
            if (ImageScale < 0) ImageScale = 0;

            // Size the image.
            selectBox.Size = new Size(
                (int)(ImageWidth * ImageScale),
                (int)(ImageHeight * ImageScale));
            
        }



        //FILL BUCKET

        //COLORS
        private void colorMod()
        {
            Color col = Color.FromArgb(alpha, re, gr, bl); //creates var COLOR
            brush.Color = col; //sets brush to color
            brushFill.Color = col;
        }
        private void redTrack_Scroll(object sender, EventArgs e)
        {
            re = redTrack.Value;
            colorMod();
            redTxt.Text = re + "";
            settings.Write("Red", re + "", "Color");
        }
        private void greenTrack_Scroll(object sender, EventArgs e)
        {
            gr = greenTrack.Value;
            colorMod();
            greenTxt.Text = gr + "";
            settings.Write("Green", gr + "", "Color");
        }
        private void blueTrack_Scroll(object sender, EventArgs e)
        {
            bl = blueTrack.Value;
            colorMod();
            blueTxt.Text = bl + "";
            settings.Write("Blue", bl + "", "Color");
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
            colorMod();
            settings.Write("Red", re + "", "Color");
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
            colorMod();
            settings.Write("Green", gr + "", "Color");
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
            colorMod();
            settings.Write("Blue", bl + "", "Color");
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

                settings.Write("s0", swatch0.BackColor.ToString(), "Color");
                settings.Write("s1", swatch1.BackColor.ToString(), "Color");
                settings.Write("s2", swatch2.BackColor.ToString(), "Color");
                settings.Write("s3", swatch3.BackColor.ToString(), "Color");
                settings.Write("s4", swatch4.BackColor.ToString(), "Color");
            }
            
        }
        private Color swatchStringSplit(String n)
        {
            String hr = settings.Read(n, "Color");
            String[] clrs = hr.Split('=', ',', ']');
            Color c = Color.FromArgb(int.Parse(clrs[1]), int.Parse(clrs[3]), int.Parse(clrs[5]), int.Parse(clrs[7]));
            return c;
        }
        private void swatch_Click(Color a)
        {
            brush.Color = a;
            brushFill.Color = a;
            redTrack.Value = a.R;
            greenTrack.Value = a.G;
            blueTrack.Value = a.B;
            redTxt.Text = a.R + "";
            greenTxt.Text = a.G + "";
            blueTxt.Text = a.B + "";
        }
        private void swatch0_Click(object sender, EventArgs e)
        {
            Color a = swatch0.BackColor;
            swatch_Click(a);
        }
        private void swatch1_Click(object sender, EventArgs e)
        {
            Color a = swatch1.BackColor;
            swatch_Click(a);
        }
        private void swatch2_Click(object sender, EventArgs e)
        {
            Color a = swatch2.BackColor;
            swatch_Click(a);
        }
        private void swatch3_Click(object sender, EventArgs e)
        {
            Color a = swatch3.BackColor;
            swatch_Click(a);
        }
        private void swatch4_Click(object sender, EventArgs e)
        {
            Color a = swatch4.BackColor;
            swatch_Click(a);
        }


        //CHANGE BG PREVIEW
        private void backgroundButton_Click(object sender, EventArgs e)
        {
            backgroundButton.BackColor = brush.Color;
            pic.BackColor = brush.Color;
            pic.BackgroundImage = null;
        }



        //RED BUTTON
        private void debugButton_Click(object sender, EventArgs e)
        {
            AddItem(Properties.Resources.uploadsel, "lol");

        }



        //LAYERS UI
        int rc; //actual rowcount
        int space, vistog; //row / col that is to be selected
        PictureBox sbox; //selected picture
        CheckBox lbx; //selected visibility checkbox
        bool selLayer;
        Point tempPoint;
        private void AddItem(Image img, String path)
        {
            //get a reference to the previous existent 
            RowStyle temp = new RowStyle(SizeType.Absolute, 40);
            rc = layerContainer.RowCount;
            //increase layerContainer rows count by one
            layerContainer.RowCount++;
            //add a new RowStyle
            layerContainer.RowStyles.Add(temp);
            //add three controls
            layerContainer.Controls.Add(new CheckBox() { Name = "cb" + rc, Checked = true, BackColor = Color.Transparent }, 0, rc);
            layerContainer.Controls.Add(new PictureBox() { Name = "pb" + rc, Image = img, Size = new Size(36, 36), SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage, Enabled = false }, 1, rc);
            layerContainer.Controls.Add(new Label() { Name = "lb" + rc, Text = path, Enabled = false, BackColor = Color.Transparent }, 2, rc);
            //add picture
            pic.Controls.Add(new PictureBox()
            {
                Name = "pc" + rc,
                Image = img,
                Size = img.Size,
                Location = new Point(dx, dy),
                Enabled = false,
                BackColor = Color.Transparent
            });
        }
        private void layerContainer_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.Highlight), new Rectangle(0, ((space*42)+2)-layerContainer.VerticalScroll.Value, 200, 40)); //has issues
        }
        
        
        //LAYERS UI LOGIC
        public Point GetIndex(TableLayoutPanel tlp, Point point)
        {
            // Method adapted from: stackoverflow.com/a/15449969
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return new Point(0,0);

            int w = 0, h = 0;
            int[] widths = tlp.GetColumnWidths(), heights = tlp.GetRowHeights();

            int i;
            for (i = 0; i < widths.Length && point.X > w; i++)
            {
                w += widths[i];
            }
            int col = i - 1;

            for (i = 0; i < heights.Length && point.Y + tlp.VerticalScroll.Value > h; i++)
            {
                h += heights[i];
            }
            int row = i - 1;

            return new Point(col, row);
        }
        private void layerContainer_MouseDown(object sender, MouseEventArgs e)
        {
            Point cell = GetIndex(layerContainer, layerContainer.PointToClient(Cursor.Position));
            
            space = cell.Y;
            vistog = cell.X;

            //if you click empty space
            if (space > rc || space == 0) {return;}
            selLayer = true;

            //deselection
            if (sbox != null)
            {

                if (tempPoint != new Point(0, 0)) //do this if last click was "deselect"
                {
                    createSelection(new Rectangle(tempPoint.X, tempPoint.Y, 0, 0), rm);
                    tempPoint = new Point(0, 0);
                    selectBox.Image = dim;
                }
                else //only if clicking between
                {
                    sbox.Image = selectBox.Image;       //updates img
                }
                
                sbox.Location = selectBox.Location; //place previous real picture in proper location (if going from layer->layer)
                sbox.Visible = true;                //makes real layer visible
                
            }

            //change selection
            sbox = (PictureBox)this.Controls.Find("pc" + space, true)[0]; //canvas picturebox
            lbx = (CheckBox)this.Controls.Find("cb" + space, true)[0]; //layerlist checkbox
            sboxv.Image = sbox.Image; //debug feature

            //if leftmost box is touched
            if (vistog == 0)
            {
                if (lbx.Checked)
                {
                    lbx.Checked = false;
                }
                else
                {
                    lbx.Checked = true;
                }
            }
            //fill sbox with a selection
            createSelection(new Rectangle(new Point(0,0), sbox.Size), new Bitmap(sbox.Image, sbox.Size));
            selectBox.Location = sbox.Location; //moves the selection box to where the static layer is
            sbox.Location = new Point(-20000, -20000); //hides real static layer
            sbox.Visible = false;
            
            sbox.Refresh();
            //paint selected in view
            this.layerContainer.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.layerContainer_CellPaint);
            layerContainer.Refresh();
            
        }



        //DESELECT LAYER
        private void deselectLayer_Click(object sender, EventArgs e)
        {
            sbox.Location = selectBox.Location;
            //does the same as "deselection" area in switch layers code
            tempPoint = sbox.Location;
            sbox.Visible = true;
            sbox.Image = selectBox.Image;
            PictureBox miniBox = (PictureBox)this.Controls.Find("pb" + space, true)[0];
            miniBox.Image = sbox.Image;
            //moves layer panel selection
            space = -40;
            layerContainer.Refresh();
            selLayer = false;
            createSelection(new Rectangle(sbox.Location.X, sbox.Location.Y, 0, 0), rm); //unselects region
        }



        //RESIZE CANVAS MENU
        private void resizeWithWhite(int we, int he)
        {
            Image taste;
            if (rm == null)
            {
                taste = bm;
                rm = new Bitmap(bm, we, he);
            }
            
            else
            {
                taste = rm;
                rm = new Bitmap(rm, we, he);
            }
            g = Graphics.FromImage(rm);
            g.Clear(Color.Transparent);
            g.DrawImageUnscaled(taste, 0, 0, taste.Width, taste.Height);
            pic.Image = rm;
        }
        private void canvasStatus_DoubleClick(object sender, EventArgs e)
        {
            float aspectRatio = (float)pic.Width / (float)pic.Height;

            using (ResizeForm dialogForm = new ResizeForm(pic.Width, pic.Height, aspectRatio))
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    int we = dialogForm.getWidth();
                    int he = dialogForm.getHeight();
                    pic.Width = we;
                    pic.Height = he;
                    settings.Write("Canvas_Width", we + "", "Canvas");
                    settings.Write("Canvas_Height", he + "", "Canvas");
                    canvasStatus.Text = "Canvas size: " + we + " x " + he + "px";

                    if (dialogForm.getResizeStatus()) //if resize checkbox is checked
                    {
                        if (rm == null)
                        {
                            bm = new Bitmap(bm, we, he);
                            pic.Image = bm;
                            g = Graphics.FromImage(bm); //reminder to draw
                        }
                        else
                        {
                            rm = new Bitmap(rm, we, he);
                            pic.Image = rm;
                            g = Graphics.FromImage(rm); //reminder to draw
                        }
                        
                        pic.Refresh();
                    }
                    else
                    {
                        resizeWithWhite(we,he);
                    }
                    
                }
                dialogForm.Close();
            }
        }



        //RESIZE CANVAS DRAGS
        bool drY, drX;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Location.X) / 4 == (pic.Width + 4) / 4)
            {
                drX = true;
            }
            else if ((e.Location.Y) / 4 == (pic.Height + 4) / 4)
            {
                drY = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Location.X) / 4 == (pic.Width + 4) / 4)
            {
                this.Cursor = Cursors.SizeWE;
            }
            else if ((e.Location.Y) / 4 == (pic.Height + 4) / 4)
            {
                this.Cursor = Cursors.SizeNS;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drX)
            {
                pic.Width = e.X;
            }
            if (drY)
            {
                pic.Height = e.Y;
            }
            drX = false;
            drY = false;
            resizeWithWhite(pic.Width,pic.Height);
            canvasStatus.Text = "Canvas size: " + pic.Width + " x " + pic.Height + "px";
            
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default; //in case it wasnt already
        }

        


        

        
        
    }
}
