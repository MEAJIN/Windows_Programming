using System;

namespace ConsoleApp7
{
    class Even
    {
        public int e;
        public Even(int a)
        {
            this.e = a;
        }
        public static Even operator ++(Even x1)
        {
            x1.e += 2;
            return x1;
        }
        public static Even operator --(Even x1)
        {
            x1.e -= 2;
            return x1;
        }
        public void printEven() { Console.WriteLine(e); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Even e = new Even(4); e.printEven();
            ++e; e.printEven();
            --e; e.printEven();
        }
    }
}