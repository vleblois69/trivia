using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        private String name;

        public Player(String newName)
        {
            this.name = newName;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String newName)
        {
            this.name = newName;
        }

        public override string ToString()
        {
            return name;
        }
   

    }
}
