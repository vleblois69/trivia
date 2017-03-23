using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        public String Name { get; set; }

        public int Place { get; set; }

        public int Purse { get; set; }
        
        public Player(String newName, int newPlace, int newPurse)
        {
            this.Name = newName;
            this.Place = newPlace;
            this.Purse = newPurse;
        }

    }
}
