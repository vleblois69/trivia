using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    public class GameRunner
    {

        private static bool notAWinner;

        public static void Main(String[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("-------------------------------- partie " + i);
                Game aGame = new Game();

                aGame.Add("Chet");
                aGame.Add("Pat");
                aGame.Add("Sue");


                Random rand = new Random(i);

                do
                {
                    aGame.Roll(rand.Next(5) + 1);
                    notAWinner = rand.Next(9) == 7 ? aGame.WrongAnswer() : aGame.WasCorrectlyAnswered();
                } while (notAWinner);
            }
        }
    }
}

