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

        string dataFile = "HighScore.json";
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

        public void AddNewScoreToPastScoreList(HighScoreObject ObjectToWriteToFile)
        {
            List<HighScoreObject> playerhighscores = ReadFromFile();
            playerhighscores.Add(ObjectToWriteToFile);
            WriteToFile(dataFile, playerhighscores);
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

        public void AddUserTurn()
        {
            NumberOfTurns += 1;
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

        public void WriteToFile(string dataFile, List<HighScoreObject> highscores)
        {
            JsonSerializer serlizer = new JsonSerializer();

            serlizer.Formatting = Formatting.Indented;

            StreamWriter streakwriter = new StreamWriter(dataFile);
            serlizer.Serialize(streakwriter, highscores, typeof(List<HighScoreObject>));

            streakwriter.Flush();
            streakwriter.Close();
        }

        public List<HighScoreObject> ReadFromFile()
        {
            JsonSerializer serlizer = new JsonSerializer();
            StreamReader streamReader = new StreamReader(dataFile);


            var objectdefied = serlizer.Deserialize(streamReader, typeof(List<HighScoreObject>));
            streamReader.Close();
            if (objectdefied != null)
            {
                return (List<HighScoreObject>)objectdefied;
            }
            else
            {
                List<HighScoreObject> newTriviaQuestionList = new List<HighScoreObject>();
                return newTriviaQuestionList;
            }
        }



        public List<HighScoreObject> GetTopScores()
        {
            List<HighScoreObject> playerhighscores = ReadFromFile();

            List<HighScoreObject>  PlayerHighScoresSorted = playerhighscores.OrderBy(o => o.Score).ToList();

            return PlayerHighScoresSorted;
        }
    }
}
