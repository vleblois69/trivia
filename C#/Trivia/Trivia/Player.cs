using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        private String name;
        private int place;

        public Player(String newName, int newPlace)
        {
            this.name = newName;
            this.place = newPlace;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String newName)
        {
            this.name = newName;
        }

        public int getPlace()
        {
            return place;
        }

        public void setPlace(int newPlace)
        {
            this.place = newPlace;
        }


        public override string ToString()
        {
            return name;
        }
   

    }
}
