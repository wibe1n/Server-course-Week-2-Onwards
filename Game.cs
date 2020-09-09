using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_2 {

public class Game<T> where T : IPlayer
{
    private List<T> _players;

    public Game(List<T> players) {
        _players = players;
    }

    public T[] GetTop10Players() {
        var result = _players.OrderBy(t => t.Score).Take(10);
        T[] topPlayers = new T[10];
        topPlayers = result.ToArray();
        return topPlayers;
    }
}
}