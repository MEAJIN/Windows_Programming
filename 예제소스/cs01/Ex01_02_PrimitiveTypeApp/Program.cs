using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b; int i = int.MaxValue; uint j = uint.MaxValue;
            double d = double.MaxValue;
            b = (i != 0);
            Console.WriteLine("boolean b = " + b);
            Console.WriteLine("Max value of signed integer = " + i);
            Console.WriteLine("Max value of unsigned integer = " + j);
            Console.WriteLine("Max value of double = " + d);
        }
    }
}
