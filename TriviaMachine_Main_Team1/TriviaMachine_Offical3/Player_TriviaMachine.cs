using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TriviaMachine_Offical3;

namespace TrivaMachine_Offical
{
    /// <summary>
    /// the trivia machine stores and returns questions, and does all trivia-related tasks
    /// </summary>
    public class Player_TriviaMachine
    {
        //this is how long we are pretending the trivia array is
        //the purpose of this is that it means we no longer have repeating questions
        int virtualTriviaLength;

        string Triviadatafiletouse = "TriviaQuestion.json";
        string Secretdatafiletouse = "SecretList.json";
        // List of Trivia Questions and Secrets.
        List<TriviaQuestion> ListofTriviaQuestions = new List<TriviaQuestion>();
        List<SecretObject> ListofSecrets = new List<SecretObject>();
        List<int> ListofQuestionsIndexesAlreadyAsked = new List<int>();

        int ListTriviaQuestionIndex = 0; // This Index is Used to Monitor The Questions.

    /// <summary>
    /// the constructor for the file
    /// </summary>
        public Player_TriviaMachine()
        {
            ReadTriviaFile();
            ReadSecretFile(); 
        }

    /// <summary>
    /// this method writes all secret options to the json
    /// </summary>
        public void WriteSecretsToFile()
        {
            List<SecretObject> ListtoWriteToFile = new List<SecretObject>();
            SecretObject SecrectObject1 = new SecretObject("The Wumpus is currently in room: ", 0);
            SecretObject SecrectObject2 = new SecretObject("The Pit is currently in room: ", 1);
            SecretObject SecrectObject3 = new SecretObject("Some Bat is currently in room: ", 2);
            SecretObject SecrectObject4 = new SecretObject("The Wumpus is currently X rooms away from you. Where X is: ", 3);
            SecretObject SecrectObject5 = new SecretObject("A Pit is currently X rooms away from you. Where X is: ", 4);
            SecretObject SecrectObject6 = new SecretObject("You are currently in room: ", 5);
            SecretObject SecrectObject7 = new SecretObject("One answer to a interseting Trivia Question will apear soon as your secret. ", 6);
            SecretObject SecrectObject8 = new SecretObject("One answer to a interseting Trivia Question will apear soon as your secret. ", 7);

            ListtoWriteToFile.Add(SecrectObject1);
            ListtoWriteToFile.Add(SecrectObject2);
            ListtoWriteToFile.Add(SecrectObject3);
            ListtoWriteToFile.Add(SecrectObject4);
            ListtoWriteToFile.Add(SecrectObject5);
            ListtoWriteToFile.Add(SecrectObject6);
            ListtoWriteToFile.Add(SecrectObject7);
            ListtoWriteToFile.Add(SecrectObject8);

            Utility.WriteSecretToFile(ListtoWriteToFile, Secretdatafiletouse);
        }

       /// <summary>
       /// reads the trivia file
       /// </summary>
        public void ReadTriviaFile()
        {
            // Use this Function to Read The Trivia From the File.
            ListofTriviaQuestions = Utility.ReadTriviaFromFile(Triviadatafiletouse);
            //sets the virtual trivia length to what the ctual trivia length is when the program is initially loaded
            virtualTriviaLength = ListofTriviaQuestions.Count;
        }

        /// <summary>
        /// reads the secret file (contains hints)
        /// </summary>
        public void ReadSecretFile()
        {
            ListofSecrets = Utility.ReadSecretsFromFile(Secretdatafiletouse);
        }

        /// <summary>
        /// Returns both the Trivia Answer and Question, contrary to the Name. 
        /// </summary>
        /// <returns></returns>
        public TriviaQuestion GetTriviaAnswer()
        {
            Random RandomCaller = new Random();
            int QuestionIndexToAsk = RandomCaller.Next(0, virtualTriviaLength - 1);

            while (ListofQuestionsIndexesAlreadyAsked.Contains(QuestionIndexToAsk))
            {
                QuestionIndexToAsk = RandomCaller.Next(0, virtualTriviaLength - 1);
            }

            ListofQuestionsIndexesAlreadyAsked.Add(QuestionIndexToAsk);

            if (ListofQuestionsIndexesAlreadyAsked.Count == virtualTriviaLength)
            {
                ListofQuestionsIndexesAlreadyAsked.Clear();
            }

            TriviaQuestion TriviaQautionToUse = ListofTriviaQuestions[QuestionIndexToAsk];
            string CorrectAnswer = TriviaQautionToUse.PossibleAnswers[0];
            List<string> ShuffeledAnswersList = ShuffleAnswers(TriviaQautionToUse.PossibleAnswers);
            int IndexofCorrectAnswer = ShuffeledAnswersList.IndexOf(CorrectAnswer);
            TriviaQuestion TriviaQuestionToReturn = new TriviaQuestion(TriviaQautionToUse.QuestionTrivia, ShuffeledAnswersList, IndexofCorrectAnswer);
            return TriviaQuestionToReturn;
        }

        /// <summary>
        /// shuffles trivia answer options
        /// </summary>
        /// <param name="PossibleanswerToUse"></param>
        /// <returns></returns>
        public List<string> ShuffleAnswers(List<string> PossibleanswerToUse)
        {
            List<string> StringListToReturn = new List<string>();
            Random RandomCaller2 = new Random();
            int Number1 = RandomCaller2.Next(4);
            int Number2 = RandomCaller2.Next(4);

            while (Number2 == Number1)
            {
                Number2 = RandomCaller2.Next(0, 4);
            }

            StringListToReturn.Add(PossibleanswerToUse[Number1]);
            StringListToReturn.Add(PossibleanswerToUse[Number2]);

            List<int> IntegersNotUsedYet = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                if (i != Number1 && i!= Number2)
                {
                    IntegersNotUsedYet.Add(i);
                }
            }

            int Number3 = RandomCaller2.Next(2);
            if (Number3 == 0)
            {
                StringListToReturn.Add(PossibleanswerToUse[IntegersNotUsedYet[0]]);
                StringListToReturn.Add(PossibleanswerToUse[IntegersNotUsedYet[1]]);
            }
            else
            {
                StringListToReturn.Add(PossibleanswerToUse[IntegersNotUsedYet[1]]);
                StringListToReturn.Add(PossibleanswerToUse[IntegersNotUsedYet[0]]);
            }
                return StringListToReturn;
        }

        /// <summary>
        /// returns a random secret
        /// </summary>
        /// <returns></returns>
        public SecretObject GetSecret()
        {
            Random RandomObject = new Random();
            int RandomInteger = RandomObject.Next(0, 8);

            return ListofSecrets[RandomInteger];
        }

    }
}
