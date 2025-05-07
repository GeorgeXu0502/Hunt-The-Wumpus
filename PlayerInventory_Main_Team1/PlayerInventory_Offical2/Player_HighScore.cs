using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace PlayerInventory_Offical
{
    public class Player_HighScore
    {





        public int GoldCount { get; set; }
        public int NumberOfTurns { get; set; }
        public int NumberOfArrows { get; set; }
        public bool SelfWanted { get; set; }
        public int Score { get; set; }
        public string Username { get; set; }

        public int AmoutofArrowsBoughtAlready { get; set; }


        // Constructor
        public Player_HighScore()
        {
            GoldCount = 0;
            NumberOfTurns = 0;
            NumberOfArrows = 3;
            SelfWanted = false;
            Score = 0;
            Username = "Player";
            AmoutofArrowsBoughtAlready = 0;
        }

        // Gold coin method which increases gold count by 1 when the users moves forward (SelfWanted)
        public int NumberofGoldCoinIndex()
        {
            return GoldCount;
        }

        public int NumberOfArrowsIndex()
        {
            return NumberOfArrows;
        }

        public bool EncounterTriviaPitCoins(bool goldCountLessThanZero)
        {
            for (int i = 0; i < 3; i++)
            {
                GoldCount -= 1;
            }

            goldCountLessThanZero = GoldCount < 0;
            return goldCountLessThanZero;
        }

        public bool EncounterWumpusCoins(bool goldCountLessThanZero)
        {
            for (int i = 0; i < 5; i++)
            {
                GoldCount -= 1;
            }
            goldCountLessThanZero = GoldCount < 0;
            return goldCountLessThanZero;
        }

        public int NumberOfTurnsIndex()
        {
            if (SelfWanted)
            {
                NumberOfTurns += 1;
            }
            return NumberOfTurns;
        }

        public int NumberOfArrowsIndex(bool isPurchase)
        {
            if (isPurchase)
            {
                NumberOfArrows += 1;
                AmoutofArrowsBoughtAlready += 1;
            }
            else
            {
                NumberOfArrows -= 1;
            }
            return NumberOfArrows;
        }

        public int CalculateHighScore(bool wumpusDefeated)
        {
            int wumpusBonus;
            if (wumpusDefeated == true)
            {
                wumpusBonus = 50000;
            }
            else wumpusBonus = 0;
            Score = 100000 - (100 * NumberOfTurns) + (500 * GoldCount) + (10000 * NumberOfArrows) + wumpusBonus;
            return Score;
        }

        // Add a function that returns error gold amount

        public void AddGoldCoin()
        {
            GoldCount += 1;
        }

        public void RemoveGoldCoin()
        {
            GoldCount -= 1;
        }   

        /* public List<int> GetTopScores()
        {
            //return a list of the top 5 scores
            return new List<int>();
        } */

        public bool CanWeBuyAnArrow()
        {
            if (AmoutofArrowsBoughtAlready >= 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static JsonSerializer serializer = new JsonSerializer();

        public static void WriteToFile(string dataFile, List<Player_HighScore> highscores)
        {
            StreamWriter writer = new StreamWriter(dataFile, false);

            JsonSerializer jsonSerializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            jsonSerializer.Serialize(writer, highscores);
            writer.Flush();
            writer.Close();
        }

        public static List<Player_HighScore> ReadFromFile(string dataFile)
        {
            StreamReader reader = new StreamReader(dataFile);

            JsonSerializer jsonSerializer = new JsonSerializer();
            var list = (List<Player_HighScore>)jsonSerializer.Deserialize(reader, typeof(List<Player_HighScore>));
            reader.Close();
            if (list == null)
            {
                return new List<Player_HighScore>();
            }

            return list;
        }



        public static List<string> GetTopScores(string dataFile)
        {
            List<Player_HighScore> playerhighscores = ReadFromFile(dataFile);

            // Sort the scores in descending order and take the top 5
            playerhighscores = playerhighscores.OrderByDescending(h => h.Score).Take(5).ToList();

            // Create a list of formatted strings for the top scores
            List<string> topScores = new List<string>();
            foreach (var hs in playerhighscores)
            {
                topScores.Add($"{hs.Username}: {hs.Score}");
            }

            return topScores;
        }
    }
}
