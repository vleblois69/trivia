using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        public string Name { get; set; }

        public int Place { get; private set; }

        public int GoldCoins { get; private set; }
        
        public Player(string name)
        {
            Name = name;
            Place = 0;
            GoldCoins = 0;
        }

        public void Move(int roll)
        {
            Place += roll;
            if (Place > 11) Place -= 12;
        }

        public void WinAGoldCoin()
        {
            GoldCoins++;
        }
    }
}
