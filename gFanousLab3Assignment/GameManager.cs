using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gFanousLab3Assignment
{
    internal class GameManager
    {
        internal void PlayGame()
        {   //intro
            Console.WriteLine("Goran,  2024-09-24");
            Console.WriteLine("Welcome to Die vs Die!");
            //tells player to write username.
            Console.WriteLine("Please enter a username");

            //initializing the class that handles the player vs the computer.
            PlayerVComputer p1VsCPU = new PlayerVComputer();
            //runs the turn select and username creation function.
            p1VsCPU.TurnSelect();

            //runs the code to handle who goes first, and play the game.
            p1VsCPU.PlayerVsCPURolling();
        }
    }
}
