using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_2
{
    public class PlayersProcessor {
        public List<Player> Create(int amount) {
            var list = new List<Player>();
            for (int i = 0; i < amount; i++)
            {
             Player createdPlayer = new Player();
             createdPlayer.Id = Guid.NewGuid();
             list.Add(createdPlayer);   
            }
            return list;
        }

        public bool CheckDublicates(List<Player> players){
            var query = players.GroupBy(x => x.Id)
              .Where(z => z.Count() > 1)
              .Select(y => y.Key)
              .ToList();
              if (query.Count() > 1){
                  return true;
              }
              else return false;
        }

    }
}