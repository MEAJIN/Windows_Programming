using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20174627_김혜진_2주차
{
    class Program3
    {
        static void Main()
        {
            int action;

            string[,] list = new string[4, 4];
            int index = 0;
            string s;
            bool tag = false;
            do
            {
                Console.WriteLine("메뉴");
                Console.WriteLine("-------------");
                Console.WriteLine("1.   출력");
                Console.WriteLine("2.   입력");
                Console.WriteLine("3.   검색");
                Console.WriteLine("4.   종료");
                Console.WriteLine("-------------");
                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("전체 과일 목록");
                            for (int i = 0; i < index; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + list[i, 0] + ", " + list[i, 1]);
                            }
                            continue;


                        }
                    case 2:
                        {

                            Console.WriteLine("새로운 과일명, 단가, 수량을 입력해주세요 ex) 포도, 1500, 수량 ");
                            s = Console.ReadLine();
                            list[index, 0] = s.Split(',')[0];
                            list[index++, 1] = s.Split(',')[1];
                            continue;
                        }
                    case 3:
                        {
                            Console.WriteLine("찾고자 하는 과일을 검색하세요");
                            s = Console.ReadLine();
                            for (int i = 0; i < index; i++)
                            {
                                tag = s.Equals(list[i, 0]) || s.Equals(list[i, 1]);
                                if (tag == true)
                                {
                                    Console.WriteLine("찾고자 하는 도서가 존재함");
                                    break;
                                }
                            }

                            if (tag == false)
                            {
                                Console.WriteLine("찾고자 하는 도서가 존재하지 않음");
                            }
                            continue;

                        }
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (action != 0);
            Console.WriteLine("종료");
        }
    }
}