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
                        Console.WriteLine(" ");

                        HandlePayroll empHr2 = new HandlePayroll();
                        Console.WriteLine("How many hours did employee 2 work?");
                        double hours2 = Convert.ToDouble(Console.ReadLine());
                        empHr2.CalculatePayroll2(hours2);
                        Console.WriteLine(" ");

                        HandlePayroll empHr3 = new HandlePayroll();
                        Console.WriteLine("How many hours did employee 3 work?");
                        double hours3 = Convert.ToDouble(Console.ReadLine());
                        empHr3.CalculatePayroll3(hours3);
                        Console.WriteLine(" ");

                        HandlePayroll empHr4 = new HandlePayroll();
                        Console.WriteLine("How many hours did employee 4 work?");
                        double hours4 = Convert.ToDouble(Console.ReadLine());
                        empHr4.CalculatePayroll4(hours4);
                        Console.WriteLine(" ");

                        HandlePayroll empHr5 = new HandlePayroll();
                        Console.WriteLine("How many hours did employee 5 work?");
                        double hours5 = Convert.ToDouble(Console.ReadLine());
                        empHr5.CalculatePayroll5(hours5);

                        HandlePayroll TotalPay = new HandlePayroll();
                        TotalPay.TotalPay();
                        break;
                    default: break;
                }


            } while (result != 0);


            



        }

        // public static void Profit()
        //{
        //    Console.WriteLine("How many small coffees did you sell?"); 
        //    double smallC = Convert.ToDouble(Console.ReadLine());
        //    double smallTotal = smallC * 1.00;

        //    Console.WriteLine("How many medium coffees did you sell?");
        //    double mediumC = Convert.ToDouble(Console.ReadLine());
        //    double mediumTotal = mediumC * 3.00;

        //    Console.WriteLine("How many large coffees did you sell?");
        //    double largeC = Convert.ToDouble(Console.ReadLine());
        //    double largeTotal = largeC * 5.00;

        //    Console.WriteLine("How many egg sandwiches did you sell?");
        //    double eggS = Convert.ToDouble(Console.ReadLine());
        //    double eggTotal = eggS * 5.50;

        //    Console.WriteLine("How many chicken buiscuits did you sell?");
        //    double chickenB = Convert.ToDouble(Console.ReadLine());
        //    double chickenTotal = chickenB * 7.50;

        //    double totalSales = smallTotal + mediumTotal + largeTotal + eggTotal + chickenTotal;

        //    double smallCost = smallC * .10;
        //    double mediumcost = mediumC * .15;
        //    double largeCost = largeC * .20;
        //    double eggSCost = eggS * .95;
        //    double chickenBCost = chickenB * 1.20;
        //    double totalCost = smallCost + mediumcost + largeCost + eggSCost + chickenBCost;

        //    double totalProfit = totalSales - totalCost;

        //    Console.WriteLine($"Your total amount of sales is ${totalSales}");
        //    Console.WriteLine($"The total cost of products is ${totalCost}");
        //    Console.WriteLine($"Your total amount of profit is ${totalProfit}");
        //    Console.ReadLine();
        //}
        
    }
}
