using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //create a program that displays information to the user
        /*static void Main(string[] args)
        {
            Console.WriteLine("Johnathan");
            Console.WriteLine("300 Gonzalez Blvd, Camp Lejeune, NC, 28547");
            Console.WriteLine("903-376-1144");
            Console.WriteLine("Corporal");
        }*/


        //create a program that takes a number of sales from the user and calculates the amount of profit from the sales
        /*static void Main()
        {
            Console.WriteLine("Enter the projected amount of sales.");
            double sales = Convert.ToDouble (Console.ReadLine());
            double P = sales * .23;
            Console.WriteLine($"Projected amount of profit is ${P}.");
        }*/

        //write a program that takes the prices of items and finds the subtotal, and the total price of all the itmes with a 6% sales
        static void Main()
        {
            Console.WriteLine("Enter Price of first item.");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Price of second item.");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Price of third item.");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Price of fourth item.");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Price of fifth item.");
            double e = Convert.ToDouble(Console.ReadLine());

            double Subtotal = a + b + c + d + e;
            double tax = Subtotal * .06;
            double final = Subtotal + tax;

            Console.WriteLine($"Your Subtotal is ${Subtotal}.");
            Console.WriteLine($"Your Sales tax is ${tax}.");
            Console.WriteLine($"Your final total is ${final}.");


            //This way the subtotal is converted to a string at the same time as it is placed in the sentence. Doing this places the currency indicator (Dollar, Pound, Euro, Yen) automatically.

            //Console.WriteLine($"Subtotal of sales is {String.Format("{0:C}", Subtotal)}");

        }


    } 
}
