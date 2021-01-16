﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es04_18
{
    class Date
    {
        private int day, month, year;
        public Date(int mm, int dd, int yy)     // 생성자
        {
            day = dd;
            month = mm;
            year = yy;
        }

        public static bool operator ==(Date d1, Date d2) // 날짜에 대한 == 연산 정의
        {
            if (d1.year == d2.year && d1.month == d2.month && d1.day == d2.day)
                return true;
            else return false;
        }

        public static bool operator !=(Date d1, Date d2) // 날짜에 대한 != 연산 정의
        {
            if (d1.year == d2.year && d1.month == d2.month && d1.day == d2.day)
                return false;
            else return true;
        }

        public static bool operator >(Date d1, Date d2) // 날짜에 대한 > 연산 정의
        {
            if (d1.year > d2.year)
                return true;
            else if (d1.year == d2.year && d1.month > d2.month)
                return true;
            else if (d1.year == d2.year && d1.month == d2.month && d1.day > d2.day)
                return true;
            else return false;
        }

        public static bool operator <(Date d1, Date d2) // 날짜에 대한 < 연산 정의
        {
            if (d1.year < d2.year)
                return true;
            else if (d1.year == d2.year && d1.month < d2.month)
                return true;
            else if (d1.year == d2.year && d1.month == d2.month && d1.day < d2.day)
                return true;
            else return false;
        }

        public static Date operator ++(Date d) // 날짜에 대한 ++ 연산 정의
        {
            d.day++;
            if (d.day > DateTime.DaysInMonth(d.year, d.month))
            {
                d.day = 1;
                if (d.month == 12)
                {
                    d.month = 1;
                    d.year++;
                }
                else d.month++;
            }
            return d;
        }

        public static Date operator --(Date d) // 날짜에 대한 -- 연산 정의
        {
            if (d.day == 1)
            {
                if (d.month == 1)
                    d.month = 12;
                else d.month--;
                d.day = DateTime.DaysInMonth(d.year, d.month);
            }
            else d.day--;
            return d;
        }

        public static Date operator +(Date d, int n) // 날짜에 대한 + 연산 정의
        {
            d.day += n;
            while (d.day > DateTime.DaysInMonth(d.year, d.month))
            {
                d.day = d.day - DateTime.DaysInMonth(d.year, d.month);
                if (d.month == 12)
                {
                    d.month = 1;
                    d.year++;
                }
                else d.month++;
            }
            return d;
        }

        public static Date operator -(Date d, int n) // 날짜에 대한 - 연산 정의
        {
            d.day -= n;
            while (d.day <= 0)
            {
                if (d.month == 1)
                    d.month = 12;
                else d.month--;
                d.day = DateTime.DaysInMonth(d.year, d.month) + d.day;
            }
            return d;
        }

        override public string ToString()  // mm/dd/yy
        {
            return string.Format("{0,2}/{1,2}/{2,2}", month, day, year);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(7, 31, 2007);
            Date d2 = new Date(12, 1, 2007);

            Console.WriteLine("d1 == d2 ? " + (d1 == d2));
            Console.WriteLine("d1 > d2 ? " + (d1 > d2));
            Console.WriteLine("d1 < d2 ? " + (d1 < d2));
            d1++;
            Console.WriteLine("d1++ : " + d1);
            d2--;
            Console.WriteLine("d2-- : " + d2);
            d2 = d2 + 30;
            Console.WriteLine("d2+30 : " + d2);
            d1 = d1 - 30;
            Console.WriteLine("d1-30 : " + d1);
        }
    }
}
