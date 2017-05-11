using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class Questions
    {
        private readonly Dictionary<int, QuestionsStack> _categories = new Dictionary<int, QuestionsStack>()
        {
            { 0, new QuestionsStack("Pop") }, 
            { 1, new QuestionsStack("Science") }, 
            { 2, new QuestionsStack("Sports") }, 
            { 3, new QuestionsStack("Rock") }
        };
        
        public Questions()
        {
            GenerateQuestions();
        }

        private void GenerateQuestions()
        {
            for (var i = 0; i < 50; i++)
            {
                foreach (var questionsStack in _categories)
                {
                    questionsStack.Value.AddLast(i);
                }
            }
        }

        public void AskQuestion(int currentPlayerPlace)
        {
            Console.WriteLine("The category is " + _categories[currentPlayerPlace % 4].Category);
            _categories[currentPlayerPlace % 4].AskQuestionAndDiscard();
        }
    }
}