using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //the bitmap to work with
        Bitmap bm;
        private void Form1_Load(object sender, EventArgs e)
        {
            bm = new Bitmap(pictureBoxDrawArea.Width, pictureBoxDrawArea.Height);
        }
        //need a current button state im working with
        state currentstate;
        enum state
        {
            RectSelect,
            Brush,
            Pencil,
            WriteText,
            DrawLine,
            DrawCurve,
            DrawRect,
            DrawPoly,
            DrawElipse,
            Rotate,
            FlipHoriz,
            FlipVert,
            WritingText
        };
        //need to hide the view stuff and show the image stuff
        private void toolStripTextBox2_Click(object sender, EventArgs e)//image
        {
            buttonRectSelect.Hide();
            buttonBrush.Hide();
            buttonPencil.Hide();
            buttonWriteText.Hide();
            buttonDrawLine.Hide();
            buttonDrawCurve.Hide();
            buttonDrawRect.Hide();
            buttonDrawPolly.Hide();
            buttonDrawElipse.Hide();
            button1.Hide();

            buttonRotate.Show();
            buttonFlipHoriz.Show();
            buttonFlipVert.Show();
            textBox1.Hide();
        }
        //and the opposite here
        private void toolStripTextBox1_Click(object sender, EventArgs e)//view
        {
            buttonRectSelect.Show();
            buttonBrush.Show();
            buttonPencil.Show();
            buttonWriteText.Show();
            buttonDrawLine.Show();
            buttonDrawCurve.Show();
            buttonDrawRect.Show();
            buttonDrawPolly.Show();
            buttonDrawElipse.Show();

            buttonRotate.Hide();
            button1.Show();
            buttonFlipVert.Hide();
            buttonFlipHoriz.Hide();
            textBox1.Show();
        }
        //select the a rect button has been pressed
        private void buttonRectSelect_Click(object sender, EventArgs e)
        {
            currentstate = state.RectSelect;
            textBoxStatusBar.Text = currentstate.ToString();
        }
        //brush selected
        private void buttonBrush_Click(object sender, EventArgs e)
        {
            currentstate = state.Brush;
            textBoxStatusBar.Text = currentstate.ToString();
        }
        //pencil selected
        private void buttonPencil_Click(object sender, EventArgs e)
        {
            currentstate = state.Pencil;
            textBoxStatusBar.Text = currentstate.ToString();
        }
        //write text selected
        private void buttonWriteText_Click(object sender, EventArgs e)
        {
            currentstate = state.WriteText;
            textBoxStatusBar.Text = currentstate.ToString();
        }
        //draw line selected
        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            currentstate = state.DrawLine;
            textBoxStatusBar.Text = currentstate.ToString();
        }
        //draw curve selected
        private void buttonDrawCurve_Click(object sender, EventArgs e)
        {
            currentstate = state.DrawCurve;
            textBoxStatusBar.Text = currentstate.ToString();
        }
        //draw rect selected
        private void buttonDrawRect_Click(object sender, EventArgs e)
        {
            currentstate = state.DrawRect;
            textBoxStatusBar.Text = currentstate.ToString();
        }
        //draw pollygon selected
        private void buttonDrawPolly_Click(object sender, EventArgs e)
        {
            currentstate = state.DrawPoly;
            textBoxStatusBar.Text = currentstate.ToString();
        }
        //draw elipse selected
        private void buttonDrawElipse_Click(object sender, EventArgs e)
        {
            currentstate = state.DrawElipse;
            textBoxStatusBar.Text = currentstate.ToString();
        }
        
        private void pictureBoxDrawArea_Click(object sender, EventArgs e)
        {
            
        }
        //mouse has been released
        private void pictureBoxDrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            //capture the second x and y coord
            x2 = e.X;
            y2 = e.Y;
            //create a pen to use
            System.Drawing.Pen myPen;
            //set the color to the chosen color
            myPen = new System.Drawing.Pen(button1.BackColor);
            //create a graphics thingy from the bm
            System.Drawing.Graphics test = Graphics.FromImage(bm);

            //bunch of if elses that should be a case of something , basically what state am i in, do something different
            if(currentstate == state.DrawLine)
                test.DrawLine(myPen, x1, y1, x2, y2);
            else if (currentstate == state.DrawRect)
                test.DrawRectangle(myPen, new Rectangle(x1, y1, x2, y2));
            else if (currentstate == state.DrawElipse)
                test.DrawEllipse(myPen, new Rectangle(x1, y1, x2, y2));
            else if (currentstate == state.DrawCurve)
            {
                test.DrawBezier(myPen, new Point(x1, y1), new Point(x1, y1), new Point(x2, y2), new Point(x2, y2));
                //dont work
                
                
            }
            else if (currentstate == state.DrawPoly)
            {
               // test.DrawPolygon(
            }
            else if (currentstate == state.Pencil)
            {
            }
            else if (currentstate == state.Brush)
            {
                
            }
            else if (currentstate == state.RectSelect)
            {
            }
            else if (currentstate == state.WriteText)
            {
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
                
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                test.DrawString(writetext, drawFont, drawBrush, x1, y1);
            }
           //clean up some stuff
            myPen.Dispose();
            test.Dispose();
            //show the new image
            pictureBoxDrawArea.Image = bm;
        }

        //mouse has moved, useful for free draw
        private void pictureBoxDrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            if(currentstate == state.Pencil || currentstate == state.Brush)
                if (Control.MouseButtons == MouseButtons.Left)
                    if(currentstate == state.Pencil)
                        paintCurrentPosition(e.Location, 2, button1.BackColor);
                    else if (currentstate == state.Brush)
                        paintCurrentPosition(e.Location, 4, button1.BackColor);

        }
        //function used for free draw
        private void paintCurrentPosition(Point loc, int thickness, Color colorPen)
        {
            System.Drawing.Graphics test = Graphics.FromImage(bm);
            
            SolidBrush brush = new SolidBrush(colorPen);
           
            test.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            test.DrawLine(new Pen(brush, thickness), _lastLoc, loc);
            _lastLoc = loc;
        }
        private Point _lastLoc;
        //mouse has gone down, track where it is
        private void pictureBoxDrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            _lastLoc = e.Location;
        }
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        //color button has been clicked
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void textBoxStatusBar_TextChanged(object sender, EventArgs e)
        {

        }
        //rotate button clicked
        private void buttonRotate_Click(object sender, EventArgs e)
        {
            textBoxStatusBar.Text = "rotate";
            currentstate = state.Rotate;
            bm.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBoxDrawArea.Image = bm;
            
        }
        //save button clicked
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                bm.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                
                textBoxStatusBar.Text = "file saved";
            }
        }
        //horizontal flip button clicked
        private void buttonFlipHoriz_Click(object sender, EventArgs e)
        {
            currentstate = state.FlipHoriz;
            textBoxStatusBar.Text = state.FlipHoriz.ToString();
            bm.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBoxDrawArea.Image = bm;
        }
        //flip vertical button clicked
        private void buttonFlipVert_Click(object sender, EventArgs e)
        {
            currentstate = state.FlipVert;
            textBoxStatusBar.Text = state.FlipVert.ToString();
            bm.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBoxDrawArea.Image = bm;
        }
        //text has changed, update the string
        string writetext;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            currentstate = state.WriteText;
            textBoxStatusBar.Text = state.WriteText.ToString();
            writetext = textBox1.Text;
        }

    }
}
