using System;

namespace _20174627_김혜진_1주차_과제
{
    class Program
    {
        static void Main()
        {
            //입력한 데이터를 넣을 정보들과 총점,평균,석차를 저장할 배열을 만듭니다.
            string[,] arr = new string[3, 4];
            int[] total = new int[3];
            double[] avg = new double[3];
            int[] grade = new int[3] { 3, 3, 3 };


            for (int i = 0; i < 3; i++)
            {
                //입력을 받고 split을 통해서 특정 문자기준으로 잘라서 배열에 저장시킵니다.
                int tt = 0;
                Console.WriteLine("성적을 입력하세요. 단, 각 세 번씩 다르게 입력해 주세요! - 예) 홍길동,75,90,80");
                string tmp = Console.ReadLine();
                string[] pp = tmp.Split(',');

                //이름 저장을 하는곳입니다.
                arr[i, 0] = pp[0];


                //점수를 저장합니다.
                for (int k = 0; k < 3; k++)
                {
                    tt += int.Parse(pp[k + 1]);
                    arr[i, k + 1] = pp[k + 1];
                }

                //총점을 저장합니다.
                total[i] = tt;
                //평균을 저장합니다.
                avg[i] = (double)tt / 3.0;
            }

            //석차를 구합니다. 석차의 배열을 3으로 만들어놓고 상대보다 높다면 -1씩 해줍니다.
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (total[i] > total[k])
                    {
                        grade[i] -= 1;
                    }
                }
            }

            //출력을 해줍니다.
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("이름: " + arr[i, 0] + " 국어: " + arr[i, 1] + " 영어: " + arr[i, 2] + " 수학: " + arr[i, 3] + " 총점: " + total[i] + " 평균: " + avg[i] + " 석차: " + grade[i]);
            }
        }
    }
}