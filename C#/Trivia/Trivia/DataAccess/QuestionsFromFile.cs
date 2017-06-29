using System.Collections.Generic;
using System.IO;

namespace Trivia
{
    class QuestionsFromFile : IQuestionsRepository
    {
        public LinkedList<string> Get(string category)
        {
            var questions = new LinkedList<string>();
            using (var fileStream = File.OpenRead(category))
            using(var streamReader = new StreamReader(fileStream))
            {
                while (streamReader.EndOfStream)
                {
                    questions.AddLast(streamReader.ReadLine());
                }
            }
            return questions;
        }
    }
}