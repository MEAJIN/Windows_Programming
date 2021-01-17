using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateClass
{
    delegate void SampleDelegate();     // 델리게이트 정의

    class DelegateClass
    {
        public void DelegateMethod()    // 델리게이트할 메소드
        {    
            Console.WriteLine("In the DelegateClass.DelegateMethod ...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass obj = new DelegateClass();
            SampleDelegate sd = new SampleDelegate(obj.DelegateMethod);
            sd();            // invoke obj.DelegateMethod() indirectly.
        }
    }
}
