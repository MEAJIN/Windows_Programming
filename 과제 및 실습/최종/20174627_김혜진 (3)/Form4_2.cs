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
using System.Reflection;
using System.Security.Cryptography;

namespace _20174627_김혜진
{
    public partial class Form4_2 : Form
    {
        string start;
        string end;
        string adult;
        string kids;

        string room;
        string price;

        string id;
        string name;
        string email_num;
        string phone;


        public Form4_2()
        {
            InitializeComponent();
            
        }

        private void Form4_2_Load(object sender, EventArgs e)
        {
            id = Form1.Id_name;

            // 예약 정보 및 결제 정보
            string line;
            
            StreamReader file = new StreamReader("reserve.txt");
            while((line=file.ReadLine()) != null)
            {
                start = line.Split('@')[0];
                end = line.Split('@')[1];
                adult = line.Split('@')[2];
                kids = line.Split('@')[3];
            }
            file.Close();

            file = new StreamReader("login_ch.txt");
            while ((line = file.ReadLine()) != null)
            {
                if(id.Equals(line.Split('@')[1]))
                {
                    name = line.Split('@')[0];
                    email_num = line.Split('@')[4];
                    phone = line.Split('@')[5];
                }
            }
            file.Close();

            textBox2.Text = start + "~" + end;
            textBox1.Text = "어른 : " + adult + "명," + " 아이 : " + kids + "명";

            price = Form4_1.Price;
            room = Form4_1.Room;

            textBox10.Text = price;
            label10.Text = room;

            textBox7.Text = price;

            textBox14.Text = name;
            textBox15.Text = email_num;
            textBox13.Text = phone;


            file.Close();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form4_1 form4_1 = new Form4_1();
                form4_1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            writer = File.AppendText("impo.txt");


            writer.WriteLine(label8.Text + "@" + room + "@" + textBox2.Text + "@"
                                    + textBox1.Text + "@" + textBox10.Text+ "@" + textBox11.Text + "@" + textBox7.Text + 
                                    "@" + Form1.Id_name + "@" + textBox15.Text + "@" + textBox13.Text); 

            writer.Close();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string tt = price;
            tt = tt.Substring(0,tt.IndexOf("원"));
            Double tmp = Double.Parse(tt);
            Double pp = tmp * 0.1;
            tmp = tmp * 0.9;


            tt= tmp.ToString();
            textBox11.Text = pp.ToString();
            textBox7.Text = tt;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

