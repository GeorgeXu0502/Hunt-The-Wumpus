using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivaMachine_Offical
{
    /// <summary>
    /// holds all the trivia question/answer data
    /// </summary>
    public class TriviaQuestion
    {

        // It might be of reference to in the future, add a Trivia Question Refrence Number. However this would require additional work. 

        /// <summary>
        /// the trivia questions
        /// </summary>
        public string QuestionTrivia  { get; set; }

        /// <summary>
        ///lists of possible question answers for each question
        /// </summary>
        public List<string> PossibleAnswers { get;} // Something to change the name. 

        /// <summary>
        /// the index of the correct answer
        /// </summary>
        public int CorrectAnswerIndex { get; set; } // The First Answer has index 0.

        /// <summary>
        /// constructor for the the question, possible answers, and correct answer index
        /// </summary>
        /// <param name="questionTrivia"></param>
        /// <param name="possibleAnswers"></param>
        /// <param name="correctAnswerIndex"></param>
        public TriviaQuestion(string questionTrivia, List<string> possibleAnswers, int correctAnswerIndex)
        {
            QuestionTrivia = questionTrivia;
            PossibleAnswers = possibleAnswers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
