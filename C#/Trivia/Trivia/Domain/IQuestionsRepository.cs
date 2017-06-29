using System.Collections.Generic;

namespace Trivia
{
    public interface IQuestionsRepository
    {
        LinkedList<string> Get(string category);
    }
}