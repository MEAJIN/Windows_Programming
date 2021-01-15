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

namespace _20174627_김혜진
{
    public partial class Form3 : Form
    {
        private static string re_iD;
        private static string re_name;
        private static string email;
        private static string phonenum;

        public static string ID { get { return re_iD; } set { re_iD = value; } }
        public static string re_Name { get { return re_name; } set { re_name = value; } }
        public static string Email { get { return email; } set { email = value; } }
        public static string Ponenum { get { return phonenum; } set { phonenum = value; } }

        public Form3()
        {
            InitializeComponent();
        }

        //아이디 중복 검사를 위한 변수
        bool id_ch = false;      

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        // 회원가입 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            //이름 : 2~5자이내
            if (this.name.Text.Length < 2 || this.name.TextLength > 10)
            {
                MessageBox.Show("이름은 2~5자 이내로 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.name.Focus();
                return;
            }

            
            //아이디 중복 검사
            if (id_ch == false)
            {
                MessageBox.Show("아이디 중복 검사를 해주세요.");
                this.Confirm_ch.Focus();

                return;
            }
            
            else
            {
               
                StreamWriter writer_id_pw;
                writer_id_pw = File.AppendText("login_ch.txt");

                writer_id_pw.WriteLine(name.Text + "@" + id.Text + "@" + passwd.Text + "@" 
                                        + year.Text + month.Text + day.Text + "@" + email1.Text + "@" + phone.Text); // 아이디 중복 방지

                writer_id_pw.Close();   
                
            }

            //비밀번호
            if (this.passwd.TextLength < 3 || this.passwd.TextLength > 10)
            {
                MessageBox.Show("비밀번호는 3~10자 이내로 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.passwd.Focus();
                return;

            }

            if (this.passwd.Text != this.Confirm.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.passwd.Focus();
                return;
            }

                MessageBox.Show("회원가입이 완료 되었습니다!");

            this.Close();
            
            //Form1 fr1 = new Form1();
            //fr1.Show();

        }


        //이름
        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        //아이디
        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        //비번
        private void passwd_TextChanged(object sender, EventArgs e)
        {

        }

        //비번확인
        private void Confirm_TextChanged(object sender, EventArgs e)
        {

        }

        //년 
        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //월
        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //일
        private void day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //이메일
        private void email1_TextChanged(object sender, EventArgs e)
        {

        }

        //연락처
        private void phone_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        // 중복확인 all 
        private bool id_Ch()
        {
            StreamReader sr = new StreamReader("login_User.txt", Encoding.Default);
            List<string> id_list = new List<string>();

            while (sr.EndOfStream == false) // 파일이 끝날 때까지 반복
            {
                string s = sr.ReadLine();
                string[] str = s.Split('\n');
                id_list.Add(str[0]);
            }

            foreach (string s in id_list)
            {
                if (id.Text == s)
                {
                    return true;
                }
            }

            sr.Close();
            return false;
        }
        

        //중복확인 클릭
        private void Confirm_ch_Click(object sender, EventArgs e)
        {

            //미입력
            if (String.IsNullOrWhiteSpace(id.Text))
            {
                MessageBox.Show("아이디를 입력해 주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (id_Ch()) 
                {
                    MessageBox.Show("이미 존재하는 아이디 입니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("사용가능한 아이디 입니다.");
                }

                id_ch = true;

            }

           
        }        
 
        // 취소
        private void cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소 하시겠습니까?");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    
