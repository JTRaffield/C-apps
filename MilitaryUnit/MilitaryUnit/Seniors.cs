using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Seniors: PersonnelClass
    {
        public override void Position()
        {
            Console.WriteLine("Senior Leadership");
        }
        public override void Role()
        {
            Console.WriteLine("Serves as a leader and role model");
        }
        public override void Credit()
        {
            Console.WriteLine("Receives most of the credit");
        }
    }
}
