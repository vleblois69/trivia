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
        
        public Player(string newName, int newPlace, int newPurse)
        {
            Name = newName;
            Place = newPlace;
            Purse = newPurse;
        }

    }
}
