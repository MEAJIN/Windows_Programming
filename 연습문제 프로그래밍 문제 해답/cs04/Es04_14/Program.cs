﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es04_14
{
    class Vector
    {
        public int[] v;
        //private int ss;

        public Vector()
        {
            v = new int[100];
        }

        public Vector(int size)
        {
            v = new int[size];
        }

        public int this[int index]

        {
            get { return v[index]; }
            set { v[index] = value; }
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void Qsort(int left, int right)
        {
            int pe;
            int i, last;

            if (left >= right) return;
            pe = (left + right) / 2;             //pe = partition element
            Swap(ref v[left], ref v[pe]);
            last = left;
            for (i = left + 1; i <= right; i++)
                if (v[i] < v[left]) Swap(ref v[++last], ref v[i]);
            Swap(ref v[left], ref v[last]);
            Qsort(left, last - 1);
            Qsort(left + 1, last);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Vector v = new Vector(10);

            Console.WriteLine("숫자를 입력하세요(최대 10개). 입력의 끝은 0입니다.");
            for (i = 0; i < 10; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0) break;
                else v[i] = input;
            }

            v.Qsort(0, i - 1);
            for (i = 0; i < 10; i++)
            {
                if (v[i] == 0) break;
                else
                    Console.Write(v[i] + " ");
            }
        }
    }
}
