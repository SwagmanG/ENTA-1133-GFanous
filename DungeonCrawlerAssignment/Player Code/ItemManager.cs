using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerAssignment.Player_Code
{
    public class ItemManager
    {
        Item Pipe = new RustyPipe();
        Item Knife = new RustyKitchenKnife();
        Item Post = new Bedpost();
        Item Bat = new WoodenBat();
        Item Guitar = new OldGuitar();
        Item Light = new GlassTubeLight();
        //declaring and assigning inherited class stuff for weapons

        Item Chair = new WoodenChair();
        Item PanLid = new MetalPanLid();
        Item Board = new PlywoodBoard();
        //declaring and assigning inherited class stuff for shields

        Item HealItemCommon = new Clozapine();
        Item HealItemUncommon = new Olanzapine();
        Item HealItemRare; 
        //declaring amd assigning inherited calss stuff for healing items

        public int HealItemAmount = 3;
        public int HealCount = -1;

        public List<int> HealCountList = new List<int>();
        public List<Item> HealInventory = new List<Item>();

        public int ShieldAmount = 3;
        public int ShieldCount = -1;

        public List<int> ShieldCountList = new List<int>();
        public List<Item> ShieldInventory = new List<Item>();

        public int WeaponAmount = 6;
        public int WeaponCount = -1;

        public List<int> WeaponCountList = new List<int>();
        public List<Item> WeaponInventory = new List<Item>();


        public void ItemRandomizer()
        {
            Random random = new Random();
            
            
            
            int randomWeapon = random.Next(0, WeaponAmount);
            switch (randomWeapon)
                {
                    case (int)Weapon.RustyPipe:

                        WeaponInventory.Add(Pipe);
                        WeaponCount++;
                        WeaponCountList.Add(WeaponCount);

                    break;

                    case (int)Weapon.RustyKnife:

                        WeaponInventory.Add(Knife);
                        WeaponCount++;
                        WeaponCountList.Add(WeaponCount);

                        break;

                    case (int)Weapon.Bedpost:

                        WeaponInventory.Add(Post);
                        WeaponCount++;
                        WeaponCountList.Add(WeaponCount);

                        break;

                    case (int)Weapon.WoodenBat:

                        WeaponInventory.Add(Bat);
                        WeaponCount++;
                        WeaponCountList.Add(WeaponCount);

                        break;

                    case (int)Weapon.OldGuitar:

                        WeaponInventory.Add(Guitar);
                        WeaponCount++;
                        WeaponCountList.Add(WeaponCount);

                        break;

                    case (int)Weapon.GlassTubeLight:

                        WeaponInventory.Add(Light);
                        WeaponCount++;
                        WeaponCountList.Add(WeaponCount);

                        break;

                    




                }                     
        }

        public void HealItemRandomizer()
        {
            Random random = new Random();
            int randomHealItem = random.Next(0, HealItemAmount);

            switch (randomHealItem)
            {
                case (int)Heal.Olanzapine:

                    HealInventory.Add(HealItemUncommon);
                    HealCount++;
                    HealCountList.Add(HealCount);

                    break;

                case (int)Heal.Clozapine:

                    HealInventory.Add(HealItemCommon);
                    HealCount++;
                    HealCountList.Add(HealCount);

                    break;

                case (int)Heal.Risperidone:
                    HealItemRare = new Risperidone();
                    HealInventory.Add(HealItemRare);
                    HealCount++;
                    HealCountList.Add(HealCount);

                    break;
            }
        }

        public void ShieldItemRandomizer()
        {
            Random random = new Random();

            int randomShield = random.Next(0, ShieldAmount);
            switch (randomShield)
            {
                case (int)Shield.PlywoodBoard:

                    ShieldInventory.Add(Board);
                    ShieldCount++;
                    ShieldCountList.Add(ShieldCount);

                    break;

                case (int)Shield.WoodenChair:

                    ShieldInventory.Add(Chair);
                    ShieldCount++;
                    ShieldCountList.Add(ShieldCount);

                    break;

                case (int)Shield.MetalPanLid:

                    ShieldInventory.Add(PanLid);
                    ShieldCount++;
                    ShieldCountList.Add(ShieldCount);
                    break;







            }
        }
 
    }
}
