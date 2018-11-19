using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace CarType
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1999, "camry");
            Console.WriteLine($"Your car is a {car.YearModel}, {car.Make}");

            Console.WriteLine("The initial car speed is:");
            Console.WriteLine(car.Speed);

            for (int i = 0; i < 5; i++)
            {
                car.Accelerate();
                Console.WriteLine("The accelerated car speed is:");
                Console.WriteLine(car.Speed);
            }
            for (int i = 0; i < 5; i++)
            {
                car.Brake();
                Console.WriteLine("The decelerated car speed is:");
                Console.WriteLine(car.Speed);
            }
            Console.ReadLine();
        }
    }
}
