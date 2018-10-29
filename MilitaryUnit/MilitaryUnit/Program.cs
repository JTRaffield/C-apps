using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bryan Shmukatelli");
            Juniors person1 = new Juniors();
            person1.Rank("Lance Corporal");
            person1.Position();
            person1.Role();
            person1.Credit();
            Console.WriteLine();

            Console.WriteLine("James Leadman");
            Seniors person2 = new Seniors();
            person2.Rank("First Sergeant");
            person2.Position();
            person2.Role();
            person2.Credit();
            Console.WriteLine();


            Console.WriteLine("WSMV2");
            Communication wsm1 = new Communication();
            wsm1.Name();
            wsm1.Function();
            wsm1.Operator();
            Console.WriteLine();

            Console.WriteLine("M16");
            Weapon gun1 = new Weapon();
            gun1.Function();
            gun1.Operator();
            Console.WriteLine();

        }
    }
}
