using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gFanousLab3Assignment
{
    internal class RollDie
    {
        //Initializing variables to be used in the functions. The sideCount variable can be changed to make the dice roll larger or smaller.
        internal int sideCount = 6;

        //Rolling function handles the actual dice roll.
        internal int Rolling()
        {
            //Calls the built in random class, and assigns it to a variable
            Random random = new Random();

            //Initializes the randomOutput variable and assigns it to the result that the random.Next() will assign it.
            int randOutput = random.Next(1, sideCount + 1);

            //Prints the roll value.

            Console.WriteLine(randOutput + "!!!");

            //will return the value that randOutput gets to be used in the RollScore() function.
            return randOutput;


        }
        
    }
}
