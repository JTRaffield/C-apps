using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse
{
    public enum Menu
    {
        Sales = 1,
        Payroll = 2
    }

    public struct Sales
    {
        public void CalculateProfit()
        {
            Console.WriteLine("How many small coffees did you sell?");
            double smallC = Convert.ToDouble(Console.ReadLine());
            double smallTotal = smallC * 1.00;

            Console.WriteLine("How many medium coffees did you sell?");
            double mediumC = Convert.ToDouble(Console.ReadLine());
            double mediumTotal = mediumC * 3.00;

            Console.WriteLine("How many large coffees did you sell?");
            double largeC = Convert.ToDouble(Console.ReadLine());
            double largeTotal = largeC * 5.00;

            Console.WriteLine("How many egg sandwiches did you sell?");
            double eggS = Convert.ToDouble(Console.ReadLine());
            double eggTotal = eggS * 5.50;

            Console.WriteLine("How many chicken buiscuits did you sell?");
            double chickenB = Convert.ToDouble(Console.ReadLine());
            double chickenTotal = chickenB * 7.50;

            double totalSales = smallTotal + mediumTotal + largeTotal + eggTotal + chickenTotal;

            double smallCost = smallC * .10;
            double mediumcost = mediumC * .15;
            double largeCost = largeC * .20;
            double eggSCost = eggS * .95;
            double chickenBCost = chickenB * 1.20;
            double totalCost = smallCost + mediumcost + largeCost + eggSCost + chickenBCost;

            double totalProfit = totalSales - totalCost;

            Console.WriteLine($"Your total amount of sales is ${totalSales}");
            Console.WriteLine($"The total cost of products is ${totalCost}");
            Console.WriteLine($"Your total amount of profit is ${totalProfit}");
            Console.ReadLine();
        }
    }

    public struct HandlePayroll
    {
        public double TotalPay1, TotalPay2, TotalPay3, TotalPay4, TotalPay5;
        public double overTimePay1, overTimePay2, overTimePay3, overTimePay4, overTimePay5;

       

        public double CalculatePayroll1(double hours1)
        {
            double diff1 = 0;
            if (hours1 > 40)
            {
                diff1 = hours1 - 40;
            }
             double totalPay1 = ((hours1 - diff1) * 12.50) + (diff1 * 18.75);
            this.overTimePay1 = diff1 * 18.75;
            Console.WriteLine($"Employee 1 paycheck is ${totalPay1}.");
            Console.WriteLine($"Employee 1 overtime pay is ${this.overTimePay1}");
            this.TotalPay1 = totalPay1;
            return TotalPay1;
        }

        public double CalculatePayroll2(double hours2)
        {
            double diff2 = 0;
            if (hours2 > 40)
            {
                diff2 = hours2 - 40;
            }
            double totalPay2 = ((hours2 - diff2) * 12.50) + (diff2 * 18.75);
            this.overTimePay2 = diff2 * 18.75;
            Console.WriteLine($"Employee 2 paycheck is ${totalPay2}.");
            Console.WriteLine($"Employee 2 overtime pay is ${this.overTimePay2}");
            this.TotalPay2 = totalPay2;
            return TotalPay2;
        }

        public double CalculatePayroll3(double hours3)
        {
            double diff3 = 0;
            if (hours3 > 40)
            {
                diff3 = hours3 - 40;
            }
            double totalPay3 = ((hours3 - diff3) * 12.50) + (diff3 * 18.75);
            this.overTimePay3 = diff3 * 18.75;
            Console.WriteLine($"Employee 3 paycheck is ${totalPay3}.");
            Console.WriteLine($"Employee 3 overtime pay is ${this.overTimePay3}");
            this.TotalPay3 = totalPay3;
            return TotalPay3;
        }

        public double CalculatePayroll4(double hours4)
        {
            double diff4 = 0;
            if (hours4 > 40)
            {
                diff4 = hours4 - 40;
            }
            double totalPay4 = ((hours4 - diff4) * 12.50) + (diff4 * 18.75);
            this.overTimePay4 = diff4 * 18.75;
            Console.WriteLine($"Employee 4 paycheck is ${totalPay4}.");
            Console.WriteLine($"Employee 4 overtime pay is ${this.overTimePay4}");
            this.TotalPay4 = totalPay4;
            return TotalPay4;
        }

        public double CalculatePayroll5(double hours5)
        {
            double diff5 = 0;
            if (hours5 > 40)
            {
                diff5 = hours5 - 40;
            }
            double totalPay5 = ((hours5 - diff5) * 12.50) + (diff5 * 18.75);
            this.overTimePay5 = diff5 * 18.75;
            Console.WriteLine($"Employee 5 paycheck is ${totalPay5}.");
            Console.WriteLine($"Employee 5 overtime pay is ${this.overTimePay5}");
            this.TotalPay5 = totalPay5;
            return TotalPay5;
        }

        //TODO: fix TotalPay_ from reseting to 0 after leaving the CalculatePayroll method in struct so i can get TotalPay() to work
        public void TotalPay()
        {
            double grandTotal = this.TotalPay1 + this.TotalPay2 + this.TotalPay3 + this.TotalPay4 + this.TotalPay5;
            Console.WriteLine($"The combined pay for this week is ${grandTotal}");
        }
    }
}
