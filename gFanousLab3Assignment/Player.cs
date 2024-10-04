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
        internal int playerDiceRoll;
        internal int playerRollTotal;
        internal int playerOddRolls;
        internal int playerEvenRolls;
        
        //handles user input for their username
        internal string PlayerName()
        {
            Console.WriteLine("What's your name wastelander, I like to know the names of the people I shoot.");
            //the input for the username and assigns it to username
            username = Console.ReadLine();

            // returns the value for username to PlayerName()
            return username;
        }
        //handles which dice are in the players inventory
        internal void DiceInventory()
        {
            
            Console.WriteLine("Pick your poison.");
            Console.WriteLine("-------------------------------");
            //checks if the dice has already been rolled
            if (rolledD6 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("Pistol");    
                Console.WriteLine(@" +--^----------,--------,-----,--------^-,
 | |||||||||   `--------'     |          O
 `+---------------------------^----------|
   `\_,---------,---------,--------------'
     / XXXXXX /'|       /'
    / XXXXXX /  `\    /'
   / XXXXXX /`-------'
  / XXXXXX /
 / XXXXXX /
(________(                
 `------'        ");
            }
            else
            {
                Console.WriteLine("The pistol is broken.");
            }
            //checks if the dice has already been rolled
            if (rolledD8 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("Magnum");
                Console.WriteLine(@"  (                                 _
   )                               /=>
  (  +____________________/\/\___ / /|
   .''._____________'._____      / /|/\
  : () :              :\ ----\|    \ )
   '..'______________.'0|----|      \
                    0_0/____/        \
                        |----    /----\
                       || -\\ --|      \
                       ||   || ||\      \
                        \\____// '|      \
                                .'/       |
                               .:/        |
                               :/_________|");
            }
            else
            {
                Console.WriteLine("The magnum is broken.");
            }
            //checks if the dice has already been rolled
            if (rolledD12 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("Assault Rifle");
                Console.WriteLine(@"                           ______
        |\_______________ (_____\\______________
HH======#H###############H#######################
        ' ~""""""""""""""""""""""""""""`##(_))#H\""""""""""Y########
                          ))    \#H\       `""Y###
                          ""      }#H)");
            }
            else
            {
                Console.WriteLine("The rifle is broken.");
            }
            //checks if the dice has already been rolled
            if (rolledD20 == false)
            {   //if its false then print D#, otherwise print you already rolled this dice.
                Console.WriteLine("Shotgun");
                Console.WriteLine(@" ,______________________________________       
|_________________,----------._ [____]  """"-,__  __....-----=====
               (_(||||||||||||)___________/   """"                |
                  `----------'         [ ))""-,                   |
                                       """"    `,  _,--....___    |
                                               `/           """"""""");
            }   
            else
            {
                Console.WriteLine("The shotgun is broken.");
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
            if (selectedDice == "Pistol" || selectedDice == "pistol")
            {   //checks if this dice had been rolled previously
                if (rolledD6 == false)
                {   //if false will roll the dice
                   
                    playerDiceRoll = diceSixSides.Rolling();
                    playerRollTotal += playerDiceRoll;//Adds the dice roll to the roll total
                    if (playerDiceRoll % 2 == 0)//checking if the dice roll is even or odd and incrementing a variable.
                    {
                        playerEvenRolls++;
                    }
                    else
                    {
                        playerOddRolls++;
                    }


                    Console.WriteLine(username + " dealt " + playerDiceRoll + " damage");

                    rolledD6 = true;
                }
                else
                {   //if the dice was rolled previously, will run the inventroy and seletion function again until a different dice is picked
                    PlayerDiceSelectionError();
                }
            }
            else if (selectedDice == "magnum" || selectedDice == "Magnum")
            {
                if (rolledD8 == false)
                {   //if false will roll the dice
                    
                    playerDiceRoll = diceEightSides.Rolling();
                    playerRollTotal += playerDiceRoll;//Adds the dice roll to the roll total
                    if (playerDiceRoll % 2 == 0)//checking if the dice roll is even or odd and incrementing a variable.
                    {
                        playerEvenRolls++;
                    }
                    else
                    {
                        playerOddRolls++;
                    }


                    Console.WriteLine(username + " dealt " + playerDiceRoll + " damage");

                    rolledD8 = true;


                }
                else
                {   //if the dice was rolled previously, will run the inventroy and seletion function again until a different dice is picked
                    PlayerDiceSelectionError();//calls the PlayerDiceSelectionError function
                }
            }
            else if (selectedDice == "assault rile" || selectedDice == "Assault Rifle" || selectedDice == "AR" || selectedDice == "ar" || selectedDice == "Assault rifle")
            {
                if (rolledD12 == false)
                {    //if false will roll the dice
                    
                    playerDiceRoll = diceTwelveSides.Rolling();
                    playerRollTotal += playerDiceRoll;//Adds the dice roll to the roll total
                    if (playerDiceRoll % 2 == 0)//checking if the dice roll is even or odd and incrementing a variable.
                    {
                        playerEvenRolls++;
                    }
                    else
                    {
                        playerOddRolls++;
                    }


                    Console.WriteLine(username + " dealt " + playerDiceRoll + " damage");

                    rolledD12 = true;

                }
                else
                {   //if the dice was rolled previously, will run the inventroy and seletion function again until a different dice is picked
                    PlayerDiceSelectionError();//calls the PlayerDiceSelectionError function
                }
            }
            else if (selectedDice == "shotgun" || selectedDice == "Shotgun")
            {
                if (rolledD20 == false)
                {    //if false will roll the dice
                  
                    playerDiceRoll = diceTwentySides.Rolling();
                    playerRollTotal += playerDiceRoll;//Adds the dice roll to the roll total
                    if (playerDiceRoll%2 == 0)//checking if the dice roll is even or odd and incrementing a variable.
                    {
                        playerEvenRolls++;
                    }
                    else
                    {
                        playerOddRolls++;
                    }



                    Console.WriteLine(username + " dealt " + playerDiceRoll + " damage");

                    rolledD20 = true;

                }
                else
                {   //if the dice was rolled previously, will run the inventroy and seletion function again until a different dice is picked
                    PlayerDiceSelectionError();//calls the PlayerDiceSelectionError function
                }

            }
            else
            {
                PlayerDiceSelectionError();//calls the PlayerDiceSelectionError function
            }
            return playerDiceRoll;
        }


        internal void PlayerDiceSelectionError() //calls the functions again if a dice it randomly selected had already rolled that dice.
        {
            DiceInventory();
            DiceSelection();
        }
        
    }
}