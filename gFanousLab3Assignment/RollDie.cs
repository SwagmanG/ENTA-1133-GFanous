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
        internal int dieScoreTotal = 0;
        internal void Description()
        {   //this is the description of the dice roller, telling you what sided die it will roll, and what the max roll is.
            Console.WriteLine("Rolls a");
            Console.WriteLine(sideCount);
            Console.WriteLine("sided die.");
            Console.WriteLine("Lowest Roll:");
            Console.WriteLine(1);
            Console.WriteLine("Max Roll:");
            Console.WriteLine(sideCount);




        }

        //Rolling function handles the actual dice roll.
        internal int Rolling()
        {
            //Calls the built in random class, and assigns it to a variable
            Random random = new Random();

            //Initializes the randomOutput variable and assigns it to the result that the random.Next() will assign it.
            int randOutput = random.Next(1, sideCount + 1);

            //Prints the roll value.
            Console.WriteLine("your roll is...");
            Console.WriteLine(randOutput + "!!!");

            //will return the value that randOutput gets to be used in the RollScore() function.
            return randOutput;


        }
        //RollScore function handles adding up the 4 dice rolls, and printing the total score.
        internal void RollScore()
        {
            //Calls the Rolling() function 4 times, to get 4 values and adds it to dieScoreTotal.
            dieScoreTotal += Rolling();
            

            //Prints out  dieScoreTotal.
            Console.WriteLine("Now let's tally up the score.");
            Console.WriteLine("Your score is...");
            Console.WriteLine(dieScoreTotal + "!!!");
        }
    }
}
