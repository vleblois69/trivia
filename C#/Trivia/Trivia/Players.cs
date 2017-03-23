using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    public class Players
    {
        private List<Player> _players { get; set; }

        public Player Current { get; private set; }

        public bool Add(string playerName)
        {
            var player = new Player(playerName);

            if (_players == null)
            {
                _players = new List<Player>();
                Current = player;
            }

            _players.Add(player);

            Console.WriteLine(playerName + " was added");
            Console.WriteLine("They are player number " + _players.Count);
            return true;
        }

        public void NextPlayer()
        {
            var nextPlayer = _players.IndexOf(Current) + 1;
            if (nextPlayer == _players.Count)
                nextPlayer = 0;
            Current = _players[nextPlayer];
        }

    }
}
