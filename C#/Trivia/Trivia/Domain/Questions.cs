using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Questions
    {
        private readonly List<QuestionsStack> _categories = new List<QuestionsStack>();
        private IDispatchEvent _dispatchEvent;

        public Questions(IEnumerable<string> categories, IQuestionsRepository questionsRepository, IDispatchEvent dispatchEvent)
        {
            _dispatchEvent = dispatchEvent;
            foreach (var category in categories)
            {
                var questionsStack = new QuestionsStack(category, questionsRepository, _dispatchEvent);
                _categories.Add(questionsStack);
            }
        }

        public void AskQuestion(int currentPlayerPlace)
        {
            _dispatchEvent.Display("The category is " + _categories[currentPlayerPlace % _categories.Count].Category);
            _categories[currentPlayerPlace % _categories.Count].AskQuestionAndDiscard();
        }
    }
}