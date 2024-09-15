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
            //Assigns class RollDie to a variable.
            RollDie diceRollInstance;
            diceRollInstance = new RollDie();
            //Calls the description of the dice roller from the RollDie class.
            diceRollInstance.Description();
            
            Console.WriteLine("Let's roll!");
            //Calls the RollScore function from the RollDie class.
            diceRollInstance.RollScore();                          
        }  
        
        internal void ArithmeticOperator()
        { 
            /*This is where Ill explain the arithmetic operators.
             *The ++ operator will increment an operand by one.
             *The -- operator will decrement an operand by one.
             *The * operator will multply its operands.
             *The / operator will divide its operands.
             *The + operator will add the sum of its operands.
             *The - operator will subtract the left operand by the right operand.
             *The % will compute the remainder after dividing the left operand by the right operand.
             *The < operator returns true if its left operand is less than the right operand otherwise, false.
             *The > operator returns true if its left operand is greater than the right operand otherwise, false.
             *The <= operator is the same as the < operator but it will also return true if the operands are equal.
             *The >= operator is the same as the > operator but it will also return true if the operands are equal.
            */
        
        
        }

    }   
}   
    