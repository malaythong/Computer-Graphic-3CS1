using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Computer_Graphic
{
    public partial class EX_6 : Form
    {
        public EX_6()
        {
            InitializeComponent();
        }

        private void DrawArrow(Pen pen, Graphics gr)
        {
            Point[] pts =
            {
                new Point( 50,  50),
                new Point(150,  50),
                new Point(150,  20),
                new Point(200,  70),
                new Point(150, 120),
                new Point(150,  90),
                new Point( 50,  90)
            };
            gr.DrawPolygon(pen, pts);
        }

        private Matrix TranslateG(float x, float y)
        {
            Matrix tran = new Matrix();
            tran.Translate(x, y);
            return tran;
        }
        private Matrix ScaleG(float x, float y)
        {
            Matrix sc = new Matrix();
            sc.Scale(x, y);
            return sc;
        }
        private Matrix RotateAroundPoint(float angle, Point center)
        {
            // Translate the point to the origin.
            Matrix result = new Matrix();
            //result.Translate(100, 100);
            //result.Scale(3, 3);
            result.RotateAt(angle, center);
            return result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the basic arrow.
            DrawArrow(Pens.Blue, g);

            // Draw the point of rotation.
            Point center = new Point(50, 70);
            g.FillEllipse(Brushes.Red,
                center.X - 3, center.Y - 3, 6, 6);

            // Rotate 30 degrees around the point.
            g.Transform = RotateAroundPoint(30, center);
            // Draw the arrow rotated.
            DrawArrow(Pens.Green, g);

            // Rotate 60 degrees around the point.
            g.Transform = RotateAroundPoint(60, center);
            // Draw the arrow rotated.
            DrawArrow(Pens.Red, g);

            /*//ຄຳສັ່ງ Translate
            g.Transform = TranslateG(200, 100);
            DrawArrow(Pens.Tomato, g);

            //ສ່ວນຄຳສັ່ງ scale 
            g.Transform = ScaleG(2, 2);
            DrawArrow(Pens.Tomato, g);*/

            pictureBox1.Image = bmp;
            g.Dispose();
        }
    }
}
