using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        public string Name { get; set; }

        public int Place { get; set; }

        public int Purse { get; set; }
        
        public Player(string newName, int newPurse)
        {
            Name = newName;
            Place = 0;
            Purse = newPurse;
        }

        public void Move(int roll)
        {
            Place += roll;
            if (Place > 11) Place -= 12;
        }
    }
}
