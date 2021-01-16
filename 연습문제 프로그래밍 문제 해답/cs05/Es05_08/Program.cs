﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es05_08
{
    abstract class Figure
    {
        public abstract void Area();  //넓이를 구하는 메소드
        public abstract void Girth(); //둘레를 구하는 메소드
        public abstract void Draw();  //도형을 그리는 메소드
    }

    class Squ : Figure
    {
        private int garo, sero;

        public int Garo
        {
            set { garo = value; }
        }
        public int Sero
        {
            set { sero = value; }
        }

        public override void Area()
        {
            int nulbi;
            nulbi = garo * sero;
            Console.Write("넓이: ");
            Console.WriteLine("{0}", nulbi);
        }

        public override void Girth()
        {
            int dulle;
            dulle = 2 * (garo + sero);
            Console.Write("둘레: ");
            Console.WriteLine("{0}", dulle);
        }

        public override void Draw()
        {
            Console.WriteLine("{0}", "== 사각형 ==");
        }
    }

    class Cir : Figure
    {
        private double bangirm;

        public double Bangirm
        {
            set { bangirm = value; }
        }

        public override void Area()
        {
            double nulbi;
            nulbi = 3.14 * (bangirm * bangirm);
            Console.Write("넓이: ");
            Console.WriteLine("{0}", nulbi);
        }

        public override void Girth()
        {
            double dulle;
            dulle = 2 * 3.14 * bangirm;
            Console.Write("둘레: ");
            Console.WriteLine("{0}", dulle);
        }

        public override void Draw()
        {
            Console.WriteLine("{0}", "== 원 ==");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("가로:");
            int garo = int.Parse(Console.ReadLine());

            Console.Write("세로:");
            int sero = int.Parse(Console.ReadLine());

            Console.Write("반지름:");
            int bangirm = int.Parse(Console.ReadLine());

            Squ x = new Squ();
            Cir y = new Cir();

            x.Garo = garo;
            x.Sero = sero;
            y.Bangirm = bangirm;


            x.Area();
            x.Girth();
            x.Draw(); // 나중에 추가

            y.Area();
            y.Girth();
            y.Draw(); // 나중에 추가        }
        }
}
