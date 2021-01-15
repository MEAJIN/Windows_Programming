using System;
using System.Runtime.InteropServices;

namespace ConsoleApp4
{
    public delegate void MyEventHandler();
    class Button
    {
        public event MyEventHandler Push;
        public void OnPush()
        {
            if (Push != null)
            {
                Push();

            }
        }
    }

    class EventHandlerClass
    {
        public void MyMethod()
        {
            Console.WriteLine("In the EventHandlerClass.MyMethod ...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            EventHandlerClass obj = new EventHandlerClass();
            button.Push += new MyEventHandler(obj.MyMethod);
            button.OnPush();
        }
    }
}