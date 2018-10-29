<<<<<<< HEAD
﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            //int i = 0;
            //Month first = Month.January;
            //while (i < 12)
            //{
            //    Console.WriteLine(first);
            //    i++;
            //    first++;
            //}

            //Date defaultDate = new Date(2015, Month.January, 5);
            //Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2017, Month.July, 4);
            Console.WriteLine(weddingAnniversary);

            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");
            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"New value of copy is still {weddingAnniversaryCopy}");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
=======
﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            //int i = 0;
            //Month first = Month.January;
            //while (i < 12)
            //{
            //    Console.WriteLine(first);
            //    i++;
            //    first++;
            //}

            //Date defaultDate = new Date(2015, Month.January, 5);
            //Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2017, Month.July, 4);
            Console.WriteLine(weddingAnniversary);

            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");
            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"New value of copy is still {weddingAnniversaryCopy}");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
>>>>>>> Upload
