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

namespace Computer_Graphic
{
    public partial class EX_10 : Form
    {
        public EX_10()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("Im1.jpg"), int.Parse(txtW.Text), int.Parse(txtH.Text));
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            g.DrawImage(bmp, 270, 270);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("Im1.jpg"), int.Parse(txtW.Text), int.Parse(txtH.Text));
            g.DrawImage(bmp, 10, 12);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("Im1.jpg"), int.Parse(txtW.Text), int.Parse(txtH.Text));
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            g.DrawImage(bmp, 10, 270);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.Clear(Color.WhiteSmoke);
            Bitmap bmp = new Bitmap(Image.FromFile("Im1.jpg"), int.Parse(txtW.Text), int.Parse(txtH.Text));
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            g.DrawImage(bmp, 10, 270);
        }

    }
}
