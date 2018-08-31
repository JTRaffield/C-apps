using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsClass;

namespace AnimalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets see what animals you will get in your farm!");

            Animals A = new Animals
            {
                Animal = GetAnimalType(),

                Name = GetAnimalName(),

                Color = GetAnimalColor()
            };

                Console.WriteLine($"Your {A.GetColor()} {A.GetAnimal()} named {A.GetName()} says {A.GetSound()}");
                Console.WriteLine($"{A.GetName()} eats {A.GetFood()} and gives us {A.GetProduct()}.");
                Console.ReadLine();


            Animals B = new Animals
            {
                Animal = GetAnimalType(),

                Name = GetAnimalName(),

                Color = GetAnimalColor()
            };

                Console.WriteLine($"Your {B.GetColor()} {B.GetAnimal()} named {B.GetName()} says {B.GetSound()}");
                Console.WriteLine($"{B.GetName()} eats {B.GetFood()} and gives us {B.GetProduct()}.");
                Console.ReadLine();


            Animals C = new Animals
            {
                Animal = GetAnimalType(),

                Name = GetAnimalName(),

                Color = GetAnimalColor()
            };

                Console.WriteLine($"Your {C.GetColor()} {C.GetAnimal()} named {C.GetName()} says {C.GetSound()}");
                Console.WriteLine($"{C.GetName()} eats {C.GetFood()} and gives us {C.GetProduct()}.");
                Console.ReadLine();


            Animals D = new Animals
            {
                Animal = GetAnimalType(),

                Name = GetAnimalName(),

                Color = GetAnimalColor()
            };

                Console.WriteLine($"Your {D.GetColor()} {D.GetAnimal()} named {D.GetName()} says {D.GetSound()}");
                Console.WriteLine($"{D.GetName()} eats {D.GetFood()} and gives us {D.GetProduct()}.");
                Console.ReadLine();

            Console.WriteLine($"To recap, your farm consists of {A.GetName()} the {A.GetColor()} {A.GetAnimal()}, {B.GetName()} the {B.GetColor()} {B.GetAnimal()}, {C.GetName()} the {C.GetColor()} {C.GetAnimal()}, and {D.GetName()} the {D.GetColor()} {D.GetAnimal()}.");
            Console.ReadLine();

        }

        static string GetAnimalType()
        {
                string input;
            do
            {
                Console.WriteLine("Press 1-4 for an animal or 0 to exit.");
                input = Console.ReadLine();
            } while (!IsNumeric(input) || !IsInRange(Convert.ToInt32(input)));
            if (input == "0") Environment.Exit(0);
                return input;          
        }

        static string GetAnimalName()
        {            
                string name;
            do
            {
                Console.WriteLine("Press 1-4 for a name or 0 to exit.");
                name = Console.ReadLine();
            } while (!IsNumeric(name) || !IsInRange(Convert.ToInt32(name)));
            if (name == "0") Environment.Exit(0);
                return name;
        }

        static string GetAnimalColor()
        {
            string color;
            do
            {
                Console.WriteLine("Press 1-4 for a color or 0 to exit.");
                color = Console.ReadLine();
            } while (!IsNumeric(color) || !IsInRange(Convert.ToInt32(color)));
            if (color == "0") Environment.Exit(0);
            return color;
        }

        static bool IsNumeric(string input)
        {
            return int.TryParse(input, out int test);
        }

        static bool IsInRange(int input)
        {
            return (input >= 0 && input <= 4);
        }
    }
}
