using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Game
    {
        private readonly Dictionary<int, string> _categories = new Dictionary<int, string>() { { 0, "Pop" }, { 1, "Science" }, { 2, "Sports" }, { 3, "Rock" } };

        QuestionStack popQuestions = new QuestionStack("Pop");
        QuestionStack scienceQuestions = new QuestionStack("Science");
        QuestionStack sportsQuestions = new QuestionStack("Sports");
        QuestionStack rockQuestions = new QuestionStack("Rock");

        private readonly Players _players;

        public Game(Players players)
        {
            _players = players;
            for (var i = 0; i < 50; i++)
            {
                popQuestions.Generate(i);
                scienceQuestions.Generate(i);
                sportsQuestions.Generate(i);
                rockQuestions.Generate(i);
            }
        }

        public bool WasCorrectlyAnswered()
        {
            bool winner;
            if (_players.Current.InPenaltyBox)
            {
                if (isGettingOutOfPenaltyBox)
                {
                    Console.WriteLine("Answer was correct!!!!");
                    _players.Current.WinAGoldCoin();

                    winner = _players.Current.IsWinner();
                    _players.NextPlayer();

                    return winner;
                }

                _players.NextPlayer();
                return false;
            }

            Console.WriteLine("Answer was corrent!!!!");
            _players.Current.WinAGoldCoin();

            winner = _players.Current.IsWinner();
            _players.NextPlayer();

            return winner;
        }

        public bool WrongAnswer()
        {
            Console.WriteLine("Question was incorrectly answered");
            Console.WriteLine(_players.Current.Name + " was sent to the penalty box");
            _players.Current.GoToPenaltyBox();

            _players.NextPlayer();
            return false;
        }

        bool isGettingOutOfPenaltyBox;

        private string CurrentCategory()
        {
            return _categories[_players.Current.Place % 4];
        }


        private void AskQuestion()
        {
            if (CurrentCategory() == "Pop")
            {
                popQuestions.PickAndReadAQuestion();
            }
            if (CurrentCategory() == "Science")
            {
                scienceQuestions.PickAndReadAQuestion();
            }
            if (CurrentCategory() == "Sports")
            {
                sportsQuestions.PickAndReadAQuestion();
            }
            if (CurrentCategory() == "Rock")
            {
                rockQuestions.PickAndReadAQuestion();
            }
        }

        public void Roll(int roll)
        {
            Console.WriteLine(_players.Current.Name + " is the current player");
            Console.WriteLine("They have rolled a " + roll);

            if (_players.Current.InPenaltyBox)
            {
                if (roll % 2 != 0)
                {
                    isGettingOutOfPenaltyBox = true;

                    Console.WriteLine(_players.Current.Name + " is getting out of the penalty box");
                    _players.Current.Move(roll);

                    Console.WriteLine(_players.Current.Name
                            + "'s new location is "
                            + _players.Current.Place);
                    Console.WriteLine("The category is " + CurrentCategory());
                    AskQuestion();
                }
                else
                {
                    Console.WriteLine(_players.Current.Name + " is not getting out of the penalty box");
                    isGettingOutOfPenaltyBox = false;
                }

            }
            else
            {
                _players.Current.Move(roll);

                Console.WriteLine(_players.Current.Name
                        + "'s new location is "
                        + _players.Current.Place);
                Console.WriteLine("The category is " + CurrentCategory());
                AskQuestion();
            }

        }

        
    }
}
