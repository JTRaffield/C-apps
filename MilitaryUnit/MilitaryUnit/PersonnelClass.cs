﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MilitaryUnit
{
    public class PersonnelClass
    {

        public void Rank(string rankOfPersonnel)
        {
            Console.WriteLine($"Rank of {rankOfPersonnel}");
        }
        public virtual void Position()
        {
            Console.WriteLine("Default Position");
        }
        public virtual void Role()
        {
            Console.WriteLine("Default Role");
        }
        public virtual void Credit()
        {
           
        }
    }
}
