using DungeonCrawlerAssignment.Player_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerAssignment
{
    internal class TreasureRoom
    {           
        public void TreasureRoomSearch()
        {
            ItemManager itemManager = new ItemManager();
            //add flavor text before and after code
            itemManager.ItemRandomizer();
            itemManager.ShieldItemRandomizer();
        }
    }
}
