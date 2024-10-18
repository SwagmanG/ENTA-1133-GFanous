using DungeonCrawlerAssignment.Room_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerAssignment
{
    

 
        public abstract class House
        {
            


            public abstract void OnRoomEntered();

            public abstract void OnRoomSearched();
            public abstract void OnRoomExited();


        }

        public class Kitchen : House
        {
            TreasureRoom TRoom = new TreasureRoom();
            public override void OnRoomEntered()
            {
            Console.WriteLine("search room?");
            Console.WriteLine("Y or N");
            string? userInput = Console.ReadLine();
            if (userInput == "Y")
            {
                OnRoomSearched();
            }
            else { OnRoomEntered(); }
        }

            public override void OnRoomSearched()
            {
                TRoom.TreasureRoomSearch();
            }

            public override void OnRoomExited()
            {
                

            }
        }

        public class Garage : House
        {
            TreasureRoom TRoom = new TreasureRoom();
            public override void OnRoomEntered()
            {
                Console.WriteLine("search room?");
                Console.WriteLine("Y or N");
                string? userInput = Console.ReadLine();
                if (userInput == "Y") 
                {
                OnRoomSearched();
                }
                else {OnRoomEntered();}
            }

            public override void OnRoomSearched()
            {
                TRoom.TreasureRoomSearch();
            }

            public override void OnRoomExited()
            {
            
            }
        }

        public class Office : House
        {
            CombatRoom CRoom = new CombatRoom();
            public override void OnRoomEntered()//initializing class
            {   Console.WriteLine("search room?");
                Console.WriteLine("Y or N");
                string? userInput = Console.ReadLine();
                if (userInput == "Y") 
                {
                OnRoomSearched();
                }
                else {OnRoomEntered();}
            }   

            public override void OnRoomSearched()
            {
                CRoom.CombatRoomSearched();
            }

            public override void OnRoomExited()
            {
       

            }
        }

        public class Washroom : House
        {

            public override void OnRoomEntered()
            {
               
            }

            public override void OnRoomSearched()
            {

            }

            public override void OnRoomExited()
            {
 
            }
        }

        public class Bedroom : House
        {

            public override void OnRoomEntered()
            {
                
            }

            public override void OnRoomSearched()
            {

            }

            public override void OnRoomExited()
            {

            }
        }

        public class MasterBath : House
        {

            public override void OnRoomEntered()
            {
                
            }

            public override void OnRoomSearched()
            {

            }

            public override void OnRoomExited()
            {

            }
        }

        public class MasterBed : House
        {
            CombatRoom CRoom = new CombatRoom();
            public override void OnRoomEntered()
            {
                Console.WriteLine("search room?");
                Console.WriteLine("Y or N");
                string? userInput = Console.ReadLine();
                if (userInput == "Y") 
                {
                OnRoomSearched();
                }
                else {OnRoomEntered();}
            }

            public override void OnRoomSearched()
            {
                CRoom.CombatRoomSearched();
            }

            public override void OnRoomExited()
            {

            }
        }

        public class BoilerRoom : House
        {
        CombatRoom CRoom = new CombatRoom();
            public override void OnRoomEntered()
            {
                Console.WriteLine("search room?");
                Console.WriteLine("Y or N");
                string? userInput = Console.ReadLine();
                if (userInput == "Y") 
                {
                OnRoomSearched();
                }
                else {OnRoomEntered();}
            }

            public override void OnRoomSearched()
            {
                CRoom.CombatRoomSearched();
            }

            public override void OnRoomExited()
            {
                
            }
        }

        public class Closet : House
        {
            TreasureRoom TRoom = new TreasureRoom();
            public override void OnRoomEntered()
            {
                Console.WriteLine("search room?");
                Console.WriteLine("Y or N");
                string? userInput = Console.ReadLine();
                if (userInput == "Y") 
                {
                OnRoomSearched();
                }
                else {OnRoomEntered();}
            }

            public override void OnRoomSearched()
            {
                TRoom.TreasureRoomSearch();
            }

            public override void OnRoomExited()
            {
              
            }
        }
}
        
       
        

