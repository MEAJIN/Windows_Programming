using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex09_05_MessageBoxIconApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int i;
        private void Form1_Click(object sender, EventArgs e)
        {
            i = i < 64 ? i += 16 : 0;
            this.Text = ((MessageBoxIcon)i).ToString();
            MessageBox.Show("MessageBoxIcon", "Title Bar",
                       MessageBoxButtons.OKCancel, (MessageBoxIcon)i);
        }
    }
}
