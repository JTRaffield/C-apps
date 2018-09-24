using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Weapon: Equipment
    {
        public override void Function()
        {
            Console.WriteLine("Used to quickly send metal rounds to the enemy");
        }
        public override void Operator()
        {
            Console.WriteLine("Operated by all marines to some extent");
        }
    }
}
