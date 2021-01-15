using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 김혜진_20174627
{
    
    public partial class Form1 : Form
    {
        string OP1 = "0", OP2 = "0"; //피연산자
        string tmp;

        int result = 0; //연산 결과
        int m_result = 0;

        char oper;

        bool OPerator_CHk = false; //연산자가 클릭 체크
        bool Result_CH = false; //계산 체크
        bool Number_CH = false; //숫자 클릭 체크

        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;

            // 소수점 버튼
            if (b.Text == ".")
            {
                // 소수점은 한 번만 누를 수 있음 > 여러번 눌러도 하나만 출력
                if (label1.Text.Contains("."))
                    return;
                else
                    label1.Text += b.Text;
            }

            //숫자 버튼
            else
            {
                if (OPerator_CHk == false) //연산자가 없을 경우
                {
                    OP1 = b.Text;  //피연산자1에 숫자 저장
                    label1.Text = OP1; //레이블에 숫자 출력
                    Number_CH = false;
                }

                if (Number_CH == true)  //연산자가 있을 경우
                {
                    OP2 = b.Text; //피연산자 2에 숫자 저장
                    label1.Text = OP2; //레이블에 숫자 출력
                }

            }
            tmp += label1.Text;
        }

        // + 버튼
        private void button14_Click(object sender, EventArgs e)
        {
            oper = '+';
            tmp += oper;
            
            if (Number_CH == true)
            {
                label3.Text += (OP2 + oper);
               
                //바로 계산해서 label3에 출력 해주기 
                int a = int.Parse(OP1);
                int b = int.Parse(OP2);

                m_result = a + b;
                label1.Text = m_result.ToString();
                OP1 = m_result.ToString();

                OP2 = "0"; //OP2 0으로 초기화

            }

            else // 연산자가 한번도 클릭되지 않았을 경우
            {
                label3.Text = (OP1 + oper); //label3에 첫번째 클릭한 숫자 (OP1)과 연산자 oper를 출력
                label1.Text = "0"; // label1 지워주기
                Number_CH = true;
            }

            OPerator_CHk = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            oper = '-';
            tmp += oper;
            if (Number_CH == true)
            {
                label3.Text += (OP2 + oper);
                
                //바로 계산해서 label3에 출력 해주기 
                int a = int.Parse(OP1);
                int b = int.Parse(OP2);

                m_result = a - b;
                label1.Text = m_result.ToString();
                OP1 = m_result.ToString();
                OP2 = "0"; //OP2 0으로 초기화
            }

            else //연산자가 한번도 클릭되지 않았을 경우
            {
                label3.Text = (OP1 + oper); //label3에 첫번째 클릭한 숫자 (OP1)과 연산자 oper를 출력
                label1.Text = "0"; //label1 지워주기
                Number_CH = true;
            }
            
            OPerator_CHk = true;
        }


        private void button16_Click(object sender, EventArgs e)
        {
            oper = 'x';
            tmp += oper;
            if (Number_CH == true)
            {
                label3.Text += (OP2 + oper);
                
                //바로 계산해서 label3에 출력 해주기 
                int a = int.Parse(OP1);
                int b = int.Parse(OP2);

                m_result = a * b;
                label1.Text = m_result.ToString();
                OP1 = m_result.ToString();
                OP2 = "0"; //OP2 0으로 초기화
            }

            else //연산자가 한번도 클릭되지 않았을 경우
            {
                label3.Text = (OP1 + oper); //label3에 첫번째 클릭한 숫자 (OP1)과 연산자 oper를 출력
                label1.Text = "0"; //label1 지워주기
                Number_CH = true;
            }
            
            OPerator_CHk = true;
        }

        
        private void button20_Click(object sender, EventArgs e)
        {
            oper = '/';
            tmp += oper;
            
            if (Number_CH == true)
            {
                label3.Text += (OP2 + oper);
               
                //바로 계산해서 label3에 출력 해주기              
                int a = int.Parse(OP1);
                int b = int.Parse(OP2);

                m_result = a / b;
                label1.Text = m_result.ToString();
               
                OP1 = m_result.ToString();
                OP2 = "0"; //OP2 0으로 초기화              
            }

            else //연산자가 한번도 클릭되지 않았을 경우
            {
                label3.Text = (OP1 + oper); //label3에 첫번째 클릭한 숫자 (OP1)과 연산자 oper를 출력
                label1.Text = "0"; //label1 지워주기
                Number_CH = true;
            
            }
            OPerator_CHk = true;
        }


        private void result_Click(object sender, EventArgs e)
        {
            /*
             * =을 누르면 labe3에 있던 식(OP1 + op)이 사라지고 
             * label1에 계산 결과(result) 가 출력
             * listBox1에 전체 식(OP1 + op + OP2) 기록을 남김
             * OP1, OP2 초기화
            */
            
            int a = int.Parse(OP1);
            int b = int.Parse(OP2);
            label3.Text = string.Empty;


            // 예외 처리
            try
            {
                switch (oper)
                {
                    case '+':
                        result = a + b;
                        break;

                    case '-':
                        result = a - b;
                        break;

                    case 'x':
                        result = a * b;
                        break;

                    case '/':
                        result = a / b;
                        break;
                }

                label1.Text = result.ToString();
                OP1 = result.ToString();

                listBox1.Items.Add(tmp); //기록

                result = 0;
                label3.Text = string.Empty;

                //OP2 = "0";
                tmp = string.Empty;
                Result_CH = true;
                Number_CH = false;
            }


            catch (Exception ex) // 0으로 나누려고 할 경우 발생
            {
                label1.Text = "0으로 나눌 수 없습니다!";
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button19_Click(object sender, EventArgs e)
        {

            /*
             * backspace
             * op가 없으면 OP1 지우기
             * 있으면 OP2 지우기
            */


            if (label1.Text.Length != 0)
            {
                if (Result_CH == false)
                {
                    OP1 = OP1.Substring(0, OP1.Length - 1);
                    label1.Text = OP1;
                }

                else
                {
                    OP2 = OP2.Substring(0, OP2.Length - 1);
                    label1.Text = OP2;
                }
                tmp = tmp.Substring(0, tmp.Length - 1);
            }
        }


        private void button18_Click(object sender, EventArgs e)
        {

            /*
             * C버튼 누를 경우 모두 초기화
             * 기록은 남아있음
            */

            label1.Text = string.Empty;
            label3.Text = string.Empty;
            OP1 = string.Empty;
            OP2 = string.Empty;
            tmp = string.Empty;
            Result_CH = false;
            Number_CH = false;
            OPerator_CHk = false;
        }


        private void button11_Click(object sender, EventArgs e)
        {

            /*
             * +/- 버튼 누를 경우 실행
             */

            int a = int.Parse(label1.Text) * (-1);
            label1.Text = a.ToString();
            OP1 = a.ToString();
        }


        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}