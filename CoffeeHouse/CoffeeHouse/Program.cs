using System;

namespace CoffeeHouse
{
    class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter 1 to calculate profit, enter 2 to calculate payroll or enter 0 to end.");
                    result = Convert.ToInt16(Console.ReadLine());



                    switch ((Menu)result)
                    {
                        case Menu.Sales:
                            Sales sales = new Sales();
                            sales.CalculateProfit();
                            break;
                        case Menu.Payroll:
                            HandlePayroll empHr1 = new HandlePayroll();
                            Console.WriteLine("How many hours did employee 1 work?");
                            double hours1 = Convert.ToDouble(Console.ReadLine());
                            empHr1.CalculatePayroll1(hours1);
                            Console.WriteLine();

                           
                            Console.WriteLine("How many hours did employee 2 work?");
                            double hours2 = Convert.ToDouble(Console.ReadLine());
                            empHr1.CalculatePayroll2(hours2);
                            Console.WriteLine();

                            
                            Console.WriteLine("How many hours did employee 3 work?");
                            double hours3 = Convert.ToDouble(Console.ReadLine());
                            empHr1.CalculatePayroll3(hours3);
                            Console.WriteLine();

                           
                            Console.WriteLine("How many hours did employee 4 work?");
                            double hours4 = Convert.ToDouble(Console.ReadLine());
                            empHr1.CalculatePayroll4(hours4);
                            Console.WriteLine();

                           
                            Console.WriteLine("How many hours did employee 5 work?");
                            double hours5 = Convert.ToDouble(Console.ReadLine());
                            empHr1.CalculatePayroll5(hours5);

                            
                            empHr1.TotalPay();
                            break;
                        default: break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (result != 0);
        }
    }
}
