using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Windows.Media;
using System.Runtime.CompilerServices;

namespace _20174627_김혜진
{
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

            private void label61_Click(object sender, EventArgs e)
        {          
            System.Diagnostics.Process.Start("https://map.naver.com/v5/search/%EA%B2%BD%EA%B8%B0%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%B2%AD%ED%8F%89%EB%A9%B4%20%EC%82%BC%ED%9A%8C%EB%A6%AC%20101-4/address/14181826.542656202,4538183.271127174,%EA%B2%BD%EA%B8%B0%EB%8F%84%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%B2%AD%ED%8F%89%EB%A9%B4%20%EC%82%BC%ED%9A%8C%EB%A6%AC%20101-4,jibun?c=14180894.9663740,4538183.2711272,14,0,0,0,dh");
        }

        private void label62_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://map.naver.com/v5/search/%EA%B2%BD%EA%B8%B0%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%84%A4%EC%95%85%EB%A9%B4%20%ED%9A%8C%EA%B3%A1%EB%A6%AC%20468/address/14187096.31829476,4538759.41196648,%EA%B2%BD%EA%B8%B0%EB%8F%84%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%84%A4%EC%95%85%EB%A9%B4%20%ED%9A%8C%EA%B3%A1%EB%A6%AC%20468,jibun?c=14186164.7420125,4538759.4119665,14,0,0,0,dh");
        }

        private void label63_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://map.naver.com/v5/search/%EA%B2%BD%EA%B8%B0%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%B2%AD%ED%8F%89%EB%A9%B4%20%EA%B3%A0%EC%84%B1%EB%A6%AC%20761-1/address/14191475.538006973,4538616.601492053,%EA%B2%BD%EA%B8%B0%EB%8F%84%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%B2%AD%ED%8F%89%EB%A9%B4%20%EA%B3%A0%EC%84%B1%EB%A6%AC%20761-1,jibun?c=14191353.0386628,4538630.9846257,17,0,0,0,dh");
        }

        private void label64_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://map.naver.com/v5/search/%EA%B2%BD%EA%B8%B0%EB%8F%84%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%B2%AD%ED%8F%89%EB%A9%B4%20%EA%B3%A0%EC%84%B1%EB%A6%AC%2025-6/address/14195165.959007952,4537258.467602788,%EA%B2%BD%EA%B8%B0%EB%8F%84%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%B2%AD%ED%8F%89%EB%A9%B4%20%EA%B3%A0%EC%84%B1%EB%A6%AC%2025-6?c=14195049.4602903,4537258.4060154,17,0,0,0,dh");
        }

        private void label65_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://map.naver.com/v5/search/%EA%B2%BD%EA%B8%B0%20%EC%96%91%ED%8F%89%EA%B5%B0%20%EC%84%9C%EC%A2%85%EB%A9%B4%20%EC%84%9C%ED%9B%84%EB%A6%AC%2042/address/14184941.685022656,4520626.270231439,%EA%B2%BD%EA%B8%B0%EB%8F%84%20%EC%96%91%ED%8F%89%EA%B5%B0%20%EC%84%9C%EC%A2%85%EB%A9%B4%20%EC%84%9C%ED%9B%84%EB%A6%AC%2042,jibun?c=14184008.4898531,4520624.3948991,14,0,0,0,dh");
        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form4_1 form4_1 = new Form4_1();
            form4_1.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("9  번 라벨");

            Form5 form5 = new Form5();
            form5.Show();
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

        private void label56_Click(object sender, EventArgs e)
        {
            Form4_1 form4_1 = new Form4_1();
            form4_1.ShowDialog();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            Form4_1 form4_1 = new Form4_1();
            form4_1.ShowDialog();
        }

        private void label48_Click(object sender, EventArgs e)
        {
            Form4_1 form4_1 = new Form4_1();
            form4_1.ShowDialog();
        }

        private void label54_Click(object sender, EventArgs e)
        {
            Form4_1 form4_1 = new Form4_1();
            form4_1.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }  
}

