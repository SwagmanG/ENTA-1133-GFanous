using DungeonCrawlerAssignment.Player_Code;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonCrawlerAssignment
{
    internal class CombatRoom
    {
       
        public int CPUDamage;
        public bool InCombat = true;
        ItemManager Manager = new ItemManager();
        User PlayerManager = new Player();
        User CPUManager = new CPU();
        internal void CombatRoomSearched()
        {
            
            
            //add flavor text before and after code
            Manager.ItemRandomizer();
            Manager.ShieldItemRandomizer();
            Manager.ItemRandomizer();
            Manager.ItemRandomizer();
            Manager.ItemRandomizer();
            Manager.ItemRandomizer();
            Manager.ItemRandomizer();
            Manager.ShieldItemRandomizer();
            Manager.ShieldItemRandomizer();
            Manager.ShieldItemRandomizer();
            Manager.ShieldItemRandomizer();
            Manager.ShieldItemRandomizer();
            
            //add flavor text before and after code
            Manager.HealItemRandomizer();
            Manager.HealItemRandomizer();
            Manager.HealItemRandomizer();
            Manager.HealItemRandomizer();
            Manager.HealItemRandomizer();
            Manager.HealItemRandomizer();
            Manager.HealItemRandomizer();

            //flavor text
            //ask if want to 1fight, 2heal, or 3block attack

            Console.WriteLine("Would you like to 1: fight, 2: heal, or 3: Shield");
            string? userInput = Console.ReadLine();
            
            if (userInput == "1")
            {
                WeaponMenu();
            }          
            else if (userInput == "2")
            {
                HealMenu();
            }           
            else if (userInput == "3")
            {
                ShieldMenu();
            }
            else
            {
                Console.WriteLine("not available option try again");
                CombatRoomSearched();
            }
        }

        internal void WeaponMenu()
        {   
            //add flavor text         
            for (int i = 0; i < Manager.WeaponInventory.Count; i++)
            {
                Console.WriteLine(Manager.WeaponCountList[i] + " : " + Manager.WeaponInventory[i].Name);
                Console.WriteLine("Damage: Deals " + Manager.WeaponInventory[i].MinDamage + " to " + Manager.WeaponInventory[i].MaxDamage + " damage.");
                Console.WriteLine("Uses: " + Manager.WeaponInventory[i].Durability);
                Console.WriteLine();
            }
            WeaponSelected();
        }

        internal void WeaponSelected()
        {
            Random random = new Random();
            CpuDamager();
            string? userInput = Console.ReadLine();
            int.TryParse(userInput, out int index);

            if (index <= Manager.WeaponCountList[Manager.WeaponCount])
            {
                int damage = random.Next(Manager.WeaponInventory[index].MinDamage , Manager.WeaponInventory[index].MaxDamage);
                
                CPUManager.Health -= damage;

                Console.WriteLine($"The Figure takes, {damage} damage.");
                //cpu took damage write

                PlayerManager.Health -= CPUDamage;
                Console.WriteLine($"The Figure retaliates and the player takes, {CPUDamage} damage.");
                //cpu retaliates
            }
            else
            {   Console.WriteLine("not available item.");                   
                WeaponMenu(); 
            }
        }

        internal void HealMenu() 
        {
            //add flavor text         
            for (int i = 0; i < Manager.HealInventory.Count; i++)
            {
                Console.WriteLine(Manager.HealCountList[i] + " : " + Manager.HealInventory[i].Name);
                Console.WriteLine("Healing: Heals " + Manager.HealInventory[i].MinDamage + " to " + Manager.HealInventory[i].MaxDamage + " health.");
                Console.WriteLine("Uses: " + Manager.HealInventory[i].Durability);
                Console.WriteLine();
            }
            HealSelected();        
        }

        internal void HealSelected() 
        {
            Random random = new Random();
            CpuDamager();
            string? userInput = Console.ReadLine();
            int.TryParse(userInput, out int index);

            if (index <= Manager.HealCountList[Manager.HealCount])
            {
                int heal = random.Next(Manager.HealInventory[index].MinDamage, Manager.HealInventory[index].MaxDamage);
                
                PlayerManager.Health += heal;

                Console.WriteLine($"The Player heals, {heal} damage.");
                if (PlayerManager.Health > PlayerManager.MaxHealth)
                {
                    PlayerManager.Health = PlayerManager.MaxHealth;
                }

                PlayerManager.Health -= CPUDamage;
                Console.WriteLine($"The Figure deals, {CPUDamage} damage.");

                //flavor this
            }
            else
            {
                Console.WriteLine("not available item.");
                HealMenu();
            }
        }

        internal void ShieldMenu()
        {
            //add flavor text         
            for (int i = 0; i < Manager.ShieldInventory.Count; i++)
            {
                Console.WriteLine(Manager.ShieldCountList[i] + " : " + Manager.ShieldInventory[i].Name);
                Console.WriteLine("Blocking: Blocks " + Manager.ShieldInventory[i].MinDamage + " to " + Manager.ShieldInventory[i].MaxDamage + " damage.");
                Console.WriteLine("Uses: " + Manager.ShieldInventory[i].Durability);
                Console.WriteLine();
            }
            ShieldSelected();
        }

        internal void ShieldSelected()
        {
            Random random = new Random();
            CpuDamager();
            string? userShieldInput = Console.ReadLine();
            int.TryParse(userShieldInput, out int index);

            if (index <= Manager.ShieldCountList[Manager.ShieldCount])
            {
                int shield = random.Next(Manager.ShieldInventory[index].MinDamage, Manager.ShieldInventory[index].MaxDamage);
                
                
                CPUDamage -= shield;
                Console.WriteLine($"The Player blocks, {shield} damage.");

                Console.WriteLine(CPUDamage);

                PlayerManager.Health -= CPUDamage;
                Console.WriteLine($"The Figure deals, {CPUDamage} damage.");

                //flavor this
            }
            else
            {
                Console.WriteLine("not available item.");
                ShieldMenu();
            }
        }

        internal void CpuDamager()
        {
            Random random = new Random();
            CPUDamage = random.Next(CPUManager.MinDamage , CPUManager.MaxDamage + 1);          
        }


        internal void CombatLoop()
        {
            do 
            {
                CombatRoomSearched();
                
                if (CPUManager.Health <= 0)
                {
                    InCombat = false;
                    CPUManager.Death();
                    Console.WriteLine("The Figure takes too much damage, and slinks back into the shadows.");

                    
                   
                    //room exit code
                }

                if (PlayerManager.Health <= 0)
                {
                    InCombat = false;
                    PlayerManager.Death();
                    //GameManager.Gameover();
                }
            }
            while (InCombat == true);
        }
    }
}
