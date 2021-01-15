using System;

namespace _20174627_김혜진
{

    public interface IMp3
    {
        public void play()
        {
            // 플레이
            Console.WriteLine("재생");
        }
        public void stop()
        {
            // 멈춤
            Console.WriteLine("멈춤");
        }

    }

    public interface ICall
    {
        public void call()
        {
            // 전화
            Console.WriteLine("전화");
        }

        public void sms()
        {
            // 문자.
            Console.WriteLine("문자");
        }

    }

    class iphone6 : IMp3, ICall
    {
        // 아이폰10을 두 개의 인터페이스를 상속 받음
        void ICall.call()
        {
            Console.WriteLine("iphone10 전화");
        }

        void ICall.sms()
        {
            Console.WriteLine("iphone10 문자");
        }

        void IMp3.play()
        {
            Console.WriteLine("iphone10 음악 재생");
        }
       
        void IMp3.stop()
        {
            Console.WriteLine("iphone10 음악 멈춤\n");
        }     
      
    }


    class galaxyS7 : IMp3, ICall
    {
        //갤럭시S7을 두 개의 인터페이스를 상속 받음
        void ICall.sms()
        {
            Console.WriteLine("galaxyS7 문자");
        }

        void ICall.call()
        {
            Console.WriteLine("galaxyS7 전화");
        }

        void IMp3.play()
        {
            Console.WriteLine("galaxyS7 음악 재생");
        }
       
        void IMp3.stop()
        {
            Console.WriteLine("galaxyS7 음악 멈춤");
        }
                   
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            iphone6 I = new iphone6();
            galaxyS7 G = new galaxyS7();

            // 권장되는 인터페이스로 캐스팅 업을 이용
            ICall a = I;
            IMp3 b = I;

            a.call();
            a.sms();

            b.play();
            b.stop();

            ICall c = G;
            IMp3 d = G;

            c.call();
            c.sms();

            d.play();
            d.stop();


        }
    }
}