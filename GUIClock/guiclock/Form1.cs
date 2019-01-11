using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            //Create the timer and start it 
            ClockTimer.Tick += ClockTimer_Tick;
            ClockTimer.Enabled = true;
            ClockTimer.Interval = 1;
            ClockTimer.Start(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private Timer ClockTimer = new Timer();
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            //Clear the graphics to the back color of the control 
            pe.Graphics.Clear(BackColor);

            //Draw the border of the clock 
            pe.Graphics.DrawEllipse(Pens.Black, new Rectangle(10,20, Size.Width - 40 , Size.Height - 60));
            //pe.Graphics.DrawEllipse(Pens.Black, 0, 0, Size.Width - 10, Size.Height - 10);

            //Find the radius of the control by dividing the width by 2 
            float radius = ((Size.Width / 2) + (Size.Height / 2))/2 - 50;

            //Find the origin of the circle by dividing the width and height of the control 
            PointF origin = new PointF(Size.Width / 2, Size.Height / 2);

            //Draw only if ShowMajorSegments is true; 
            if (ShowMajorSegments)
            {
                //Draw the Major segments for the clock 
                for (float i = 0f; i != 390f; i += 30f)
                {
                    pe.Graphics.DrawLine(Pens.Black, PointOnCircle(radius - 1, i, origin), PointOnCircle(radius - 21, i, origin));
                }
            }

            //Draw only if ShowMinorSegments is true 
            if (ShowMinorSegments)
            {
                //Draw the minor segments for the control 
                for (float i = 0f; i != 366f; i += 6f)
                {
                    pe.Graphics.DrawLine(Pens.Black, PointOnCircle(radius, i, origin), PointOnCircle(radius - 10, i, origin));
                }
            }

            //Draw only if ShowSecondHand is true 
            if (ShowSecondhand)
                //Draw the second hand 
                pe.Graphics.DrawLine(Pens.Black, origin, PointOnCircle(radius, DateTime.Now.Second * 6f, origin));

            //Draw only if ShowMinuteHand is true 
            if (ShowMinuteHand)
                //Draw the minute hand 
                pe.Graphics.DrawLine(Pens.Black, origin, PointOnCircle(radius * 0.75f, DateTime.Now.Minute * 6f, origin));

            //Draw only if ShowHourHand is true 
            if (ShowHourHand)
                //Draw the hour hand 
                pe.Graphics.DrawLine(Pens.Black, origin, PointOnCircle(radius * 0.50f, DateTime.Now.Hour * 30f, origin));

            Font fn = new Font("Comic Sans MS", 12);
            SolidBrush solidBlack = new SolidBrush(Color.Black);
            SolidBrush solidRed = new SolidBrush(Color.Red);

            pe.Graphics.DrawString("12", fn, solidBlack, PointOnCircle(radius, 0, origin));
            pe.Graphics.DrawString("24", fn, solidRed, PointOnCircle(radius - 20, 0, origin));

            pe.Graphics.DrawString("1", fn, solidBlack, PointOnCircle(radius, 30, origin));
            pe.Graphics.DrawString("13", fn, solidRed, PointOnCircle(radius - 20, 30, origin));

            pe.Graphics.DrawString("2", fn, solidBlack, PointOnCircle(radius, 60, origin));
            pe.Graphics.DrawString("14", fn, solidRed, PointOnCircle(radius - 20, 60, origin));

            pe.Graphics.DrawString("3", fn, solidBlack, PointOnCircle(radius, 90, origin));
            pe.Graphics.DrawString("15", fn, solidRed, PointOnCircle(radius - 20, 90, origin));

            pe.Graphics.DrawString("4", fn, solidBlack, PointOnCircle(radius, 120, origin));
            pe.Graphics.DrawString("16", fn, solidRed, PointOnCircle(radius - 20, 120, origin));

            pe.Graphics.DrawString("5", fn, solidBlack, PointOnCircle(radius - 10, 150, origin));
            pe.Graphics.DrawString("17", fn, solidRed, PointOnCircle(radius - 30, 150, origin));

            pe.Graphics.DrawString("6", fn, solidBlack, PointOnCircle(radius - 10, 180, origin));
            pe.Graphics.DrawString("18", fn, solidRed, PointOnCircle(radius - 30, 180, origin));

            pe.Graphics.DrawString("7", fn, solidBlack, PointOnCircle(radius, 210, origin));
            pe.Graphics.DrawString("19", fn, solidRed, PointOnCircle(radius - 20, 210, origin));

            pe.Graphics.DrawString("8", fn, solidBlack, PointOnCircle(radius, 240, origin));
            pe.Graphics.DrawString("20", fn, solidRed, PointOnCircle(radius - 20, 240, origin));

            pe.Graphics.DrawString("9", fn, solidBlack, PointOnCircle(radius, 270, origin));
            pe.Graphics.DrawString("21", fn, solidRed, PointOnCircle(radius - 20, 270, origin));

            pe.Graphics.DrawString("10", fn, solidBlack, PointOnCircle(radius, 300, origin));
            pe.Graphics.DrawString("22", fn, solidRed, PointOnCircle(radius - 20, 300, origin));

            pe.Graphics.DrawString("11", fn, solidBlack, PointOnCircle(radius, 330, origin));
            pe.Graphics.DrawString("23", fn, solidRed, PointOnCircle(radius - 20, 330, origin));

            
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            //Make sure the control is square 
            if (Size.Height != Size.Width)
                Size = new Size(Size.Width, Size.Width);

            //Redraw the control 
            Refresh();
        }
        private PointF PointOnCircle(float radius, float angleInDegrees, PointF origin)
        {
            //Find the x and y using the parametric equation for a circle 
            float x = (float)(radius * Math.Cos((angleInDegrees - 90f) * Math.PI / 180F)) + origin.X;
            float y = (float)(radius * Math.Sin((angleInDegrees - 90f) * Math.PI / 180F)) + origin.Y;

            /*Note : The "- 90f" is only for the proper rotation of the clock. 
             * It is not part of the parament equation for a circle*/

            //Return the point 
            return new PointF(x, y);
        }
        private bool showMinorSegments = true;

        /// <summary> 
        /// Indicates if the minor segements are shown 
        /// </summary> 
        public bool ShowMinorSegments
        {
            get
            {
                return showMinorSegments;
            }
            set
            {
                showMinorSegments = value;
                Refresh();
            }
        }

        private bool showMajorSegments = true;

        /// <summary> 
        /// Indicates if the major segements are shown 
        /// </summary> 
        public bool ShowMajorSegments
        {
            get
            {
                return showMajorSegments;
            }
            set
            {
                showMajorSegments = value;
                Refresh();
            }
        }

        private bool showSecondHand = true;

        /// <summary> 
        /// Indicates if the second hand is shown 
        /// </summary> 
        public bool ShowSecondhand
        {
            get
            {
                return showSecondHand;
            }
            set
            {
                showSecondHand = value;
                Refresh();
            }
        }
        private bool showMinuteHand = true;

        /// <summary> 
        /// Indicates if the minute hand is shown 
        /// </summary> 
        public bool ShowMinuteHand
        {
            get
            {
                return showMinuteHand;
            }
            set
            {
                showMinuteHand = value;
                Refresh();
            }
        }
        private bool showHourHand = true;

        /// <summary> 
        /// Indicates if the hour hand is shown 
        /// </summary> 
        public bool ShowHourHand
        {
            get
            {
                return showHourHand;
            }
            set
            {
                showHourHand = value;
                Refresh();
            }
        } 
    }
}
