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
            Score = 0;
            Username = "Player";
            AmoutofArrowsBoughtAlready = 0;
        }
        

        /// <summary>
        /// This method is used to add/update the highscores list.
        /// </summary>
        /// <param name="ObjectToWriteToFile">Parameter used to write the highscores to the highscores file</param>
        public void AddNewScoreToPastScoreList(HighScoreObject ObjectToWriteToFile)
        {
            List<HighScoreObject> playerhighscores = ReadFromFile();
            playerhighscores.Add(ObjectToWriteToFile);
            WriteToFile(dataFile, playerhighscores);
        }

        // Gold coin method which increases gold count by 1 when the users moves forward (SelfWanted)

        /// <summary>
        /// This method is used to get the number of gold coins the player has.
        /// </summary>
        /// <returns>Returns the gold coin amount</returns>
        public int NumberofGoldCoinIndex()
        {
            return GoldCount;
        }

        /// <summary>
        /// This method is used to get the number of arrows the player has.
        /// </summary>
        /// <returns>Returns the arrow amount</returns>
        public int NumberOfArrowsIndex()
        {
            return NumberOfArrows;
        }



        /// <summary>
        /// This method is used to get the number of turns the player has taken.
        /// </summary>
        public void AddUserTurn()
        {
            NumberOfTurns += 1;
        }
        /// <summary>
        /// This method is used to determine whether the player has purchased an arrow or shot an arrow
        /// </summary>
        /// <param name="isPurchase">Parameter used to determine if the user is purchasing a arrow or not</param>
        /// <returns>Returns the newly amount of arrows</returns>
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

        /// <summary>
        /// This method is used to calculate the high score based on the number of turns, gold count, number of arrows, and whether the Wumpus was defeated.
        /// </summary>
        /// <param name="wumpusDefeated">Parameter used to determine whether wumpus is defeated or no</param>
        /// <returns>Returns the highscore amount</returns>
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
        /// <summary>
        /// This method is used to add a gold coin to the player's inventory.
        /// </summary>
        public void AddGoldCoin()
        {
            GoldCount += 1;
        }

        /// <summary>
        /// This method is used to remove a gold coin from the player's inventory.
        /// </summary>
        public void RemoveGoldCoin()
        {
            GoldCount -= 1;
        }

        /// <summary>
        /// This method is used to check if the player can buy an arrow.
        /// </summary>
        /// <returns>Returns the new amount of arrows</returns>
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

        /// <summary>
        /// This method is used to write the high scores to a file.
        /// </summary>
        /// <param name="dataFile">Parameter used to have the datafile</param>
        /// <param name="highscores">Parameter used to have a highscores list</param>
        public void WriteToFile(string dataFile, List<HighScoreObject> highscores)
        {
            JsonSerializer serlizer = new JsonSerializer();

            serlizer.Formatting = Formatting.Indented;

            StreamWriter streakwriter = new StreamWriter(dataFile);
            serlizer.Serialize(streakwriter, highscores, typeof(List<HighScoreObject>));

            streakwriter.Flush();
            streakwriter.Close();
        }


        /// <summary>
        /// This method is used to read the high scores from a file.
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// This method is used to get the top scores from the high score list.
        /// </summary>
        /// <returns></returns>
        public List<HighScoreObject> GetTopScores()
        {
            List<HighScoreObject> playerhighscores = ReadFromFile();

            List<HighScoreObject>  PlayerHighScoresSorted = playerhighscores.OrderBy(o => o.Score).ToList();

            return PlayerHighScoresSorted;
        }

        /// <summary>
        /// This method is used to get the amount of turn already taken by the User. 
        /// </summary>
        /// <returns></returns>
        public int NumberofTurnsIndex()
        {
            return NumberOfTurns;
        }
    }
}
