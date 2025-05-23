using System;
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
        TriviaQuestion[] ListofTriviaQuestions;
        List<SecretObject> ListofSecrets = new List<SecretObject>();

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
            ListofTriviaQuestions = Utility.ReadTriviaFromFile(Triviadatafiletouse).ToArray();
            //sets the virtual trivia length to what the ctual trivia length is when the program is initially loaded
            virtualTriviaLength = ListofTriviaQuestions.Length;
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
            //generates random number which corresponds to trivia question

            Random random = new Random();
            ListTriviaQuestionIndex = random.Next(0,virtualTriviaLength);

            //calls the shuffleanswers method to shuffle the answer options before returning
            TriviaQuestion TriviaQuestionUnordered = ListofTriviaQuestions[ListTriviaQuestionIndex];

            //replacing the used question with the last question in the array and shortenning the virtual length
            //this is to prevent repeating questions
            ListofTriviaQuestions[ListTriviaQuestionIndex] = ListofTriviaQuestions[--virtualTriviaLength];

            //moves the already asked trivia question to the end of the line
            ListofTriviaQuestions[virtualTriviaLength] = TriviaQuestionUnordered;

            //if the user somehow gets sent 100 trivia questions, this makes the vitual trivia length 100 again
            //so we can cycle through the questions again
            if (virtualTriviaLength < 0)
            {
                virtualTriviaLength = ListofTriviaQuestions.Length;
            }

            //returns the TriviaQuestion that is now shuffled
            return ShuffleAnswers(TriviaQuestionUnordered);
        }

        /// <summary>
        /// shuffles the answer options for the triviaquestion by turning them into a dictionary and then back to a list, after determining the new correct answer index
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public TriviaQuestion ShuffleAnswers (TriviaQuestion question)
        {
            //creates an array of possible answers out of the list of answer options
            var arr = question.PossibleAnswers.ToArray();
            //current array length
            int length = 4;
            //correct answer index (set to 0 to begin with)
            int correct = 0;

            //creates new dictionary with a string and bool
            Dictionary<string, bool> dictionary = new Dictionary<string, bool>(); 
            //randomizer
            Random random = new Random();
            
            //for loop that goes through each answer option in the array
            for(int i = 0; i < arr.Length; i++)
            {
                //creates a new random number
                int nextInt = random.Next(length);
                //copies the answer with index i to the dictionary with index nextInt
                //the value of the bool is dependent on if the answer is the actually correct one
                dictionary.Add(arr[nextInt], i == question.CorrectAnswerIndex);

                //if loop which moves all the possible answer values forward
                if(nextInt < length-1)
                {
                    arr[nextInt] = arr[length - 1];
                }

                //shortens the length of the working section of the answer option array
                length--;

                //if the answer being worked with is the actually correct one, this
                //assigns the new value of "correct" to its new index in the dictionary
                if (i == question.CorrectAnswerIndex)
                {
                    correct = i;
                }
            }

            //returns new TriviaQuestion with the now shuffled answer options and updated correct answer index
            TriviaQuestion shuffled = new TriviaQuestion(question.QuestionTrivia, dictionary.Keys.ToList(), correct);
            return shuffled;
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
