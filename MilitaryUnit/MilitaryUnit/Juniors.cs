using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MilitaryUnit
{
    class Juniors: PersonnelClass
    {
        public override void Position()
        {
            Console.WriteLine("Junior Marine");
        }
        public override void Role()
        {
            Console.WriteLine("Serves as a worker drone");
        }
        public override void Credit()
        {
            Console.WriteLine("receives no credit");
        }
    }
}
