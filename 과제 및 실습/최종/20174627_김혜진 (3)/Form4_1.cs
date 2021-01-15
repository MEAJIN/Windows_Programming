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
using System.Configuration;

namespace _20174627_김혜진
{
    public partial class Form4_1 : Form
    {
        private static string price;
        private static string room_name;

        public static string Price {get { return price; } set { price = value; } }
        public static string Room { get { return room_name; } set { room_name = value; } }

        public Form4_1()
        {
            InitializeComponent();
            initializeDateTimePicker();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.casa32.co.kr/");
        }

        private void label62_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://map.naver.com/v5/search/%EA%B2%BD%EA%B8%B0%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%84%A4%EC%95%85%EB%A9%B4%20%ED%9A%8C%EA%B3%A1%EB%A6%AC%20468/address/14187096.31829476,4538759.41196648,%EA%B2%BD%EA%B8%B0%EB%8F%84%20%EA%B0%80%ED%8F%89%EA%B5%B0%20%EC%84%A4%EC%95%85%EB%A9%B4%20%ED%9A%8C%EA%B3%A1%EB%A6%AC%20468,jibun?c=14186164.7420125,4538759.4119665,14,0,0,0,dh");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        // 첫 번째 예약 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            Form4_2 form4_2 = new Form4_2();


            
            /*int start_month = int.Parse(dateTimePicker1.Text.Split(' ')[1].Substring(0, dateTimePicker1.Text.Split(' ')[1].IndexOf("월")));
            int start_day= int.Parse(dateTimePicker1.Text.Split(' ')[2].Substring(0,dateTimePicker1.Text.Split(' ')[2].IndexOf("일")));
            int end_month = int.Parse(dateTimePicker2.Text.Split(' ')[1].Substring(0, dateTimePicker2.Text.Split(' ')[1].IndexOf("월")));
            int end_day = int.Parse(dateTimePicker2.Text.Split(' ')[2].Substring(0, dateTimePicker2.Text.Split(' ')[1].IndexOf("일")));
            
            StreamReader file = new StreamReader("impo.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string date = line.Split('@')[2];
                int month1 = int.Parse(date.Split(' ')[1].Substring(0, date.Split(' ')[1].IndexOf("월")));
                int day1 = int.Parse(date.Split(' ')[2].Substring(0, date.Split(' ')[2].IndexOf("일")));
                int month2 = int.Parse(date.Split(' ')[1].Substring(0, date.Split(' ')[1].IndexOf("월")));
                int day2 = int.Parse(date.Split(' ')[2].Substring(0, date.Split(' ')[1].IndexOf("일")));

                if (((month1 == start_month) && (start_day <= day1)) && (month2 <= end_month && day2 <= end_day))
                {
                    
                }
                
            }
            file.Close();
            */
            
            // 날짜, 인원 체크 후 방 선택 시 값 저장
            StreamWriter writer_re;
            writer_re = File.AppendText("reserve.txt");
            Form4_1.price = label53.Text;
            Form4_1.room_name = label17.Text;
            writer_re.WriteLine(dateTimePicker1.Text + "@" + dateTimePicker2.Text + "@" + numericUpDown1.Text + "@" + numericUpDown2.Text); 

            writer_re.Close();
            form4_2.ShowDialog();
        }

        // dateTimePicker format 초기 셋팅
        private void initializeDateTimePicker()
        {   /*
            dateTimePicker1.CustomFormat = "yyyy-MM-dd"+dateTimePicker1.Value.ToString(" dddd");
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "yyyy-MM-dd"+dateTimePicker2.Value.ToString(" dddd");
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            */
        }

        // dateTimePicker 출력 확인 >> 근데 txt로 저장할거라 필요 없음
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime dt1 = dateTimePicker1.Value;
            //Console.WriteLine(dt1.ToString("yyyy-MM-dd"+dateTimePicker1.Value.ToString(" dddd")));
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            /*DateTime dt2 = dateTimePicker2.Value;
            Console.WriteLine(dt2.ToString("yyyy-MM-dd" + dateTimePicker2.Value.ToString(" dddd")));*/
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form4_1_Load(object sender, EventArgs e)
        {

        }

        // 두 번째 예약 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            Form4_2 form4_2 = new Form4_2();


            // 날짜, 인원 체크 후 방 선택 시 값 저장
            StreamWriter writer_re;
            writer_re = File.AppendText("reserve.txt");
            Form4_1.price = label23.Text;
            Form4_1.room_name = label28.Text;
            writer_re.WriteLine(dateTimePicker1.Text + "@" + dateTimePicker2.Text + "@" + numericUpDown1.Text + "@" + numericUpDown2.Text);

            writer_re.Close();
            form4_2.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
