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
    public partial class Form2 : Form
    {
        Graphics g;
        SolidBrush b;
        Pen p;
        Bitmap im, bmp;
        public Form2()
        {
            InitializeComponent();
            b = new SolidBrush(Color.Orange);
            btnColor.BackColor = ((SolidBrush)b).Color;
            p = new Pen(b.Color, 3);
            im = new Bitmap("mushroom.png");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save Drawed Image";
            sf.DefaultExt = "*.jpg";
            sf.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|BNP Files(*.bmp)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sf.FileName);
            }
        }

        private void cmbLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLine.SelectedItem == "Dash")
            {
                p.DashStyle = DashStyle.Dash;
                pictureBox1.Refresh();
            }
            if (cmbLine.SelectedItem == "DashDot")
            {
                p.DashStyle = DashStyle.DashDot;
                pictureBox1.Refresh();
            }
            if (cmbLine.SelectedItem == "DashDotDot")
            {
                p.DashStyle = DashStyle.DashDotDot;
                pictureBox1.Refresh();
            }
            if (cmbLine.SelectedItem == "Solid")
            {
                p.DashStyle = DashStyle.Solid;
                pictureBox1.Refresh();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(im, 10, 10, 200, 200);
            g.DrawRectangle(p, 10, 10, 200, 200);
            e.Graphics.DrawImage(bmp, 0, 0);
            pictureBox1.Image = bmp;
            g.Dispose();
            Invalidate();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = clr.Color;
                b = new SolidBrush(clr.Color);
                p = new Pen(clr.Color, 3);
                pictureBox1.Invalidate();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbLine.Items.Add("Dash");
            cmbLine.Items.Add("DashDot");
            cmbLine.Items.Add("DashDotDot");
            cmbLine.Items.Add("Solid");
        }


    }
}
