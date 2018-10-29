using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Communication: Equipment
    {
        public override void Name()
        {
            Console.WriteLine("Wide Area Network Service Module version 2");
        }
        public override void Function()
        {
            Console.WriteLine("Used to connect ultiple LANs together in the field");
        }
        public override void Operator()
        {
            Console.WriteLine("Operated by a network administrator");
        }
    }
}
