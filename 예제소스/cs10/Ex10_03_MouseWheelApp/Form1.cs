using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10_03_MouseWheelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int num;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(this.Form1_MouseWheel);
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            textBox1.Text = (e.Delta > 0 ? num++ : num--).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = 0;
            textBox1.Text = num.ToString();
        }
    }
}
