using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawingbasicshapes
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        // public Bitmap myBitmap = new Bitmap(1,1);
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void MainForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create string to draw.
            String drawStringline = "Draw line";
            String drawStringellipse = "Draw Ellipse";
            String drawStringFillellipse = "Draw Fill Ellipse";
            String drawStringcurve = "Draw closed curve";
            //String drawStringellipse = "Draw ellipse";
            //String drawStringellipse = "Draw ellipse";
            //String drawStringellipse = "Draw ellipse";
            //String drawStringellipse = "Draw ellipse";


            //create a graphics object from the form
            Graphics g = this.CreateGraphics();
            // Create font and brush.
            Pen blackPen = new Pen(Color.Black);
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            SolidBrush drawBrushObj = new SolidBrush(Color.Blue);
            Pen p = new Pen(Color.Red, 2);

            //*----------Drawing line-------------*


            RectangleF drawRect1 = new RectangleF(5.0f, 5.0f, 100.0f, 25.0f);

            // Draw rectangle to screen.
            g.DrawRectangle(blackPen, 5.0f, 5.0f, 100.0f, 25.0f);

            // Draw string to screen.
            g.DrawString(drawStringline, drawFont, drawBrush, drawRect1);
            // create  a  pen object with which to draw

            // draw the line 
            // call a member of the graphics class
            g.DrawLine(p, 5, 40, 100, 40);



            //*----------Draw ellipse-------------*
            RectangleF drawRect2 = new RectangleF(115.0f, 5.0f, 150.0f, 25.0f);

            // Draw rectangle to screen.
            g.DrawRectangle(blackPen, 115.0f, 5.0f, 150.0f, 25.0f);

            // Draw string to screen.
            g.DrawString(drawStringellipse, drawFont, drawBrush, drawRect2);
            // create  a  pen object with which to draw


            Rectangle rect = new Rectangle(150, 35, 100, 50);
            // Draw ellipse to screen.
            g.DrawEllipse(p, rect);


            //*----------Draw Fill ellipse-------------*
            RectangleF drawRect3 = new RectangleF(275.0f, 5.0f, 175.0f, 25.0f);
            // Draw rectangle to screen.
            g.DrawRectangle(blackPen, 275.0f, 5.0f, 175.0f, 25.0f);
            // Draw string to screen.
            g.DrawString(drawStringFillellipse, drawFont, drawBrush, drawRect3);
            // Fill ellipse on screen.
            g.FillEllipse(drawBrushObj, 275, 35, 150, 50);


            //*---------Draw closed Curve--------------*
            RectangleF drawRect4 = new RectangleF(460.0f, 5.0f, 200.0f, 25.0f);
            // Draw rectangle to screen.
            g.DrawRectangle(blackPen, 460.0f, 5.0f, 200.0f, 25.0f);
            // Draw string to screen.
            g.DrawString(drawStringcurve, drawFont, drawBrush, drawRect4);

            // Create points that define curve.
            Point point1 = new Point(470, 45);
            Point point2 = new Point(500, 85);
            Point point3 = new Point(530, 125);
            Point point4 = new Point(560, 150);
            Point point5 = new Point(590, 125);
            Point point6 = new Point(620, 100);
            Point point7 = new Point(650, 45);
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7 };

            // Draw closed curve to screen.
            g.DrawClosedCurve(p, curvePoints);


        }


    }
}
