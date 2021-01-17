using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_04_RectContainsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20, 80, 40);
            Point pt1 = new Point(30, 40);
            Point pt2 = new Point(90, 60);
            Console.WriteLine("포함되는가?: {0}", rect.Contains(pt1));
            Console.WriteLine("포함되는가?: {0}", rect.Contains(pt2));
        }
    }
}
