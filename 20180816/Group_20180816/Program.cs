using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_20180816
{
    class Program
    {
        static void Main(string[] args)
        {
            double sales = Sales();
            double CountyTax = sales * .02;
            double StateTax = sales * .04;
            double TotalTax = CountyTax + StateTax;
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
    }
}
