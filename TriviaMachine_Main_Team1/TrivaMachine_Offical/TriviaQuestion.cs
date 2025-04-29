using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivaMachine_Offical
{
    public class TriviaQuestion
    {
        public string QuestionTrivia  { get; set; }

        public List<String> PossibleAnswers { get; set; }

        public int CorrectAnswerIndex { get; set; }

        public TriviaQuestion(string questionTrivia, List<string> possibleAnswers, int correctAnswerIndex)
        {
            QuestionTrivia = questionTrivia;
            PossibleAnswers = possibleAnswers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
