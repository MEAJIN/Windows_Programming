using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20174627_김혜진_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 미리보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
    }
}
