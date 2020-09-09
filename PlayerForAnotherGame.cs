using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_2 {

    public class PlayerForAnotherGame : IPlayer {
    public Guid Id { get; set; }
    public int Score { get; set; }
    public List<Item> Inventory { get; set; }
    public PlayerForAnotherGame(){ //New constructor
        Inventory = new List<Item>();
    }

    }

}