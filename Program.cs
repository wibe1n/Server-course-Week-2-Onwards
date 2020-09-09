using System;
using System.Linq;

namespace Week_2
{
    class Program
    {
        public delegate void PrintItem(Item item);

        static void Main(string[] args)
        {
            
            PlayersProcessor playerProcessor = new PlayersProcessor();
            ItemsProcessor itemsProcessor = new ItemsProcessor();
            //Teht 1.
            var list = playerProcessor.Create(15);
            if (playerProcessor.CheckDublicates(list)){
                Console.WriteLine("Duplicates found");
            }
            else{
                Console.WriteLine("No Duplicates found");
            }
            //Teht 2.
            var list2 = playerProcessor.Create(1);
            Player hoarder = list2[0];
            for (int i = 0; i < 10; i++)
            {
             Item item = new Item();
             item.Id = Guid.NewGuid();
             Random rnd = new Random();
             int level = rnd.Next(50);
             item.Level = level;
             hoarder.Inventory.Add(item); 
            }            
            Console.WriteLine(hoarder.GetHighestLevelItem());
            //Teht 3.
            Console.WriteLine(itemsProcessor.GetItems(hoarder));
            Console.WriteLine(itemsProcessor.GetItemsWithLinq(hoarder));
            //Teht 4.
            Console.WriteLine(itemsProcessor.FirstItem(hoarder));
            Console.WriteLine(itemsProcessor.FIrstItemWithLinq(hoarder));
            //Teht 5.
            Action<Item> printfunction = itemsProcessor.PrintItem;
            itemsProcessor.ProcessEachItem(hoarder, printfunction);
            //Teht 6.
            Action<Item> printfuction2 = item => {
            Console.WriteLine(item.Id.ToString());
            Console.WriteLine(item.Level.ToString());
            };
            itemsProcessor.ProcessEachItem(hoarder, printfuction2);

        }
    }
}
