using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10_05_MouseEventApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateEventLabels(string msg, int x, int y,
                                                 MouseEventArgs e)
        {
            string message = string.Format("{0} X:{1}, Y:{2}", msg, x, y);
            string eventMsg = DateTime.Now.ToShortTimeString();
            eventMsg += " " + message;
            listBox1.Items.Insert(0, eventMsg);
            listBox1.TopIndex = 0;
            string mouseInfo;
            if (e != null)
            {
                mouseInfo = string.Format("Clicks: {0}, Delta: {1}, " +
                                          "Buttons: {2}", e.Clicks, e.Delta,
                                           e.Button.ToString());
            }
            else
            {
                mouseInfo = string.Format("Clicks: {0}", msg);
            }
            label1.Text = mouseInfo;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateEventLabels("(ListBox)MouseDown", e.X, e.Y, e);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            UpdateEventLabels("(ListBox)DoubleClick",
                               mousePoint.X, mousePoint.Y, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
