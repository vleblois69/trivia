using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class QuestionsStack
    {
        private LinkedList<string> _questions = new LinkedList<string>();

        public QuestionsStack(string category)
        {
            Category = category;
            GenerateQuestions();
        }

        public void GenerateQuestions()
        {
            for (var i = 0; i < 50; i++)
            {
                _questions.AddLast(Category + " Question " + i);
            }
        }

        public string Category { get; private set; }

        public void AskQuestionAndDiscard()
        {
            Console.WriteLine(_questions.First());
            _questions.RemoveFirst();
        }
    }
}