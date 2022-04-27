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
    public partial class EX_8 : Form
    {
        Graphics g; Pen p;
        public EX_8()
        {
            InitializeComponent();
        }
        private void drawEllipe()
        {
            p = new Pen(Color.Red, 3);
            g.DrawEllipse(p, 10, 10, 100, 100);
        }

        private void FillRectangle()
        {
            p = new Pen(Color.Orange, 3);
            g.FillRectangle(Brushes.Cyan, 10, 180, 100, 100);
            g.Dispose();
        }

        private void EX_8_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            drawEllipe();
            FillRectangle();
            g.Dispose();
        }

        private void btnTranslation_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(150, 0);
            drawEllipe();
            g.Dispose();
        }

        private void btnRotation_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(350, 30);
            g.RotateTransform(45);
            FillRectangle();
            g.Dispose();
        }

        private void btnScaling_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(0, 200);
            g.ScaleTransform(2, 1);
            FillRectangle();
            g.Dispose();
        }

        private void bynShaering_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Matrix m = new Matrix();
            m.Translate(-110, 120);
            m.Shear(2, 1);
            g.Transform = m;
            //g.TranslateTransform(350, 30);
            FillRectangle();
            g.Dispose();
        }
    }
}
