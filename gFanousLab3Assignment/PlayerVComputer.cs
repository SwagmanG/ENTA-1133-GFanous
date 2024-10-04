using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gFanousLab3Assignment
{
    internal class PlayerVComputer
    {
        internal bool playerFirst = false;
        internal int turnAmount = 4;
        

        Player player = new Player();
        CPU cpu = new CPU();

        internal bool TurnSelect()   //function for selecting who goes first.
        {
            
            player.PlayerName(); //function in charge of creating and storing player's username.

            Console.WriteLine("Let's flip a coin wastelander, heads you shoot first, tails I shoot first.");
            
            //random rolls 1 or 2. 
            Random random = new Random();
            int turnRandom = random.Next(1, 3);
            // checks if turnRandom is 1 or 2 if 1 player goes first. if 2 player ges second.
            if (turnRandom == 1)
            {
                playerFirst = true;
            }
            else if (turnRandom == 2)
            {
                playerFirst = false;
            }

            // visual seperator, then returns result of playerfirst
            Console.WriteLine("-------------------------------");
            return playerFirst;

        }

        //responisible for main portions of game
        internal void PlayerVsCPURolling()
        {
            
            
                //if the player goes first runs the game in order of player then cpu
                if (playerFirst == true)
                {
                    Console.WriteLine("Looks like it's your lucky day wastelander.");
                    Console.WriteLine("-------------------------------");
                    for (int i = 0; i < turnAmount; i++)
                    {
                        //flavor text and an indicator for who will go first
                       
                        player.DiceInventory();//runs the code for the players dice inventory
                        player.DiceSelection();// runs the code for the players dice choice

                        cpu.CPUDiceSelector();//runs the code for the cpus dice inventory
                        cpu.CPUDiceRoller();//runs the code for the cpus dice roller
                        TurnWinController();//runs the code to make a comparison based on whether or not, the player rolls higher or lower than the cpu, or if it ties
                    }
                    




                }
                //if the player goes second runs the game in order of cpu then player
                else
                {
                    Console.WriteLine("Tails, it looks like I'm shootin' first.");
                    Console.WriteLine("-------------------------------");
                    for (int i = 0;i < turnAmount; i++) 
                    {
                    //flavor text and an indicator for who will go first

                   
                        cpu.CPUDiceSelector();//runs the code for the cpus dice inventory
                        cpu.CPUDiceRoller();//runs the code for the cpus dice roller


                        player.DiceInventory();//runs the code for the players dice inventory
                        player.DiceSelection();// runs the code for the players dice choice

                        TurnWinController();//runs the code to make a comparison based on whether or not, the player rolls higher or lower than the cpu, or if it ties

                    }

                }
            

               
            
            WinController();  //calls the code in the wincontroller function
            
        }
        //handles whether the player or cpu wins, loses, or ties
        internal void WinController()
        {   //checks if the player has a larger score
            if (player.playerScore > cpu.cpuScore)
            {
                Console.WriteLine("Well done wastelander, you win with a total of " + player.playerScore + " points.");
               
            }
            
            //checks if the player has the same score
            else if (player.playerScore == cpu.cpuScore)
            {
                Console.WriteLine("Hmm, nice try wastelanded, but seems we tied.");
                
            }
            //checks if the player has the smaller score
            else if (player.playerScore < cpu.cpuScore)
            {
                Console.WriteLine("Tough luck wastelander, but I win. I beat you with " + cpu.cpuScore + " points.");

            }
            //stats for the player and cpu
            Console.WriteLine("Lets tally up our damage wastelander.");
            Console.WriteLine("Well wastelander, it looks like you did a total of " + player.playerRollTotal + " damage.");
            Console.WriteLine("Hmmm, interesting. I did a total of " + cpu.cpuRollTotal + " damage.");
            Console.WriteLine(player.username+" rolled "+player.playerOddRolls+" odd");
            Console.WriteLine(player.username + " rolled " + player.playerEvenRolls + " even");
            Console.WriteLine("The dealer rolled "+cpu.cpuOddRolls+" odd");
            Console.WriteLine("The dealer rolled " + cpu.cpuEvenRolls + " even");

        }

        internal void TurnWinController()
            //runs a comparison, on the player and cpu dice roll, and then either increments their score by one, depending on who had the higher roll.
        {
            if (player.playerDiceRoll > cpu.cpuDiceRoll)
            {
                Console.WriteLine("Well wastelander, seems like you had the faster draw this time, don't expect that to happen again. Thats a point for you.");
                player.playerScore++;
            }
            else if (player.playerDiceRoll == cpu.cpuDiceRoll)
            {
                Console.WriteLine("Well damn kid, too close to tell who drew first. No points are gonna be given to you, or me.");
            }
            else if (player.playerDiceRoll < cpu.cpuDiceRoll)
            {   
                Console.WriteLine("You might be fast, but I'm faster wastelander. Better luck next time, but thats a point for me.");
                cpu.cpuScore++;       
            }
        }

        internal void PlayAgain()
        {
            GameManager manager = new GameManager();//initializing a new instance of game manager

            Console.WriteLine("You think you have another game in you wastelander?");//asking player if they want to play again or not
            Console.WriteLine("Y or N");

            string playerChoice = Console.ReadLine();

           
            /*checks for playerchoice variable, if it doesnt match any of the if statement options, then it will automatically exit the code,
             *otherwise it will reset the booleans for dice rolling to false, and call the code from the playgame function 
            */
            if (playerChoice == "yes" || playerChoice == "Yes"|| playerChoice =="y" || playerChoice == "Y")
            {
                //resets important global variables.
                player.rolledD6 = false;
                player.rolledD8 = false;
                player.rolledD12 = false;
                player.rolledD20 = false;
                player.playerScore = 0;
                player.playerDiceRoll = 0;
                player.playerEvenRolls = 0;
                player.playerRollTotal = 0;
                player.playerOddRolls = 0;

                cpu.rolledD6 = false;
                cpu.rolledD8 = false;
                cpu.rolledD12 = false;
                cpu.rolledD20 = false;  
                cpu.cpuScore = 0;
                cpu.cpuRollTotal = 0;
                cpu.cpuEvenRolls = 0;
                cpu.cpuOddRolls = 0;   
                cpu.cpuDiceRoll = 0;

                manager.PlayGame();
            }
            else
            {
                manager.wantToPlay = false;
                Console.WriteLine("Fair enough, this game isnt for the weakhearted, I wish you luck wastelander, may your journey through the wastelands be ever prosperous.");
                Environment.Exit(0);
            }
        }   

        

        
    }
}
