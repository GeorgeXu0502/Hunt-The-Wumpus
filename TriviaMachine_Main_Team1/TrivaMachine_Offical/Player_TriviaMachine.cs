using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivaMachine_Offical
{
    public class Player_TriviaMachine
    {
        string datafiletouse = "TriviaQuestion.json";
        // List of Trivia Questions and Secrets.
        List<TriviaQuestion> ListofTriviaQuestions = new List<TriviaQuestion>();
        List<string> ListofSecrets = new List<string>();

        int ListTriviaQuestionIndex = 0; // This Index is Used to Monitor The Questions.

        public void WriteTriviaToFile()
        {
            // Use this function to write the Trivia to the File for the First Time.
            // Then this file can be deleted.
        }

        //IMPLEMENT THIS AND WRITE TO FILE FIRST!
        public void ReadTriviaFile()
        {
            // Use this Function to Read The Trivia From the File.
            ListofTriviaQuestions = Utility.Readfromfile(datafiletouse);
        }

        public TriviaQuestion GetTriviaAnswer()
        {
            TriviaQuestion TriviaQuestionToReturn = ListofTriviaQuestions[ListTriviaQuestionIndex];
            ListTriviaQuestionIndex++;
            return TriviaQuestionToReturn;
        }

        public string GetSecret()
        {
            //return a secret
            return "";
        }

    }
}
