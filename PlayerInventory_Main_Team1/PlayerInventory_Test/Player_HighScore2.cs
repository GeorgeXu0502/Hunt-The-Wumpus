using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerInventory_Main_Team1
{
    public class Player_HighScore2
    {


        public int GoldCount { get; set; }
        public int NumberOfTurns { get; set; }
        public int NumberOfArrows { get; set; }
        public bool SelfWanted { get; set; }
        public int Score { get; set; }
        public string Username { get; set; }




        // Constructor
        public Player_HighScore2(int goldcount, int numberofturns, int numberofarrows, bool selfwanted, int score, string username)
        {
            GoldCount = goldcount;
            NumberOfTurns = numberofturns;
            NumberOfArrows = numberofarrows;
            SelfWanted = selfwanted;
            Score = score;
            Username = username;
        }

        // Gold coin method which increases gold count by 1 when the users moves forward (SelfWanted)
        public int GoldCoinIndex()
        {
            
            if (SelfWanted)
            {
                GoldCount += 1;
            }
            return GoldCount;
        }

        public bool EncounterTriviaPitCoins(bool goldCountLessThanZero)
        {

            

            for (int i = 0; i < 3; i++)
            {
                GoldCount -= 1;
            }

            goldCountLessThanZero = GoldCount < 0;
            if (goldCountLessThanZero == true)
            {
                return true;
            }
            else return false;
        }

        public bool EncounterWumpusCoins(bool goldCountLessThanZero)
        {
            

            for (int i = 0; i < 5; i++)
            {
                GoldCount -= 1;
            }
            goldCountLessThanZero = GoldCount < 0;
            if (goldCountLessThanZero == true)
            {
                return true;
            }
            else return false;
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
            }
            else
            {
                NumberOfArrows -= 1;
            }
            return NumberOfArrows;
        }

        public int CalculateHighScore(int numberOfTurns, int numberOfCoins, int numberOfArrows, bool wumpusDefeated)
        {

            int wumpusBonus;
            if (wumpusDefeated == true)
            {
                wumpusBonus = 50000;
            }
            else wumpusBonus = 0;
            int HighScore = 100000 - (100 * numberOfTurns) + (500 * numberOfCoins) + (10000 * numberOfArrows) + wumpusBonus;
            Score = HighScore;
            return Score;
        }
    }
}
