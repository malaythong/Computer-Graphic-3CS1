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
    public partial class Demo : Form
    {
        Graphics g;
        Pen p,pp1;
        float ps; float ts;
        Brush b;
        public Demo()
        {
            InitializeComponent();
            ps = 3.0f; ts = 0.3f;
        }

        private void Demo_Paint(object sender, PaintEventArgs e)
        {
            Bird(e);
            g = e.Graphics;
            p = new Pen(Color.BlueViolet, ps);
           /* Point p1 = new Point(20, 10);
            Point p2 = new Point(20, 100);
            Point p3 = new Point(20, 200);
            Point p4 = new Point(20, 300);
            Point p50 = new Point(20, 550);

            Point p5 = new Point(20, 550);
            Point p6 = new Point(120, 550);
            Point p7 = new Point(220, 550);
            Point p8 = new Point(370, 550);
            Point p20 = new Point(520, 550);

            Point p9 = new Point(15, 10);       Point p10 = new Point(25, 10);
            Point p11 = new Point(15, 20);      Point p12 = new Point(25, 20);
            Point p13 = new Point(15, 30);      Point p14 = new Point(25, 30);
            Point p15 = new Point(15, 40);      Point p16 = new Point(25, 40);
            Point p17 = new Point(15, 50);      Point p18 = new Point(25, 50);

            //Point[] ptAr = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };
            Point[] ptArX = { p1, p2, p3, p4, p50 };
            Point[] ptArY = { p5, p6, p7, p8, p20 };
            //g.DrawClosedCurve(p, ptAr);
            //g.DrawEllipse(p, 200, 152, 40, 40);
            g.DrawLines(p, ptArX);
            g.DrawLines(p, ptArY);

            // Create graphics path object and add ellipse.
            GraphicsPath graphPath = new GraphicsPath();
            graphPath.AddLine(p9, p10);
            //graphPath.AddLine(p11, p12);
            //g.DrawPath(p, graphPath);
            g.DrawLine(p, p9, p10);
            g.DrawLine(p, p11, p12);
            g.DrawLine(p, p13, p14);
            g.DrawLine(p, p15, p16);
            g.DrawLine(p, p17, p18);
            //g.DrawBezier(p, p1, p17, p16, p15);
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
        private void Bird(PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(Color.Black, ps);           
            pp1 = new Pen(Color.Green, ps);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush goldBrush = new SolidBrush(Color.SaddleBrown);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            GraphicsPath path = new GraphicsPath();
            

            Point p1 = new Point(25, 395);      Point p2 = new Point(60, 385);      Point p3 = new Point(95, 370);
            Point p4 = new Point(125, 355);     Point p5 = new Point(165, 330);     Point p6 = new Point(230, 290);

            Point p7 = new Point(170, 230);      Point p8 = new Point(220, 180);      Point p9 = new Point(275, 130);
            Point p10 = new Point(390, 20);

            Point p11 = new Point(380,30);     Point p12 = new Point(420,10);     Point p13 = new Point(180,339);
            Point p14 = new Point(470, 20); Point p15 = new Point(490, 45);

            Point p16 = new Point(535, 50);     Point p17 = new Point(495, 75);

            Point p18 = new Point(487, 105), p19 = new Point(470, 130), p20 = new Point(460, 160), p21 = new Point(455, 205), p22 = new Point(445, 240), p23 = new Point(430, 275), p24 = new Point(410, 300),
                  p25 = new Point(380, 320), p26 = new Point(345, 335), p27 = new Point(325, 340), p28 = new Point(304, 345);


            Point p29 = new Point(305, 345), p30 = new Point(260, 385), p31 = new Point(315, 435);

            Point p32 = new Point(280, 455), p33 = new Point(295, 440), p34 = new Point(240, 386);
                  
            Point p35 = new Point(270, 347), p36 = new Point(220, 350);

            Point p37 = new Point(325, 430), p38 = new Point(350, 440), p39 = new Point(365, 455);

            Point p40 = new Point(340, 445), p41 = new Point(350, 460), p42 = new Point(310, 450);

            Point p43 = new Point(330, 340), p44 = new Point(275, 385);

            Point p55 = new Point(148, 255), p56 = new Point(185, 215), p57 = new Point(235, 165), p58 = new Point(285, 125), p59 = new Point(340, 110), p60 = new Point(380, 130), p61 = new Point(405, 165),
                  p62 = new Point(410, 205), p63 = new Point(385, 255), p64 = new Point(350, 280), p65 = new Point(300, 295), p66 = new Point(255, 295), p67 = new Point(210, 285), p68 = new Point(180, 275);

            Point p69 = new Point(380, 260), p70 = new Point(407, 270), p71 = new Point(434, 268);

            Point[] ptArA1 = { p1, p2, p3, p4, p5, p6 };
            Point[] ptArA2 = { p1, p7, p8, p9, p10};
            Point[] ptArA3 = { p10, p12, p14, p15, p17};
            Point[] ptArA4 = { p15, p16, p17 };
            Point[] ptArA5 = { p5, p4, p3, p2, p1, p7, p8, p9, p11, p12, p14, p15, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p36, p13, p5};
            Point[] ptArA6 = { p29, p30, p31};
            Point[] ptArA7 = { p33, p34, p35, p29, p30, p31 };
            Point[] ptArA8 = { p35, p36, p5 };
            Point[] ptArA9 = { p37, p38, p39, p40, p31};
            Point[] ptArA10 = { p31, p40, p41, p42, p32, p33 };
            Point[] ptArA11 = { p31, p30, p29, p43, p44, p37 };
            Point[] ptArA12 = { p55, p56, p57, p58, p59, p60, p61, p62, p63, p64, p65, p66, p67, p68, p55 };
            Point[] ptArA13 = { p69, p70, p71 };
            Point[] ptArA51 = { p6, p5, p4, p3, p2, p1, p7, p8, p9, p11, p12, p14, p15, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p36, p5 };

            // Create tension.
            float ts1 = 0.5F, ts2 = 0.6F, ts3 = 0.2F;

            LinearGradientBrush GBlue = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(192, 192, 192), Color.FromArgb(0, 19, 127), 230F);
            LinearGradientBrush GBlue2 = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(0, 2, 48), Color.FromArgb(118, 128, 232), 300F);
            LinearGradientBrush GYellow = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(232, 224, 118), Color.FromArgb(227, 215, 48), 10F);
            LinearGradientBrush GYellow2 = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(179, 170, 92), Color.FromArgb(250, 230, 50), 120F);
            LinearGradientBrush GBrown = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(51, 32, 29), Color.FromArgb(250, 230, 50), 10F);

            // Draw curve to screen.
            e.Graphics.DrawCurve(p, ptArA1, ts1);
            e.Graphics.DrawCurve(p, ptArA2, ts1);
            e.Graphics.DrawCurve(p, ptArA3, ts2);

            //mouth
            e.Graphics.FillPolygon(GYellow, ptArA4);
            g.DrawLines(p, ptArA4);

            //body
            e.Graphics.FillClosedCurve(GBlue, ptArA5);
            e.Graphics.DrawCurve(p, ptArA51, ts2);
            
            g.DrawLines(p, ptArA6);
            //e.Graphics.FillPolygon(goldBrush, ptArA6);
            
            
            //feet
            //e.Graphics.DrawCurve(pp1, ptArA8, ts1);
            e.Graphics.FillPolygon(GYellow2, ptArA9);
            e.Graphics.DrawCurve(p, ptArA9, ts2);
            e.Graphics.FillPolygon(GYellow2, ptArA10);
            e.Graphics.DrawCurve(p, ptArA10, ts2);

            //leg
            e.Graphics.FillPolygon(GBrown, ptArA11);
            g.DrawLines(p, ptArA11);
            e.Graphics.FillPolygon(GBrown, ptArA7);
            g.DrawLines(p, ptArA7);

            //e.Graphics.FillPolygon(yellowBrush, ptArA12);
            e.Graphics.DrawCurve(p, ptArA12, ts2);
            e.Graphics.FillClosedCurve(GBlue2, ptArA12);

            //eyes
            e.Graphics.DrawCurve(p, ptArA13, ts2);
            //g.DrawEllipse(p, 440, 45, 15, 15);
            g.FillEllipse(Brushes.Black, 440, 45, 20, 20);
            //g.Dispose();
        }
    }
}
