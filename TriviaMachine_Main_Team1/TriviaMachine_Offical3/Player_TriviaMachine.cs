using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TriviaMachine_Offical3;

namespace TrivaMachine_Offical
{
    public class Player_TriviaMachine
    {
        string Triviadatafiletouse = "TriviaQuestion.json";
        string Secretdatafiletouse = "SecretList.json";
        // List of Trivia Questions and Secrets.
        List<TriviaQuestion> ListofTriviaQuestions = new List<TriviaQuestion>();
        List<SecretObject> ListofSecrets = new List<SecretObject>();

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

        public SecretObject GetSecret()
        {
            // Might want to fix this in anyway possible. This just cycles the questions, could implement anything else? Like a random function, only give questions to which we have given an answer.
            if (ListSecretIndex == ListofSecrets.Count)
            {
                ListSecretIndex = 0;
            }

            SecretObject SecretToReturn = ListofSecrets[ListSecretIndex];
            ListSecretIndex++;
            return SecretToReturn;
        }

    }
}
