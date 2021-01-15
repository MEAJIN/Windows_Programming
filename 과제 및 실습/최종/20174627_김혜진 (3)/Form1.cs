using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20174627_김혜진
{
    public partial class Form1 : Form
    {

        private static string id_name;

        public static string Id_name { get { return id_name; } set { id_name = value; } }

        public object Form2 { get; internal set; }
        public object Form3 { get; internal set; }



        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);

            form2.ShowDialog();
        }

        public void label4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);

            form2.Show();          
        }

        public void label5_Click(object sender, EventArgs e)
        {
            //텍스트가 회원가입 일 경우
            if (label5.Text.Equals("SIGN UP"))
            {
                Form3 form3 = new Form3();

                form3.Show();
            }

            //텍스트가 로그아웃 일 경우
            else if (label5.Text.Equals("로그아웃"))
            {
                label4.Text = "로그인";
                label4.Enabled = true; //클릭 가능하도록 
                label5.Text = "SIGN UP";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.interpark.com/gate/info/mem_clause.html");
        }

        private void label29_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tour.interpark.com/company/companyOutsidecovenant.aspx");
        
        }

        private void label30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.interpark.com/gate/info/protect_privacy.html");
        }

        private void label8_Click(object sender, EventArgs e)
        {
          
                Form4 form4 = new Form4();
                               
                form4.Show();
            
            
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }
    }
}
