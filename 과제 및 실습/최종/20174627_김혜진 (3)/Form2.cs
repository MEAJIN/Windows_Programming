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
    public partial class Form2 : Form
    {

        private Form1 main = null;

        public bool logout = false;

        public Form2(Form1 main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        public void login_check()
        {
            StreamReader lcr = new StreamReader("login_ch.txt", Encoding.Default);

            //사용자가 입력한 id, passwd를 사전에 저장
            Dictionary<string, string> list = new Dictionary<string, string>();

            while (lcr.EndOfStream == false) // 파일이 끝날 때까지 반복
            {
                string st = lcr.ReadLine();
                string[] str = st.Split('@'); //@기준으로 나눈다 
                list.Add(str[1], str[2]); 
            }

            foreach (KeyValuePair<string, string> join in list)
            {
                //아이디 있으면
                if (id.Text == join.Key)
                {
                    //비밀번호 일치
                    if (passwd.Text == join.Value)
                    {
                        Form1.Id_name = id.Text;
                        MessageBox.Show("로그인 성공!");

                        main.label4.Text = join.Key + " 님"; //로그인 하면 id + 님으로 뜸 >> 김혜진 님 << 이렇게
                        main.label4.Enabled = false; // 버튼(라벨4) 비활성

                        main.label5.Text = "로그아웃"; // 기존 회원가입 버튼이 로그아웃 텍스트로 바뀜

                        //파일에 로그인 사용자 정보 쓰기 파일 없으면 자동 생성
                        FileStream lus = new FileStream("login_User.txt", FileMode.Append, FileAccess.Write);

                        //파일 읽어옴
                        StreamWriter lusw = new StreamWriter(lus, System.Text.Encoding.UTF8);

                        lusw.WriteLine(id.Text);

                        lusw.Close();
                        lus.Close();

                        return;
                    }

                    //비밀번호가 일치하지 않음
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }

                //아이디 없으면
                else
                {
                    MessageBox.Show("존재하지 않는 아이디 입니다.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Form3 form3 = new Form3();

                    form3.ShowDialog();
                }
            }

            lcr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void label51_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (id.Text == "")
            {
                MessageBox.Show("아이디를 입력해 주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (passwd.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해 주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            else
            {
                login_check();
                this.Close();
            }

            

        }

    }
}
