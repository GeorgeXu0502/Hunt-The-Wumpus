using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrivaMachine_Offical;

namespace TriviaMachine_Offical3
{
    public class WritingNewTriviaToFile
    {
        string Triviadatafiletouse = "TriviaQuestion.json";
        string Secretdatafiletouse = "SecretList.json";

        public void WriteTriviaToFile()
        {
            // Use this function to write the Trivia to the File for the First Time.
            // Then this file can be deleted.

            // This is the list of current trivia:
            List<TriviaQuestion> ListofTriviaToWrite = new List<TriviaQuestion>();
            List<string> TriviaQuestionAnswerOptions = new List<string>();


            TriviaQuestionAnswerOptions.Add("Elliptical.");
            TriviaQuestionAnswerOptions.Add("Spiral");
            TriviaQuestionAnswerOptions.Add("Irregular");
            TriviaQuestionAnswerOptions.Add("Cubical");
            TriviaQuestion TriviaQuestionToAdd = new TriviaQuestion("Which of the following galaxy types is most ubiquitous?", TriviaQuestionAnswerOptions, 0);
            ListofTriviaToWrite.Add(TriviaQuestionToAdd);
            Utility.WriteTriviaToFile(ListofTriviaToWrite, Triviadatafiletouse);
        }
    }
}
