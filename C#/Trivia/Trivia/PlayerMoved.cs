using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class PlayerMoved
    {
        public string PlayerName;
        public int PlayerLocation;

        public PlayerMoved(string playerName, int playerLocation)
        {
            this.PlayerName = playerName;
            this.PlayerLocation = playerLocation;
        }
    }
}
