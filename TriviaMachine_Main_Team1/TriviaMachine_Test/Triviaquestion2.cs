using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaMachine_Test
{
    public class Triviaquestion2
    {
            public string QuestionTrivia { get; set; }

            public List<String> PossibleAnswers { get; set; }

            public int CorrectAnswerIndex { get; set; }

            public Triviaquestion2(string questionTrivia, List<string> possibleAnswers, int correctAnswerIndex)
            {
                QuestionTrivia = questionTrivia;
                PossibleAnswers = possibleAnswers;
                CorrectAnswerIndex = correctAnswerIndex;
            }
    }
}
