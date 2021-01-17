using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12_03_FromImageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Size s = ClientRectangle.Size;
            Image img = new Bitmap(s.Width, s.Height);
            Graphics bg = Graphics.FromImage(img);
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255),
                                     r.Next(0, 255));
            bg.FillRectangle(new SolidBrush(c), ClientRectangle);

            Graphics fg = e.Graphics;
            fg.DrawImage(img, 0, 0);
        }
    }
}
