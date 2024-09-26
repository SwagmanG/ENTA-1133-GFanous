using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gFanousLab3Assignment
{
    internal class Player
    {   //initializing true or false statements for cheking if a dicetype has been rolled
        internal bool rolledD6 = false;
        internal bool rolledD8 = false;
        internal bool rolledD12 = false;
        internal bool rolledD20 = false;
        //initializing variable used for usernames
        internal string username;

        //initializing the variable used to keep track of the total of all dice roll values.
        internal int playerScore;
        
        //handles user input for their username
        internal string PlayerName()
        {   //the input for the username and assigns it to username
            username = Console.ReadLine();

            // returns the value for username to PlayerName()
            return username;
        }
        //handles which dice are in the players inventory
        internal void DiceInventory()
        {
            
            Console.WriteLine("Here is your selection of dice.");
            Console.WriteLine("-------------------------------");
            //checks if the dice has already been rolled
            if (rolledD6 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("D6");       
            }
            else
            {
                Console.WriteLine("You already rolled a D6");
            }
            //checks if the dice has already been rolled
            if (rolledD8 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("D8");
            }
            else
            {
                Console.WriteLine("You already rolled a D8");
            }
            //checks if the dice has already been rolled
            if (rolledD12 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("D12");
            }
            else
            {
                Console.WriteLine("You already rolled a D12");
            }
            //checks if the dice has already been rolled
            if (rolledD20 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("D20");
            }
            else
            {
                Console.WriteLine("You already rolled a D20");
            }

            Console.WriteLine("-------------------------------");
        }
        //handles the input for the dice that the player rolls.
        internal int DiceSelection()
        {   //initiating dice roller for the 4 dice types
            RollDie diceSixSides = new RollDie();
            RollDie diceEightSides = new RollDie();
            RollDie diceTwelveSides = new RollDie();
            RollDie diceTwentySides = new RollDie();
            //changing the side count for the 4 dice types
            diceSixSides.sideCount = 6;
            diceEightSides.sideCount = 8;
            diceTwelveSides.sideCount = 12;
            diceTwentySides.sideCount = 20;
            //lets you enter a value for which dice you want to pick 
            string selectedDice = Console.ReadLine();

            //checks for a string input of these values then the code inside
            if (selectedDice == "D6" || selectedDice == "6" || selectedDice == "d6")
            {   //checks if this dice had been rolled previously
                if (rolledD6 == false)
                {   //if false will roll the dice
                    Console.WriteLine(username + " rolled a");
                    playerScore += diceSixSides.Rolling();
                    rolledD6 = true;
                }
                else
                {   //if the dice was rolled previously, will run the inventroy and seletion function again until a different dice is picked
                    DiceInventory();
                    DiceSelection();
                }
            }
            else if (selectedDice == "D8" || selectedDice == "8" || selectedDice == "d8")
            {
                if (rolledD8 == false)
                {   //if false will roll the dice
                    Console.WriteLine(username + " rolled a");
                    playerScore += diceEightSides.Rolling();
                    rolledD8 = true;
                    
                    
                }
                else
                {   //if the dice was rolled previously, will run the inventroy and seletion function again until a different dice is picked
                    DiceInventory();
                    DiceSelection();
                }
            }
            else if (selectedDice == "D12" || selectedDice == "12" || selectedDice == "d12")
            {
                if (rolledD12 == false)
                {    //if false will roll the dice
                    Console.WriteLine(username + " rolled a");
                    playerScore += diceTwelveSides.Rolling();
                    rolledD12 = true;
                    
                }
                else
                {   //if the dice was rolled previously, will run the inventroy and seletion function again until a different dice is picked
                    DiceInventory();
                    DiceSelection();
                }
            }
            else if (selectedDice == "D20" || selectedDice == "20" || selectedDice == "d20")
            {
                if (rolledD20 == false)
                {    //if false will roll the dice
                    Console.WriteLine(username + " rolled a");
                    playerScore += diceTwentySides.Rolling();
                    rolledD20 = true;
                   
                }
                else
                {   //if the dice was rolled previously, will run the inventroy and seletion function again until a different dice is picked
                    DiceInventory();
                    DiceSelection();
                }
                
            }//returns the score of all the rolls added together
            return playerScore;
        }

        
    }
}