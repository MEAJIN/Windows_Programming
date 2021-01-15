using System;
using System.Linq;

namespace ConsoleApp1
{

    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
           

            Car[] cars =
            {
                new Car(){Cost = 56, MaxSpeed = 120},
                new Car(){Cost = 70, MaxSpeed = 150},
                new Car(){Cost = 45, MaxSpeed = 180},
                new Car(){Cost = 32, MaxSpeed = 200},
                new Car(){Cost = 82, MaxSpeed = 280}
            };



            // 1번 문제
            /* var selected = from Car in cars
                            where Car.Cost >= 50 & Car.MaxSpeed >= 150
                            orderby Car.Cost
                            select new
                            {
                                cost = Car.Cost,
                                maxSpeed = Car.MaxSpeed
                            };

             foreach (var Car in selected)
                 Console.WriteLine("{0}, {1}", Car.cost, Car.maxSpeed); */

            // 2번 문제
            /* var selected = from Car in cars
                            where Car.MaxSpeed <=200 & Car.MaxSpeed != 150
                            orderby Car.Cost
                            select new
                            {
                                cost = Car.Cost,
                                
                            };

            foreach (var Car in selected)
                Console.WriteLine("{0}", Car.cost); */

            // 또는

            var Selected = from Car in cars
                           where Car.Cost < 60
                           orderby Car.Cost
                           select new
                           {
                               cost = Car.Cost,

                           };

            foreach (var Car in Selected)
                Console.WriteLine("{0}", Car.cost);

            /* var selected = cars.Where(c => c.Cost < 60).OrderBy(c => c.Cost);

            foreach (var Car in selected)
                 Console.WriteLine(Car.Cost); */


            /*   from: 어떤 데이터에서 찾을 것인가
                 where: 어떤 조건으로 찾을 것인가
                 order by : 어떤 항목을 기준으로 정렬할 것인가
                 select : 어떤 항목을 추출할 것인가 
            */


        }
    }
}

