using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class QuestionsStack
    {
        private LinkedList<string> _questions = new LinkedList<string>();
        private IQuestionsRepository _questionsRepository;

        public QuestionsStack(string category, IQuestionsRepository questionsRepository)
        {
            Category = category;
            _questionsRepository = questionsRepository;
            _questions = _questionsRepository.Get(category);
        }
        
        public string Category { get; private set; }

        public void AskQuestionAndDiscard()
        {
            Console.WriteLine(_questions.First());
            _questions.RemoveFirst();
        }
    }
}