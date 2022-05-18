﻿using System;
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
    public partial class EX_11 : Form
    {
        public EX_11()
        {
            InitializeComponent();
        }

        private void EX_11_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen myPen = new Pen(Color.DarkRed, 10);
            int y = 20;
            foreach (LineJoin join in Enum.GetValues(typeof(LineJoin)))
            {
                myPen.LineJoin = join;
                e.Graphics.DrawRectangle(myPen, 20, y, 100, 40);
                e.Graphics.DrawString(join.ToString(), new Font("Tahoma", 8), Brushes.Black, 140, y + 30);
                y += 70;
            }

        }
    }
}
