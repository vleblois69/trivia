using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class ConsoleDispatchEvent : IDispatchEvent
    {
        public void Display(string displayedString)
        {
            Console.WriteLine(displayedString);
        }

        public void Dispatch<TEvent>(TEvent playerRolledDice)
        {
            if (playerRolledDice is string)
            {
                Console.WriteLine(playerRolledDice);
            }
            else if (playerRolledDice is PlayerRolledDice)
            {
                Console.WriteLine((playerRolledDice as PlayerRolledDice).PlayerName + " is the current player");
                Console.WriteLine("They have rolled a " + (playerRolledDice as PlayerRolledDice).Roll);
            }
        }
    }
}
