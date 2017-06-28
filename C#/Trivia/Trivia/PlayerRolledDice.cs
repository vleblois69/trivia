using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class PlayerRolledDice
    {
        public string PlayerName;
        public int Roll;

        public PlayerRolledDice(string playerName, int roll)
        {
            this.PlayerName = playerName;
            this.Roll = roll;
        }
        
    }
}
