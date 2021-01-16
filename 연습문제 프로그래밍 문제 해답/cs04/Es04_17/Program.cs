﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es04_17
{
    class Vector
    {
        private int[] v;

        public Vector(int size) // 벡터 클래스의 생성자
        {
            v = new int[size];
        }

        public int this[int index] // 벡터 클래스의 인덱서
        {
            get { return v[index]; }
            set { v[index] = value; }
        }

        public static Vector operator ++(Vector vec) // 벡터에 대한 ++ 연산 정의
        {
            for (int i = 0; i < vec.v.Length; i++)
                vec[i]++;
            return vec;
        }

        public static Vector operator --(Vector vec) // 벡터에 대한 -- 연산 정의
        {
            for (int i = 0; i < vec.v.Length; i++)
                vec[i]--;
            return vec;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(5); // 크기 5의 벡터 생성

            for (int i = 0; i < 5; i++) // 벡터에 10, 11, 12, 13, 14로 값을 초기화
                vector[i] = 10 + i;
            for (int i = 0; i < 5; i++) // 벡터 내용 출력
                Console.Write(vector[i] + " ");
            Console.WriteLine();

            vector++; // 벡터의 ++ 연산 수행
            for (int i = 0; i < 5; i++) // 벡터 내용 출력
                Console.Write(vector[i] + " ");
            Console.WriteLine();

            vector--; // 벡터의 -- 연산 수행
            for (int i = 0; i < 5; i++) // 벡터 내용 출력
                Console.Write(vector[i] + " ");
            Console.WriteLine();
        }
    }
}
