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

        // The Construcutor for the File. 
        public Player_TriviaMachine()
        {
             ReadTriviaFile();
            // ReadSecretFile(); 
        }

        public void ReadTriviaFile()
        {
            // Use this Function to Read The Trivia From the File.
            ListofTriviaQuestions = Utility.ReadTriviaFromFile(Triviadatafiletouse);
        }

        public void ReadSecretFile()
        {
            ListofSecrets.Add("The Wumpus is currentlly at: ")
            // ListofSecrets = Utility.ReadSecretsFromFile(Secretdatafiletouse);
        }
        
        // Returns both the Trivia Answer and Question, contrary to the Name. 
        public TriviaQuestion GetTriviaAnswer()
        {
            // Might want to fix this in anyway possible. This just cycles the questions, could implement anything else? Like a random function, only give questions to which we have given an answer.
            if (ListTriviaQuestionIndex == ListofTriviaQuestions.Count)
            {
                ListTriviaQuestionIndex = 0;
            }

            TriviaQuestion TriviaQuestionToReturn = ListofTriviaQuestions[ListTriviaQuestionIndex];
            ListTriviaQuestionIndex++;
            return TriviaQuestionToReturn;
        }

        public string GetSecret()
        {
            // Might want to fix this in anyway possible. This just cycles the questions, could implement anything else? Like a random function, only give questions to which we have given an answer.
            if (ListSecretIndex == ListofSecrets.Count)
            {
                ListSecretIndex = 0;
            }

            string SecretToReturn = ListofSecrets[ListSecretIndex];
            ListSecretIndex++;
            return SecretToReturn;
        }

    }
}
