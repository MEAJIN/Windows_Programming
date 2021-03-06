﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es04_15
{
    class Fraction
    {
        public int numerator;   // 분자
        public int denominator; // 분모

        public Fraction(int num, int deno) // 분수 클래스의 생성자
        {
            numerator = num;
            denominator = deno;
        }

        public static Fraction operator +(Fraction operand1, Fraction operand2) // 분수에 대한 + 연산 정의
        {
            Fraction result = new Fraction(1, 1);
            result.denominator = operand1.denominator * operand2.denominator;
            result.numerator = operand1.numerator * operand2.denominator + operand2.numerator * operand1.denominator;
            return result;
        }

        public static Fraction operator -(Fraction operand1, Fraction operand2) // 분수에 대한 - 연산 정의 
        {
            Fraction result = new Fraction(1, 1);
            result.denominator = operand1.denominator * operand2.denominator;
            result.numerator = operand1.numerator * operand2.denominator - operand2.numerator * operand1.denominator;
            return result;
        }

        public static Fraction operator *(Fraction operand1, Fraction operand2) // 분수에 대한 * 연산 정의
        {
            Fraction result = new Fraction(1, 1);
            result.denominator = operand1.denominator * operand2.denominator;
            result.numerator = operand1.numerator * operand2.numerator;
            return result;
        }

        public static Fraction operator /(Fraction operand1, Fraction operand2) // 분수에 대한 / 연산 정의
        {
            Fraction result = new Fraction(1, 1);
            result.denominator = operand1.denominator * operand2.numerator;
            result.numerator = operand1.numerator * operand2.denominator;
            return result;
        }

        override public string ToString() // 분수를 위한 ToString() 메소드 정의
        {
            return (numerator + "/" + denominator);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction result;
            Fraction operand1 = new Fraction(2, 5); // 분수 3/5
            Fraction operand2 = new Fraction(1, 4); // 분수 1/4

            result = operand1 + operand2;   // operand1 + operand2
            Console.WriteLine(operand1 + " + " + operand2 + " = " + result);    // 결과 출력

            result = operand1 - operand2;   // operand1 - operand2
            Console.WriteLine(operand1 + " - " + operand2 + " = " + result);    // 결과 출력

            result = operand1 * operand2;   // operand1 * operand2
            Console.WriteLine(operand1 + " * " + operand2 + " = " + result);    // 결과 출력

            result = operand1 / operand2;   // operand1 / operand2
            Console.WriteLine(operand1 + " / " + operand2 + " = " + result);	// 결과 출력
        }
    }
}
