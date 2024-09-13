using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassDemo
{
    internal class RollDie
    {
        internal int sideCount = 6;
        
        internal void Description()
        {
            Console.WriteLine("Rolls a" + sideCount + "sided die.");
            Console.WriteLine("Lowest Roll:");
            Console.WriteLine(1);
            Console.WriteLine("Max Roll:");
            Console.WriteLine(sideCount);

           
            

        }

        internal void Rolling()
        {
            Random random = new Random();
            random.Next(1,sideCount);
            Console.WriteLine("your roll is" + random + "!!!");



        }
    }
}
