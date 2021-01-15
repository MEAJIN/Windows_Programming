using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201074627_김혜진_
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string get_gender, get_hobby, get_language;

        public Form1()
        {
            InitializeComponent();
            string[] num_data = { "010", "011", "016", "019" }; // 전화번호 앞자리
            string[] email_data = { "naver.com", "gmail.com", "daum.com", "직접 입력" }; // 이메일 뒷자리

            //콤보박스 데이터 초기화 
            comboBox1.Items.AddRange(num_data);
            comboBox2.Items.AddRange(email_data);
        }

        //전화번호 앞자리
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // 성별 남자
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            get_gender = radioButton1.Text;
        }

        // 성별 여자
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            get_gender = radioButton2.Text;
        }

        //이메일
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text == "직접 입력")
            {
                textBox8.Text = "";
            }
            else
            {
                textBox8.Text = comboBox2.SelectedItem.ToString();
            }
        }      

        //리스트 박스에 사용 가능한 언어 추가
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                listBox1.Items.Add(textBox10.Text);
                get_language = get_language + textBox10.Text + " ";
            }
            textBox10.Text = ""; //텍스트 상자 초기화
        }

        //리스트 박스 원소 삭제
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                //선택된 아이템을 제거한 후 언어 문자열에 저장
                get_language = get_language.Replace(listBox1.SelectedItem.ToString() + " ", "");
                //선택된 아이템의 인덱스 제거
                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("삭제할 데이터를 찾을 수 없습니다.\n다시 확인해 주세요.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //여행 checkBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //checkBox1이 체크 되면
                get_hobby = get_hobby + checkBox1.Text + " "; //취미 문자열에 추가
            else
                get_hobby = get_hobby.Replace(get_hobby, " ");
        }

        //쇼핑 checkBox
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) //checkBox2이 체크 되면
                get_hobby = get_hobby + checkBox2.Text + " "; //취미 문자열에 추가
            else
                get_hobby = get_hobby.Replace(get_hobby, " ");
        }

        //게임 checkBox
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) //checkBox3이 체크 되면
                get_hobby = get_hobby + checkBox3.Text + " "; //취미 문자열에 추가
            else
                get_hobby = get_hobby.Replace(get_hobby, " ");
        }

        //기타 checkBox
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) //checkBox4가 체크 되면
                get_hobby = get_hobby + checkBox4.Text + " "; //취미 문자열에 추가
            else
                get_hobby = get_hobby.Replace(get_hobby, " ");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) //checkBox5가 체크 되면
                get_hobby = get_hobby + checkBox5.Text + " "; //취미 문자열에 추가
            else
                get_hobby = get_hobby.Replace(get_hobby, " ");
        }

        //회원가입 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            //비밀번호와 비밀번호 확인 텍스트 불일치 시
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다!\n 다시 입력해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("이름 : " + textBox1.Text + "\n"
                     + "성별 : " + get_gender + "\n"
                     + "아이디 : " + textBox2.Text + "\n"
                     + "비밀번호 : " + textBox3.Text + "\n"
                     + "주소 : " + textBox5.Text + "\n"
                     + "이메일 : " + textBox6.Text + "@" + textBox8.Text + "\n"
                     + "전화번호 : " + comboBox1.Text + "-" + textBox9.Text + "-" + textBox11.Text + "\n"
                     + "취미 : " + get_hobby + "\n"
                     + "구현가능 언어 : " + get_language + "\n"
                     + "자기소개 : " + textBox7.Text
                     , "회원가입"
                     );
            }
        }
    }
}