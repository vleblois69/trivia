using System.Collections.Generic;

namespace Trivia
{
    public class GeneratedQuestions : IQuestionsRepository
    {
        public LinkedList<string> Get(string category)
        {
            var questions = new LinkedList<string>();
            for (var i = 0; i < 50; i++)
            {
                questions.AddLast(category + " Question " + i);
            }
            return questions;
        }
    }
}