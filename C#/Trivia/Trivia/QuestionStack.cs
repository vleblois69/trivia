using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class QuestionStack
    {
        private LinkedList<string> questions = new LinkedList<string>();
        private string category;

        public QuestionStack(string category)
        {
            this.category = category;
        }


        public void Generate(int indexQuestion)
        {
            questions.AddLast(category + " Question " + indexQuestion);
        }

        public void PickAndReadAQuestion()
        {
            Console.WriteLine(questions.First());
            questions.RemoveFirst();
        }
    }
}
