using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivaMachine_Offical
{
    public class TriviaQuestion
    {

        // It might be of reference to in the future, add a Trivia Question Refrence Number. However this would require additional work. 
        public string QuestionTrivia  { get; set; }

        public List<string> PossibleAnswers { get;} // Something to change the name. 

        public int CorrectAnswerIndex { get; set; } // The First Answer has index 0.

        public TriviaQuestion(string questionTrivia, List<string> possibleAnswers, int correctAnswerIndex)
        {
            QuestionTrivia = questionTrivia;
            PossibleAnswers = possibleAnswers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
