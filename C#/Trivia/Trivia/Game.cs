using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Game
    {   
        private readonly Players _players;

        private readonly Questions _questions;

        private readonly IDispatchEvent _eventDispatcher;

        bool isGettingOutOfPenaltyBox;


        public Game(Players players, Questions questions, IDispatchEvent eventDispatcher)
        {
            _players = players;
            _questions = questions;
            _eventDispatcher = eventDispatcher;
        }

        public void Roll(int roll)
        {
            _eventDispatcher.Dispatch(new PlayerRolledDice(_players.Current.Name, roll));
            if (_players.Current.InPenaltyBox)
            {
                if (roll % 2 != 0)
                {
                    isGettingOutOfPenaltyBox = true;

                    _eventDispatcher.Dispatch(new PlayerGotOutOfPenaltyBox(_players.Current.Name));
                    _players.Current.Move(roll);

                   _eventDispatcher.Dispatch(new PlayerMoved(_players.Current.Name, _players.Current.Place));
                }
                else
                {
                    _eventDispatcher.Dispatch(new PlayerDidntGetOutOfPenaltyBox(_players.Current.Name));
                    isGettingOutOfPenaltyBox = false;
                }

            }
            else
            {
                _players.Current.Move(roll);
                _eventDispatcher.Dispatch(new PlayerMoved(_players.Current.Name, _players.Current.Place));
                _questions.AskQuestion(_players.Current.Place);
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
            _eventDispatcher.Dispatch(new PlayerSentToPenaltyBox(_players.Current.Name));
            _players.Current.GoToPenaltyBox();

            _players.NextPlayer();
            return false;
        }
    }
}
