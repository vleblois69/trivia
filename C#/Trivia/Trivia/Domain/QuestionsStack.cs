using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class QuestionsStack
    {
        private LinkedList<string> _questions = new LinkedList<string>();
        private IQuestionsRepository _questionsRepository;
        private readonly IDispatchEvent _dispatchEvent;

        public QuestionsStack(string category, IQuestionsRepository questionsRepository, IDispatchEvent dispatchEvent)
        {
            Category = category;
            _questionsRepository = questionsRepository;
            _dispatchEvent = dispatchEvent;
            _questions = _questionsRepository.Get(category);
        }
        
        public string Category { get; private set; }

        public void AskQuestionAndDiscard()
        {
            _dispatchEvent.Display(_questions.First());
            _questions.RemoveFirst();
        }
    }
}