using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_2
{
public class Player : IPlayer
{
    public Guid Id { get; set; }
    public int Score { get; set; }
    public List<Item> Inventory { get; set; }
    public Player(){ //New constructor
        Inventory = new List<Item>();
    }

    public int GetHighestLevelItem(){
        var levels = Inventory.Select(I => I.Level).ToList();
        return levels.Max();
    }
}



}