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
    public partial class EX_3 : Form
    {
        Graphics g;
        Pen p;
        float ps; float ts;
        Brush b;
        public EX_3()
        {
            InitializeComponent();
            ps = 1.0f; ts = 0.3f;
        }

        private void Paint_1(object sender, PaintEventArgs e)
            {
            g = e.Graphics;
            p = new Pen(Color.BlueViolet, ps);

        }

        private void EX_3_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(Color.BlueViolet, ps);
            Point p1 = new Point(128, 458); 
            Point p2 = new Point(243, 328);
            Point p3 = new Point(374, 198);
            Point p4 = new Point(490, 86);

            Point p5 = new Point(536,66);
             
            Point p6 = new Point(594, 109);
            Point p7 = new Point(85, 153);
            Point p8 = new Point(90, 160);
            Point p9 = new Point(97, 159);
            Point p10 = new Point(96, 148);
            Point p11 = new Point(175, 75);
            Point p12 = new Point(372, 410);
            Point p13 = new Point(322, 408);
            Point p14 = new Point(265, 395);
            Point p17 = new Point(175, 445);
            Point p16 = new Point(210, 450);
            Point p15 = new Point(390, 361);
            //Point[] ptAr = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };
            Point[] ptAr = { p1, p2, p3, p4};
            //g.DrawClosedCurve(p, ptAr);
            //g.DrawEllipse(p, 200, 152, 40, 40);
            g.DrawLines(p, ptAr);
            //
            g.DrawBezier(p, p1, p17, p16, p15);
            //g.DrawBezier(p, p14, p13, p12);
            g.Dispose();

            /*g = e.Graphics;
            p = new Pen(Color.BlueViolet, ps);
            
           // g.FillEllipse(b, 51, 51, 198, 198);
            g.DrawEllipse(p, 200, 65, 20, 100);
            //g.FillEllipse(b, 51, 271, 198, 198);
            g.DrawEllipse(p, 200, 160, 20, 100);
            g.DrawEllipse(p, 115, 152, 100, 20);
            g.DrawEllipse(p, 208, 152, 100, 20);
            g.DrawEllipse(p, 200, 152, 20, 20);*/

        }
    }

}
