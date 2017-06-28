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

        public void Dispatch<TEvent>(TEvent evenement)
        {
            if (evenement is string)
            {
                Console.WriteLine(evenement);
            }
            else if (evenement is PlayerRolledDice)
            {
                Console.WriteLine((evenement as PlayerRolledDice).PlayerName + " is the current player");
                Console.WriteLine("They have rolled a " + (evenement as PlayerRolledDice).Roll);
            }
            else if (evenement is PlayerMoved)
            {
                Console.WriteLine((evenement as PlayerMoved).PlayerName
                         + "'s new location is "
                         + (evenement as PlayerMoved).PlayerLocation);
            }
            else if (evenement is PlayerGotOutOfPenaltyBox)
            {
                Console.WriteLine((evenement as PlayerGotOutOfPenaltyBox).PlayerName + " is getting out of the penalty box");
            }
            else if (evenement is PlayerDidntGetOutOfPenaltyBox)
            {
                Console.WriteLine((evenement as PlayerDidntGetOutOfPenaltyBox).PlayerName + " is not getting out of the penalty box");
            }
            else if (evenement is PlayerSentToPenaltyBox)
            {
                Console.WriteLine((evenement as PlayerSentToPenaltyBox).PlayerName + " was sent to the penalty box");
            }
        }
    }
}
