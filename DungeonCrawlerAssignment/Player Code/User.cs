using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerAssignment.Player_Code
{
    internal abstract class User
    {
        public abstract int MaxDamage { get; }

        public abstract int MinDamage { get; }
        public abstract int MaxHealth { get; }
        public abstract int Health { get; set; }
        public abstract string? Name { get; }

        public abstract void InventoryManager();

        public abstract void Death();
    }

    internal class Player : User
    {
        public override int MaxDamage { get; } = 0;
        public override int MinDamage { get; } = 0;
        public override int MaxHealth { get; } = 100;
        public override int Health { get; set; } = 100;
        public override string? Name { get; }

        public override void InventoryManager() 
        { }
        public override void Death() 
        { 
        
        }
    }
    internal  class CPU : User
    {
        public override int MaxHealth { get; } = 150;
        public override int MaxDamage { get; } = 35;
        public  override int MinDamage { get; } = 20;
        public override int Health { get; set; } = 150;
        public override string? Name { get; } = "The Figure";

        public override void InventoryManager() 
        { }
        public override void Death()
        {

        }
    }
}
