using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrivaMachine_Offical
{
    public class Player_TriviaMachine
    {
        string Triviadatafiletouse = "TriviaQuestion.json";
        string Secretdatafiletouse = "SecretList.json";
        // List of Trivia Questions and Secrets.
        List<TriviaQuestion> ListofTriviaQuestions = new List<TriviaQuestion>();
        List<string> ListofSecrets = new List<string>();

        int ListTriviaQuestionIndex = 0; // This Index is Used to Monitor The Questions.
        int ListSecretIndex = 0; //This Index is Used to Monitor the Secrets.

        
        public void WriteSecretToFile()
        {
            // Use this function to write the Secret to the File for the First Time.
            // Then this file can be deleted.
        }

        //IMPLEMENT THIS AND WRITE TO FILE FIRST!
        public void ReadTriviaFile()
        {
            // Use this Function to Read The Trivia From the File.
            ListofTriviaQuestions = Utility.ReadTriviaFromFile(Triviadatafiletouse);
        }

        public void ReadSecretFile()
        {
            ListofSecrets = Utility.ReadSecretsFromFile(Secretdatafiletouse);

        }
        public TriviaQuestion GetTriviaAnswer()
        {
            TriviaQuestion TriviaQuestionToReturn = ListofTriviaQuestions[ListTriviaQuestionIndex];
            ListTriviaQuestionIndex++;
            return TriviaQuestionToReturn;
        }

        public string GetSecret()
        {
            string SecretToReturn = ListofSecrets[ListSecretIndex];
            ListSecretIndex++;
            return SecretToReturn;
        }

    }
}
