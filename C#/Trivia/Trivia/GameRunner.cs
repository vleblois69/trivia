using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    public class GameRunner
    {

        private static bool Winner;

        public static void Main(String[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("-------------------------------- partie " + i);

                var players = new Players();
                players.Add("Chet");
                players.Add("Pat");
                players.Add("Sue");

                var aGame = new Game(players);

                Random rand = new Random(i);

                do
                {
                    aGame.Roll(rand.Next(5) + 1);
                    Winner = rand.Next(9) == 7 ? aGame.WrongAnswer() : aGame.WasCorrectlyAnswered();
                } while (!Winner);
            }
        }
    }
}

