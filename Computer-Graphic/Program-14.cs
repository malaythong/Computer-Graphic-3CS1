using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Computer_Graphic
{
    public partial class Program_14 : Form
    {
        Graphics g;
        SolidBrush b;
        Pen p;

        public Program_14()
        {
            InitializeComponent();
        }

        private void Program_14_Paint(object sender, PaintEventArgs e)
        {
            /*Graphics g = e.Graphics;
            Point[] LineA = { new Point(10, 10), new Point(150, 150), new Point(400, 10) };

            Pen pen = new Pen(Color.DarkOrange, 10);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            g.DrawLines(pen, LineA);*/

            Pen P = new Pen(Color.Black, 3);
            P.DashStyle = DashStyle.Solid;
            e.Graphics.DrawLine(P, 10, 10, 200, 10);
            P.DashStyle = DashStyle.Dot;
            e.Graphics.DrawLine(P, 10, 30, 200, 30);
            P.DashStyle = DashStyle.Dash;
            e.Graphics.DrawLine(P, 10, 50, 200, 50);
            P.DashStyle = DashStyle.DashDot;
            e.Graphics.DrawLine(P, 10, 70, 200, 70);
            P.DashStyle = DashStyle.DashDotDot;
            e.Graphics.DrawLine(P, 10, 90, 200, 90);
            P.DashStyle = DashStyle.Dash;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pen P = new Pen(Color.Black, 3);
            Graphics G;

            if (comboBox1.SelectedItem == "Dash")
            {
                P.DashStyle = DashStyle.Dash;
                Invalidate();

            }
            if (comboBox1.SelectedItem == "DashDot")
            {
                p.DashStyle = DashStyle.DashDot;
                Invalidate();
            }
            if (comboBox1.SelectedItem == "DashDotDot")
            {
                p.DashStyle = DashStyle.DashDotDot;
            }
            if (comboBox1.SelectedItem == "Solid")
            {
                p.DashStyle = DashStyle.Solid;
            }
            
        }

        private void Program_14_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dash");
            comboBox1.Items.Add("DashDot");
            comboBox1.Items.Add("DashDotDot");
            comboBox1.Items.Add("Solid");

        }
    }
}
