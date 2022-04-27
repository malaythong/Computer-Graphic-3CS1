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
    public partial class EX_7 : Form
    {
        public EX_7()
        {
            InitializeComponent();
        }
        Graphics g;
        Bitmap bmp = new Bitmap("Im1.jpg");

        private void EX_7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, 150, 150);

            //ແຕ້ມຮູບອອກມາກຳນົດຂະໜາດເປັນ 150x150
            g.DrawImage(bmp, rect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            /*Matrix m = new Matrix();
            m.Rotate(45);
            g.Transform = m;*/
            g.RotateTransform(45);
            g.DrawImage(bmp, new Rectangle(212, 0, 150, 150), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            /*Matrix m = new Matrix();
            m.Translate(int.Parse(txtX.Text),int.Parse(txtY.Text),MatrixOrder.Prepend);
            g.Transform = m;*/
            g.TranslateTransform(int.Parse(txtX.Text), int.Parse(txtY.Text), MatrixOrder.Prepend);
            g.DrawImage(bmp, new Rectangle(212, 0, 150, 150), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();

            Matrix m = new Matrix();
            m.Shear(float.Parse(txtShx.Text), float.Parse(txtShy.Text));
            g.Transform = m;

            g.DrawImage(bmp, new Rectangle(0, 50, 150, 150), 0, 0,
                        bmp.Width, bmp.Height, GraphicsUnit.Pixel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            /*Matrix m = new Matrix();
            m.Scale(float.Parse(txtShx.Text), float.Parse(txtShy.Text),MatrixOrder.Prepend);
            g.Transform = m;*/
            g.ScaleTransform(float.Parse(txtShx.Text), float.Parse(txtShy.Text), MatrixOrder.Prepend);
            g.DrawImage(bmp, new Rectangle(112, 300, 150, 150), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
        }
    }
    
}
