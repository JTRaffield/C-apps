using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MilitaryUnit
{
    class Juniors: PersonnelClass
    {

        //updates the Position based on the object instance
        public override void Position()
        {
            Console.WriteLine("Junior Marine");
        }

        //updates the Role based on the object instance
        public override void Role()
        {
            Console.WriteLine("Serves as a worker drone");
        }

        //updates the Credit based on the object instance
        public override void Credit()
        {
            Console.WriteLine("receives little credit");
        }
    }
}
