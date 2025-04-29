using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaMachine_Test
{
    public class TriviaAnswer2
    {
        public string TriviaQuestion { get; set; }

        public string CorrectAnswer { get; set; }

        public TriviaAnswer2(string triviaQuestion, string correctAnswer)
        {
            TriviaQuestion = triviaQuestion;
            CorrectAnswer = correctAnswer;
        }
    }
}
