using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12_01_PaintEventApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255),
                                     r.Next(0, 255));
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }
    }
}
