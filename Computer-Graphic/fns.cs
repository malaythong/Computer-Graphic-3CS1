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

namespace Computer_Graphic
{
    public partial class fns : Form
    {
        Graphics g;
        Pen p, pp1;
        float ps; float ts;
        Brush b;

        public fns()
        {
            InitializeComponent();
            ps = 1.0f; ts = 0.3f;
        }

        private void fns_Paint(object sender, PaintEventArgs e)
        {
            RedRibbin(e);
            g.Dispose();
        }

        private void RedRibbin(PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(Color.BlueViolet, ps);

            //create point
            Point p1 = new Point(238, 545), p2 = new Point(240, 510), p3 = new Point(250, 480), p4 = new Point(260, 470), p5 = new Point(275, 470), p6 = new Point(335, 500),
                  p7 = new Point(425, 510), p8 = new Point(510, 500), p9 = new Point(565, 480), p10 = new Point(580, 470), p11 = new Point(590, 470), p12 = new Point(600, 480),
                  p13 = new Point(615, 515), p14 = new Point(615, 545), p15 = new Point(598, 540), p16 = new Point(575, 550), p17 = new Point(530, 570), p18 = new Point(425, 580),
                  p19 = new Point(335, 570), p20 = new Point(255, 540), p21 = new Point(255, 540), p22 = new Point(245, 535), p23 = new Point(530, 570), p24 = new Point(425, 580);
            //Point p10 = new Point(390, 20);

            Point[] ptArA1 = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13 };
            Point[] ptArA2 = { p13, p14, p15, p16 };
            Point[] ptArA3 = { p16, p17, p18, p19, p20};
            Point[] ptArA4 = { p20, p21, p22, p1 };
            // Create tension.
            float ts1 = 0.5F, ts2 = 1.0F, ts3 = 0.1F;

            // Draw curve to screen.
            e.Graphics.DrawCurve(p, ptArA1, ts1);
            e.Graphics.DrawCurve(p, ptArA2, ts2);
            e.Graphics.DrawCurve(p, ptArA3, ts1);
            e.Graphics.DrawCurve(p, ptArA4, ts2);
            //e.Graphics.(pp1, ptArA4);
            // g.DrawLines(p, ptArA3);
            //g.Dispose();
        }

    }
}
