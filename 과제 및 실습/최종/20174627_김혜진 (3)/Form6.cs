using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20174627_김혜진
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("impo.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                if (Form1.Id_name.Equals(line.Split('@')[7]))
                {
                    textBox5.Text = line.Split('@')[0];
                    textBox4.Text = line.Split('@')[1];
                    textBox2.Text = line.Split('@')[2];
                    textBox1.Text = line.Split('@')[3];
                    textBox10.Text = line.Split('@')[4];
                    textBox11.Text = line.Split('@')[5];
                    textBox7.Text = line.Split('@')[6];
                    textBox14.Text = line.Split('@')[7];
                    textBox15.Text = line.Split('@')[8];
                    textBox13.Text = line.Split('@')[9];
                }
            }
            file.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("impo.txt");

            int indexnum=-1;

            for (int i=lines.Count() - 1;i>=0;i--)
            {
                if(lines[i].Contains(Form1.Id_name)){
                    indexnum = i;
                }
            }

            MessageBox.Show(indexnum.ToString());
            lines = lines.Where((val, idx) => idx != indexnum).ToArray();
            foreach(string k in lines)
                MessageBox.Show(k);

            File.WriteAllLines("impo.txt",lines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
