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
        }

        public string Category { get; private set; }

        public void AddLast(int index)
        {
            _questions.AddLast(Category + " Question " + index);
        }

        public void AskQuestionAndDiscard()
        {
            Console.WriteLine(_questions.First());
            _questions.RemoveFirst();
        }
    }
}