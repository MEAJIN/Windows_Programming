using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10_09_KeyEventApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int xPt, yPt;
        public static readonly int MOVE = 10;
        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            this.xPt = this.button1.Location.X;
            this.yPt = this.button1.Location.Y;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    xPt -= MOVE; break;
                case Keys.Right:
                    xPt += MOVE; break;
                case Keys.Up:
                    yPt -= MOVE; break;
                case Keys.Down:
                    yPt += MOVE; break;
            }
            this.button1.Text = e.KeyCode.ToString();
            this.button1.Location = new Point(xPt, yPt);
        }
    }
}
