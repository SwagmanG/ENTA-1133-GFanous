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

        

        Player player = new Player();
        CPU cpu = new CPU();

        internal bool TurnSelect()   //function for selecting who goes first.
        {
            player.PlayerName(); //function in charge of creating and storing player's username.

            Console.WriteLine("We will now determine who goes first.");
            
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
                //flavor text and an indicator for who will go first
                Console.WriteLine(player.username + " will roll first, Please select a dice.");
                Console.WriteLine("-------------------------------");
                player.DiceInventory();//runs the code for the players dice inventory
                player.DiceSelection();// runs the code for the players dice choice

                 cpu.CPUDiceSelector();//runs the code for the cpus dice inventory
                 cpu.CPUDiceRoller();//runs the code for the cpus dice roller

                player.DiceInventory();
                player.DiceSelection();

                cpu.CPUDiceSelector();
                cpu.CPUDiceRoller();

                player.DiceInventory();
                player.DiceSelection();

                cpu.CPUDiceSelector();
                cpu.CPUDiceRoller();

                player.DiceInventory();
                player.DiceSelection();

                cpu.CPUDiceSelector();
                cpu.CPUDiceRoller();

                WinController();               
            }
            //if the player goes second runs the game in order of cpu then player.
            else
            {   //flavor text and an indicator for who will go first
                Console.WriteLine("The CPU will go first.");
                Console.WriteLine("-------------------------------");

                cpu.CPUDiceSelector();//runs the code for the cpus dice inventory
                cpu.CPUDiceRoller();//runs the code for the cpus dice roller


                player.DiceInventory();//runs the code for the players dice inventory
                player.DiceSelection();// runs the code for the players dice choice

                cpu.CPUDiceSelector();
                cpu.CPUDiceRoller();


                player.DiceInventory();
                player.DiceSelection();

                cpu.CPUDiceSelector();
                cpu.CPUDiceRoller();


                player.DiceInventory();
                player.DiceSelection();

                cpu.CPUDiceSelector();
                cpu.CPUDiceRoller();


                player.DiceInventory();
                player.DiceSelection();


                WinController();//calls the code in the wincontroller function
            }
        }
        //handles whether the player or cpu wins, loses, or ties
        internal void WinController()
        {   //checks if the player has a larger score
            if (player.playerScore > cpu.cpuScore)
            {
                Console.WriteLine("After tallying up the score, " + player.username + " wins with a total of " + player.playerScore + " Points!!");
            }
            //checks if the player has the same score
            else if (player.playerScore == cpu.cpuScore)
            {
                Console.WriteLine("After tallying up the score, " + player.username + " ties with the CPU!!");
            }
            //checks if the player has the smaller score
            else if (player.playerScore < cpu.cpuScore)
            {
                Console.WriteLine("After tallying up the score, the CPU wins with a total of " + cpu.cpuScore + " Points!!");
            }
        }   
    }
}
