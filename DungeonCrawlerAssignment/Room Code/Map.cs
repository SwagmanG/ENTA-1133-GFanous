using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerAssignment.Room_Code
{
    internal class Map
    {
        public int MoveX = 0;//Player horizontal pos
        public int MoveY = 0;//Player vertical pos

        public bool CanMoveNorth() => MoveY > 0;
        public bool CanMoveEast() => MoveX < 2;
        public bool CanMoveWest() => MoveX > 0;
        public bool CanMoveSouth() => MoveY < 2;


        private GameManager Manager;         

        House[,] Layout = new House[3, 3];//Array of rooms for house
        
        public void RoomList()
        {
            //List of Rooms
            List<House> houses = new List<House> { new Kitchen(), new Garage(), new Office(), new Washroom(), new Bedroom(), new MasterBath(), new MasterBed(), new BoilerRoom(), new Closet() };
            
            Random random = new Random();//Initializing random
            
            int roomRandom = houses.Count;//Making an int to hold how many rooms are in the list at the start

            List<House> randomizedRooms = new List<House>();//New list for randomized rooms

            for (int i = 0; i < roomRandom; i++) //As long as i is less then roomRandom, increment i
            { 
                int roomSelected = random.Next(0, houses.Count);//Randomly select a room from the list of rooms "houses"
                randomizedRooms.Add(houses[roomSelected]);//Adds random rooms to the list, including duplicate rooms
            }
            Layout[0, 0] = randomizedRooms[0];//Top left room
            Layout[0, 1] = randomizedRooms[1];//Top middle room
            Layout[0, 2] = randomizedRooms[2];//Top right room

            Layout[1, 0] = randomizedRooms[3];//Middle left room
            Layout[1, 1] = randomizedRooms[4];//Middle middle room
            Layout[1, 2] = randomizedRooms[5];//Middle right room

            Layout[2, 0] = randomizedRooms[6];//Bottom left room
            Layout[2, 1] = randomizedRooms[7];//Bottom middle room
            Layout[2, 2] = randomizedRooms[8];//Bottom right room
        }

        public void MovementLoop()
        {
            Manager = new GameManager();
            RoomList();
            do
            {
                RoomDisplay();//Run room display script
                PlayerDo();//Check if they can move certain ways
                PlayerMove();//Makes player move
            }
            while (Manager.wantsToPlay == true);
        }
        public void RoomDisplay()
        { 
            //flavor
            House currentRoom = Layout[MoveX, MoveY]; //Local variable for player pos
            currentRoom.OnRoomEntered(); //Run OnRoomEntered script for current room
        }

        public void PlayerDo()
        {
            Console.WriteLine("Where to fella?");  //Temp add flavor later
            Console.WriteLine("1 : North    2 : West    3 : East    4 : South"); //Directions
            string? userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int direction))
            {
                switch (direction) //Moves player in valid directions
                {
                    case 1:
                        if (CanMoveNorth()) MoveY--;
                        Console.Clear();
                    break;                                             
                    case 2:
                        if (CanMoveWest()) MoveX--;
                        Console.Clear();
                    break;
                    case 3:
                        if (CanMoveEast()) MoveX++;
                        Console.Clear();
                    break;
                    case 4:
                        if (CanMoveSouth()) MoveY++;
                        Console.Clear();
                    break;
                    default:
                        Console.WriteLine("There is a fucking wall");
                    break;

                }

            }
            else
            {
                Console.WriteLine("invalid input");
                MoveNotValid();
            }



        }

        public void PlayerMove()
        { 
            if (Layout[MoveX, MoveY] != null)
            {
                Console.WriteLine($"moved to room at [{MoveX}, {MoveY}]");// reflavor latyer
            }
            else
            {
                Console.WriteLine("THERE IS A WALL");//reflavor later
            }
        }

        public void MoveNotValid()
        {
            PlayerMove();
        }

    }
}
