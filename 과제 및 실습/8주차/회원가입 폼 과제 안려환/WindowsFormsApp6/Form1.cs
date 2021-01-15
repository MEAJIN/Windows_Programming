using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    //20154077 안려환
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string name, gender, id, address, hobby, languages, intro;  

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox4.Text)    // 비밀번호확인을 위함입니다.
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show(name + Environment.NewLine 
                    + gender + Environment.NewLine 
                    + id + Environment.NewLine 
                    + "비밀번호: " + textBox3.Text + Environment.NewLine
                    + address + Environment.NewLine
                    + "이메일: " + textBox6.Text + "@" + textBox7.Text + Environment.NewLine
                    + "전화번호: " + comboBox1.Text + "-" + textBox9.Text + "-" 
                    + textBox12.Text + Environment.NewLine
                    + "취미: " + hobby + Environment.NewLine
                    + "구현가능 언어 : " + languages + Environment.NewLine
                    + intro + Environment.NewLine
                    );
                    
            
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e) //여행입니다.
        {
            if (checkBox1.Checked) 
                hobby = hobby + checkBox1.Text + " "; 
            else
                hobby = hobby.Replace(hobby, " ");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//쇼핑입니다.
        {
            if (checkBox2.Checked)
                hobby = hobby + checkBox2.Text + " ";
            else
                hobby = hobby.Replace(hobby, " ");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) // 게임입니다.
        {
            if (checkBox3.Checked)
                hobby = hobby + checkBox3.Text + " ";
            else
                hobby = hobby.Replace(hobby, " ");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)   //각 별다른 주석처리 피하기 위해서 별도의 변수들을 주었습니다.
        {
            address = "주소: " + textBox5.Text; 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)  // 기타취미입니다.
        {
            if (checkBox4.Checked)
                hobby = hobby + checkBox4.Text + " ";
            else
                hobby = hobby.Replace(hobby, " ");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
               gender = "성별: " + radioButton1.Text; 
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            intro = "자기소개: " + textBox11.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  // 언어 추가버튼입니다.
        {
            if (textBox8.Text != "")
            {
                listBox1.Items.Add(textBox8.Text);
                languages = languages + textBox8.Text + " ";
            }
            textBox8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)   //제거버튼입니다.
        {
            if (listBox1.SelectedIndex > -1)
            {
                languages = languages.Replace(listBox1.SelectedItem.ToString() + " ", "");
                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("삭제할 데이터가 없습니다.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            id = "아이디: " + textBox2.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "성별: " + radioButton2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = "이름: " + textBox1.Text;
        }

 

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "직접 입력")
            {
                textBox7.Text = "";
            }

            else {
                textBox7.Text = comboBox2.SelectedItem.ToString();
            
            }
        }
    }
}

