using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Players
    {
        private readonly List<Player> _players = new List<Player>();
        private IDispatchEvent _dispatchEvent;

        public Players(IDispatchEvent dispatchEvent)
        {
            _dispatchEvent = dispatchEvent;
        }

        public Player Current { get; private set; }

        public void NextPlayer()
        {
            var nextPlayer = _players.IndexOf(Current) + 1;
            if (nextPlayer == _players.Count) nextPlayer = 0;
            Current = _players[nextPlayer];
        }

        public bool Add(string playerName)
        {
            var player = new Player(playerName, _dispatchEvent);
            if (!_players.Any())
            {
                Current = player;
            }
            _players.Add(player);

            _dispatchEvent.Display(playerName + " was added");
            _dispatchEvent.Display("They are player number " + _players.Count);
            return true;
        }
    }
}
