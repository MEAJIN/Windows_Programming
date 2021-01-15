using System;

namespace ConsoleApp4
{
    class Swap<T>
    {
        public T x, y;
        public void swap()
        {
            T temp;
            temp = x; x = y; y = temp;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Swap<int> i = new Swap<int>();
            i.x = 1; i.y = 2;
            Console.WriteLine("x: " + i.x + " y:" + i.y);
            i.swap();
            Console.WriteLine("x: " + i.x + " y:" + i.y);
            Swap<double> d = new Swap<double>();
            d.x = 1.0; d.y = 2.0;
            Console.WriteLine("x: " + d.x + " y:" + d.y);
            d.swap();
            Console.WriteLine("x: " + d.x + " y:" + d.y);
        }
    }
}