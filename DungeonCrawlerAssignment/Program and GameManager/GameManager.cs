using DungeonCrawlerAssignment.FlavorText;
using DungeonCrawlerAssignment.Player_Code;
using DungeonCrawlerAssignment.Room_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerAssignment
{
    internal class GameManager
    {



        FText Flavor = new FText();

        private ItemManager IManager = new ItemManager(); 
        CombatRoom CRoom = new CombatRoom();
        TreasureRoom TRoom = new TreasureRoom();
        HealingRoom HRoom = new HealingRoom();
        public bool wantsToPlay = true;
        private Map Map; 
       
        internal void Intro()
        {
            Console.WriteLine("Goran, 10/16/2024");

            Flavor.GameIntroText();
         
            PlayGame();
           
            
        }
        internal void PlayGame()
        {   
            IManager = new ItemManager();
            Map = new Map();

            //Have to unlink movement, movement works, but breaks combat code when called into rooms.

            Console.WriteLine("after spending 2 whole days  trying to get my code to work when i attached them to rooms, and failing");

            Console.WriteLine("Movement works, though it breaks the combat room code for some reason, so here is the working treasureroom, combatroom, and healingroom coding, and you can fight a CPU");

            Console.WriteLine("Where would you like to go?");
            Console.WriteLine("T : Treasure Room, H : Healing Room, or C : Combat Room?");

            string? userInput = Console.ReadLine();

            if (userInput == "T")
            {
                TRoom.TreasureRoomSearch();
            }
            else if (userInput == "H")
            {
                HRoom.HealingRoomSearch();
            }
            else if (userInput == "C")
            {
               CRoom.CombatLoop();
            }

            Intro();

            
           //Map.MovementLoop();
           // this is the function to run movement, it does work, unless you end up searching inside a combat room,
           //i ran out of time to add proper text to the treasure room though it is successfully adding items to the inventory lists.
            

            Outro();
        }
        internal void Outro()
        {

        }
    }
}
