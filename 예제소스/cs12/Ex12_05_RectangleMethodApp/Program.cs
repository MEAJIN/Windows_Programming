using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_05_RectangleMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(10, 20, 60, 30);
            Rectangle rect2 = new Rectangle(60, 30, 50, 60);
            Rectangle rect3 = Rectangle.Intersect(rect1, rect2);
            Console.WriteLine("교차 영역: {0}", rect3.ToString());
            rect3 = Rectangle.Union(rect1, rect2);
            Console.WriteLine("  합 영역: {0}", rect3.ToString());
            rect3.Offset(10, 20);
            Console.WriteLine("이동 영역: {0}", rect3.ToString());
            rect3.Inflate(20, 20);
            Console.WriteLine("확장 영역: {0}", rect3.ToString());
        }
    }
}
