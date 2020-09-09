using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_2
{
    public class ItemsProcessor
    {
        
        public Item[] GetItems(Player player){
            Item [] itemArray = new Item[player.Inventory.Count];
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                itemArray[i] = player.Inventory[i];
            }
            return itemArray;
        }

        public Item[] GetItemsWithLinq(Player player){
            try{
            return player.Inventory.ToArray();
            }
            catch (NullReferenceException e){
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Item FirstItem(Player player) {
            try{
            return player.Inventory[0];
            }
            catch (NullReferenceException e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Item FIrstItemWithLinq ( Player player) {
            try {
                return player.Inventory.First();
            }
            catch (NullReferenceException e){
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public void ProcessEachItem(Player player, Action<Item> process)
        {
            foreach (var item in player.Inventory)
            {
             process(item);    
            }
              

        }

        public void PrintItem(Item item) 
        {
            Console.WriteLine(item.Id.ToString());
            Console.WriteLine(item.Level.ToString());



/*             var levels = player.Inventory.Select(I => I.Level).ToList();
            var ids = player.Inventory.Select(I => I.Id).ToList();
            foreach (var item in levels)
            {
                Console.WriteLine("/n" + item.ToString());
            }
            foreach (var item2 in ids)
            {
                Console.WriteLine("/n" + item2.ToString());
            } */
        }



    }
}