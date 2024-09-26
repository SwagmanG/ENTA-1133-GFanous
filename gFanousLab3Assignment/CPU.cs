using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gFanousLab3Assignment
{
    internal class CPU
    {   //initializing booleans and integer variables to be used in the code.
        internal bool rolledD6 = false;
        internal bool rolledD8 = false;
        internal bool rolledD12 = false;
        internal bool rolledD20 = false;
        internal int dicePicker = 0;
        internal int cpuScore = 0;

        
        //handles the randomness for which dice the cpu will select.
        internal int CPUDiceSelector()
        {
            Random random = new Random();  
            dicePicker = random.Next(1,5);
            
            return dicePicker;
        }
        
        internal int CPUDiceRoller()
        {
            //initializing the 4 dice types.
            RollDie diceSixSides = new RollDie();
            RollDie diceEightSides = new RollDie();
            RollDie diceTwelveSides = new RollDie();
            RollDie diceTwentySides = new RollDie();
            //sets the side count of the 4 dice types.
            diceSixSides.sideCount = 6;
            diceEightSides.sideCount = 8;
            diceTwelveSides.sideCount = 12;
            diceTwentySides.sideCount = 20;

            //determines which dice the cpu rolls depending on what random value dicePicker is.
            if (dicePicker == 1)
            {   //checks if this dice has alreay been rolled
                if (rolledD6 == false)
                {   //if it hasnt been rolled yet, it will roll this dice, otherwise it will try the  CPUDiceRoller and the CPUDiceSelector functions again until it is a different dice value picked.
                    Console.WriteLine("The CPU will roll a D6");
                     
                    Console.WriteLine("The CPU rolled a");
                    cpuScore += diceSixSides.Rolling();
                    Console.WriteLine("-------------------------------");
                    rolledD6 = true;
                }
                else
                {
                    CPUDiceSelector();
                    CPUDiceRoller();
                }
            }   //checks if this dice has alreay been rolled
            else if (dicePicker == 2)
            {       //if it hasnt been rolled yet, it will roll this dice, otherwise it will try the  CPUDiceRoller and the CPUDiceSelector functions again until it is a different dice value picked.
                if (rolledD8 == false)
                {
                    Console.WriteLine("The CPU will roll a D8");
                   
                    Console.WriteLine("The CPU rolled a");
                    cpuScore += diceEightSides.Rolling();
                    Console.WriteLine("-------------------------------");
                    rolledD8 = true;
                }
                else
                {
                    CPUDiceSelector();
                    CPUDiceRoller();
                }
            }   //checks if this dice has alreay been rolled
            else if (dicePicker == 3)
            {       //if it hasnt been rolled yet, it will roll this dice, otherwise it will try the  CPUDiceRoller and the CPUDiceSelector functions again until it is a different dice value picked.
                if (rolledD12 == false)
                {
                    Console.WriteLine("The CPU will roll a D12");
                    
                    Console.WriteLine("The CPU rolled a");
                    cpuScore += diceTwelveSides.Rolling();
                    Console.WriteLine("-------------------------------");
                    rolledD12 = true;
                }
                else
                {
                    CPUDiceSelector();
                    CPUDiceRoller();
                }
            }   //checks if this dice has alreay been rolled
            else if (dicePicker == 4)
            {       //if it hasnt been rolled yet, it will roll this dice, otherwise it will try the  CPUDiceRoller and the CPUDiceSelector functions again until it is a different dice value picked.
                if (rolledD20 == false)
                {
                    Console.WriteLine("The CPU will roll a D20");
                    
                    Console.WriteLine("The CPU rolled a");
                    cpuScore += diceTwentySides.Rolling();
                    Console.WriteLine("-------------------------------");
                    rolledD20 = true;
                }
                else
                {
                    CPUDiceSelector();
                    CPUDiceRoller();
                }
            }
            return cpuScore;
        }
        
    }
}
