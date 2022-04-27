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
    public partial class EX_2 : Form
    {
        Graphics g;
        Pen p;
        float ps; float ts;
        public EX_2()
        {
            InitializeComponent();
            ps = 3.0f; ts = 0.3f;
        }

        private void EX_2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(Color.BlueViolet, ps);
            Point p1 = new Point(100, 100); Point p2 = new Point(50, 50);
            Point p3 = new Point(25, 75); Point p4 = new Point(100, 200);
            Point p5 = new Point(175, 75); Point p6 = new Point(150, 50);
            Point[] ptAr = { p1, p2, p3, p4, p5, p6 }; 
            g.DrawClosedCurve(p, ptAr); 
            //g.DrawCurve(p, ptAr); 
            //g.DrawCurve(p, ptAr, ts); 
            //g.DrawClosedCurve(p, ptAr, ts,FillMode.Alternate); 
            //g.FillClosedCurve(Brushes.Red, ptAr); 
            //g.FillClosedCurve(Brushes.Red, ptAr, FillMode.Alternate, ts);  
            //g.DrawPolygon(p, ptAr); 
            //g.FillPolygon(Brushes.Yellow, ptAr); 
            //g.DrawLine(p, 100, 100, 200, 200); 
            //g.DrawLines(p, ptAr);
            g.Dispose();

        }
    }
}
