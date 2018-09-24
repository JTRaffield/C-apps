using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MilitaryUnit
{
    class PersonnelClass
    {
        public void Rank(string rankOfPersonnel)
        {
            Console.WriteLine($"Rank of {rankOfPersonnel}");
        }
        public virtual void Position()
        {
            
        }
        public virtual void Role()
        {
            
        }
        public virtual void Credit()
        {
           
        }
    }
}
