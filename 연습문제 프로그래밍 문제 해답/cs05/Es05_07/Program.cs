﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es05_07
{
    class Temperature
    {
        double degree;

        public Temperature(double degree) // 생성자
        {
            this.degree = degree;
        }

        public double Degree // 프로퍼티
        {
            get { return degree; }
        }
    }

    class Celsius : Temperature
    {
        public Celsius(double t) : base(t) { } // 생성자

        public static implicit operator Celsius(double d)  // double을 Celsius로
        {
            Celsius c = new Celsius(d);
            return c;
        }
        public static explicit operator Celsius(Fahrenheit f) // Fahrenheit를 Celsius로
        {
            return f.Degree * 5 / 9 - 32;
        }
        public static explicit operator double(Celsius c) // Celsius를 double로
        {
            return c.Degree;
        }
    }

    class Fahrenheit : Temperature
    {
        public Fahrenheit(double t) : base(t) { } // 생성자

        public static implicit operator Fahrenheit(double d)  // double을 Fahrenheit로
        {
            Fahrenheit f = new Fahrenheit(d);
            return f;
        }

        public static explicit operator Fahrenheit(Celsius c) // Celsius를 Fahrenheit로
        {
            return c.Degree * 9 / 5 + 32;
        }

        public static explicit operator double(Fahrenheit f) // Fahrenheit을 double로
        {
            return f.Degree;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius(27.6);
            Fahrenheit f;
            f = (Fahrenheit)c; // Celsius를 Fahrenheit로
            Console.WriteLine("{0} Celsius = {1} Frahrenheit", c.Degree, f.Degree);

            f = 88.1; // double을 Fahrenheit로
            c = (Celsius)f; // Fahrenheit를 Celsius로
            Console.WriteLine("{0} Frahrenheit = {1} Celsius", f.Degree, c.Degree);
        }
    }
}
