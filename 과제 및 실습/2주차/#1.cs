﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20174627_김혜진_2주차
{
    class Program
    {
        private void Main(string[] args)
        {
            int number;
            int[] answer = new int[9];

            Console.Write("단을 입력하세요 : ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                answer[i - 1] = number * i;
            }

            foreach (int result in answer)
            {
                Console.WriteLine(number + " * " + (result / number) + " = " + result);
            }
        }
    }
}
