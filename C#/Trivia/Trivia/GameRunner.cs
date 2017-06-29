using System;

namespace Trivia
{
    public class GameRunner
    {
        private static bool winner;

        public static void Main(String[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                var consoleDisplay = new ConsoleDispatchEvent();
                var players = new Players(consoleDisplay);
                players.Add("Chet");
                players.Add("Pat");
                players.Add("Sue");

                var categories = new[] { "Pop", "Science", "Sports", "Rock" };
                var aGame = new Game(players, new Questions(categories, new GeneratedQuestions(), consoleDisplay), consoleDisplay);

                Random rand = new Random(i);

                do
                {
                    aGame.Roll(rand.Next(5) + 1);

                    if (rand.Next(9) == 7)
                    {
                        winner = aGame.WrongAnswer();
                    }
                    else
                    {
                        winner = aGame.WasCorrectlyAnswered();
                    }
                } while (!winner);
            }
        }
    }
}

