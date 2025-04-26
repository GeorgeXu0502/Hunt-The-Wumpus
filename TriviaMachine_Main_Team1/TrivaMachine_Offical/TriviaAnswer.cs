using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivaMachine_Offical
{
    public class TriviaAnswer
    {
        public string TriviaQuestion { get; set; }

        public string CorrectAnswer { get; set; }

        public TriviaAnswer(string triviaQuestion, string correctAnswer)
        {
            TriviaQuestion = triviaQuestion;
            CorrectAnswer = correctAnswer;
        }
    }
}
