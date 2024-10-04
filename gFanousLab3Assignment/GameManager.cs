using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gFanousLab3Assignment
{
    internal class GameManager
    {
        internal bool wantToPlay = true;

        internal void PlayGame()
        {
            
            //intro and rules of the game.
            Console.WriteLine("Goran,  2024-09-24");
            Console.WriteLine("Psst, hey wastelander, yeah you. You interested in playing a little game? ");
            Console.WriteLine("What's the game? Well you see it's a game I like to call...");
            
            Console.WriteLine(@"  _______    _______   _______    _______  _____  ___    _______   _______        __  ___________  __      ______    _____  ___  
 /""      \  /""     ""| /"" _   ""|  /""     ""|(\""   \|""  \  /""     ""| /""      \      /""""\(""     _   "")|"" \    /    "" \  (\""   \|""  \ 
|:        |(: ______)(: ( \___) (: ______)|.\\   \    |(: ______)|:        |    /    \)__/  \\__/ ||  |  // ____  \ |.\\   \    |
|_____/   ) \/    |   \/ \       \/    |  |: \.   \\  | \/    |  |_____/   )   /' /\  \  \\_ /    |:  | /  /    ) :)|: \.   \\  |
 //      /  // ___)_  //  \ ___  // ___)_ |.  \    \. | // ___)_  //      /   //  __'  \ |.  |    |.  |(: (____/ // |.  \    \. |
|:  __   \ (:      ""|(:   _(  _|(:      ""||    \    \ |(:      ""||:  __   \  /   /  \\  \\:  |    /\  |\\        /  |    \    \ |
|__|  \___) \_______) \_______)  \_______) \___|\____\) \_______)|__|  \___)(___/    \___)\__|   (__\_|_)\""_____/    \___|\____\)
                                                                                                                                 
  _______     ______    ____  ____  ___       _______  ___________  ___________  _______                                         
 /""      \   /    "" \  (""  _||_ "" ||""  |     /""     ""|(""     _   "")(""     _   "")/""     ""|                                        
|:        | // ____  \ |   (  ) : |||  |    (: ______) )__/  \\__/  )__/  \\__/(: ______)                                        
|_____/   )/  /    ) :)(:  |  | . )|:  |     \/    |      \\_ /        \\_ /    \/    |                                          
 //      /(: (____/ //  \\ \__/ //  \  |___  // ___)_     |.  |        |.  |    // ___)_                                         
|:  __   \ \        /   /\\ __ //\ ( \_|:  \(:      ""|    \:  |        \:  |   (:      ""|                                        
|__|  \___) \""_____/   (__________) \_______)\_______)     \__|         \__|    \_______)                                        ");

            Console.WriteLine("You see, on a table we have a selection of four different weapons.");
            Console.WriteLine("While behind us are pre-war regeneration stations.");
            Console.WriteLine("We will connect ourselves to these machines and then the game will begin.");
            Console.WriteLine("These machines might be old but damn are they reliable, after we are dealt any form of damage, these machines will heal us up good as new.");
            Console.WriteLine("We each pick one a weapon to use, and point it at the other.");
            Console.WriteLine("A coin flip at the start of our little game will determine who goes first.");
            Console.WriteLine("Whoever deals more damage in a round, wins a point.");
            Console.WriteLine("Oh, and one more thing, these weapons are old, older then both of us,");
            Console.WriteLine("You'll only have one shot with each weapon before they break. Better not miss, wastelander.");
            


            //initializing the class that handles the player vs the computer.
            PlayerVComputer p1VsCPU = new PlayerVComputer();
            do
            {
                //runs the turn select and username creation function.
                p1VsCPU.TurnSelect();

                //runs the code to handle who goes first, and play the game.
                p1VsCPU.PlayerVsCPURolling();
                p1VsCPU.PlayAgain();
            }
            while (wantToPlay == true);
            
        }
    }
}
