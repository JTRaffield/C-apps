using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_20180816
{
    class Program
    {
        //write program that calculates total sales, county tax, and state tax. Then displays each amount and the combined totals. 
        static void Main(string[] args)
        {
            //Practicing separation of responsibilities, I place each function in a separate method
            double sales = Sales();
            double CountyTax = GetCountyTax(Sales)
            double StateTax = GetStateTax(Sales)
            double TotalTax = GetTotalTax(CountyTax, StateTax)
            DisplayMessage(CountyTax);
            DisplayMessage2(StateTax);
            DisplayMessage3(TotalTax);
            
        }

        static double Sales()
        {
            Console.WriteLine("Enter total sales for month");
            double sales = Convert.ToDouble(Console.ReadLine());
            return sales;
        }

        static double DisplayMessage(double CountyTax)
        {
            Console.WriteLine($"The County Tax is {CountyTax}");
            return CountyTax;
        }

        static double DisplayMessage2(double StateTax)
        {
            Console.WriteLine($"The State Tax is {StateTax}");
            return StateTax;
        }

        static double DisplayMessage3(double TotalTax)
        {
            Console.WriteLine($"The Total Tax is {TotalTax}");
            Console.ReadLine();
            return TotalTax;
        }
        
        static double GetCountyTax(double sales)
        {
            double CountyTax = sales * .02;
            return CountyTax;
        }
        
        static double GetStateTax(double sales)
        {
            double StateTax = sales * .04;
            return StateTax;
        }
        
        static double GetTotalTax(double CountyTax, double StateTax)
        {
            double TotalTax = CountyTax + StateTax;
            return TotalTax;
        }
    }
}
