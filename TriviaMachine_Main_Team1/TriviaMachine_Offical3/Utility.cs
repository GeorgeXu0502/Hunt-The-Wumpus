using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TriviaMachine_Offical3;

namespace TrivaMachine_Offical
{
    public class Utility
    {
        public static void WriteTriviaToFile(List<TriviaQuestion> ListofTriviaQuestion, string filename)
        {
            JsonSerializer serlizer = new JsonSerializer();

            serlizer.Formatting = Formatting.Indented;

            StreamWriter streakwriter = new StreamWriter(filename);
            serlizer.Serialize(streakwriter, ListofTriviaQuestion, typeof(List<TriviaQuestion>));

            streakwriter.Flush();
            streakwriter.Close();
        }

        public static List<TriviaQuestion> ReadTriviaFromFile(string filename)
        {
            JsonSerializer serlizer = new JsonSerializer();
            StreamReader streamReader = new StreamReader(filename);


            var objectdefied = serlizer.Deserialize(streamReader, typeof(List<TriviaQuestion>));
            streamReader.Close();
            if (objectdefied != null)
            {
                return (List<TriviaQuestion>)objectdefied;
            }
            else
            {
                List<TriviaQuestion> newTriviaQuestionList = new List<TriviaQuestion>();
                return newTriviaQuestionList;
            }
        }

        public static void WriteSecretToFile(List<SecretObject> ListofSecrets, string filename)
        {
            JsonSerializer serlizer = new JsonSerializer();

            serlizer.Formatting = Formatting.Indented;

            StreamWriter streakwriter = new StreamWriter(filename);
            serlizer.Serialize(streakwriter, ListofSecrets, typeof(List<SecretObject>));

            streakwriter.Flush();
            streakwriter.Close();
        }

        public static List<SecretObject> ReadSecretsFromFile(string filename)
        {
            JsonSerializer serlizer = new JsonSerializer();
            StreamReader streamReader = new StreamReader(filename);


            var objectdefied = serlizer.Deserialize(streamReader, typeof(List<SecretObject>));
            streamReader.Close();
            if (objectdefied != null)
            {
                return (List<SecretObject>)objectdefied;
            }
            else
            {
                List<SecretObject> newSecretList = new List<SecretObject>();
                return newSecretList;
            }
        }
    }
}
