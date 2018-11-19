using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Seniors: PersonnelClass
    {

        //updates the Position based on the object instance
        public override void Position()
        {
            Console.WriteLine("Senior Leadership");
        }

        //updates the Role based on the object instance
        public override void Role()
        {
            Console.WriteLine("Serves as a leader and role model");
        }

        //updates the Credit based on the object instance
        public override void Credit()
        {
            Console.WriteLine("Receives most of the credit");
        }
    }
}
