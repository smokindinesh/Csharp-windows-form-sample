using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastPixelPlot
{
    public partial class Form1 : Form
    {
        private Bitmap m_Canvas;

        public Form1()
        {
            InitializeComponent();

        }
        // Call this somewhere
        public void DrawSquare()
        {
            m_Canvas = new Bitmap(700, 700); // Doesn't have to be initialized here

            for (int x = 100; x < 200; x++)
            {
                for (int y = 100; y < 200; y++)
                {
                    m_Canvas.SetPixel(x, y, Color.Blue);
                }
            }

            SetCanvasAsImage();
        }

        public void SetCanvasAsImage()
        {
            pictureBox1.Image = m_Canvas;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawSquare();
        }


    }
}
