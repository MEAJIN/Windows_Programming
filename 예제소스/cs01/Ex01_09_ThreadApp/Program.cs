using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadApp
{
    class Program
    {
        static void ThreadBody()
        {
            Console.WriteLine("In the thread body ...");
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(ThreadBody);
            Thread t = new Thread(ts);
            Console.WriteLine("*** Start of Main");
            t.Start();
            Console.WriteLine("*** End of Main");
        }
    }
}
