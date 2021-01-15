﻿using System;
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

            string[,] list = new string[10, 2];
            int index = 0;
            string s;
            bool tag = false;
            do
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("1 : 도서 추가, 2 : 도서 검색, 3 : 도서 리스트 출력, 0 : 종료");
                Console.WriteLine("**************************************");
                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("입력할 도서(책이름, 저자)를 입력하시오. 최대 10개 입력가능 : ex)무라카미 하루키, 상실의 시대");
                            s = Console.ReadLine();
                            list[index, 0] = s.Split(',')[0];
                            list[index++, 1] = s.Split(',')[1];
                            continue;
                        }
                    case 2:
                        {
                            Console.WriteLine("찾고자 하는 도서의 이름이나 저자의 이름을 입력하시오");
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
                    case 3:
                        {
                            Console.WriteLine("전체 도서 목록");
                            for (int i = 0; i < index; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + list[i, 0] + ", " + list[i, 1]);
                            }
                            continue;
                        }
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("숫자를 다시 입력해주세요");
                            continue;
                        }
                }
            } while (action != 0);
            Console.WriteLine("종료");
        }
    }
}