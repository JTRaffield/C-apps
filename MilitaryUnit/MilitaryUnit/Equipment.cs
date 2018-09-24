using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Equipment
    {
        public void EquipmentType(string typeOfGear)
        {
            Console.WriteLine($"Equipment Type: {typeOfGear}");
        }
        public virtual void Name()
        {
        }
        public virtual void Function()
        {
        }
        public virtual void Operator()
        {
        }
    }
}
