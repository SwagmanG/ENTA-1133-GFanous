using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassDemo
{
    internal class GameManager
    {
        internal int score = 0;

        internal void PlayGame()
        {

            Console.WriteLine("Welcome to Die vs Die!");

            RollDie diceRollInstance;
            diceRollInstance = new RollDie();

            diceRollInstance.Description();
            //WhenPointGained();
            //dieroller1 dierollerinstance
            Console.WriteLine("Let's roll!");

            diceRollInstance.Rolling();

        }


        private void WhenPointGained()
        { 
        
            score++;
            string messageReceived = "You gained a point!";
            Console.WriteLine(messageReceived);
            Console.WriteLine(score);
        }
        
    }

}   
    