﻿using System;
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

        public bool InPenaltyBox { get; set; }
        
        public Player(string name)
        {
            Name = name;
            Place = 0;
            GoldCoins = 0;
            InPenaltyBox = false;
        }

        

        public void Move(int roll)
        {
            Place += roll;
            if (Place > 11) Place -= 12;
            Console.WriteLine(Name + "'s new location is " + Place);
        }

        public void WinAGoldCoin()
        {
            GoldCoins++;
            Console.WriteLine(Name + " now has " + GoldCoins + " Gold Coins.");
        }

        public void GoToPenaltyBox()
        {
            InPenaltyBox = true;
        }
    }
}
