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




        // Constructor
        public Player_HighScore2()
        {
            GoldCount = 0;
            NumberOfTurns = 0;
            NumberOfArrows = 0;
            SelfWanted = false;
            Score = 0;
        }

        // Gold coin method which increases gold count by 1 when the users moves forward (SelfWanted)
        public int GoldCoinIndex(int numberOfGoldCoins)
        {
            
            if (SelfWanted)
            {
                GoldCount += 1;
            }
            return GoldCount;
        }

        public bool EncounterTriviaPitCoins(int numberOfGoldCoins, bool goldCountLessThanZero)
        {

            

            for (int i = 0; i < 3; i++)
            {
                GoldCount -= 1;
            }

            goldCountLessThanZero = GoldCount < 0;
            return goldCountLessThanZero;
        }

        public bool EncounterWumpusCoins(int numberOfGoldCoins, bool goldCountLessThanZero)
        {
            

            for (int i = 0; i < 5; i++)
            {
                GoldCount -= 1;
            }
            goldCountLessThanZero = GoldCount < 0;
            return goldCountLessThanZero;
        }

        public int NumberOfTurnsIndex(int numberOfTurns)
        {
            

            if (SelfWanted)
            {
                NumberOfTurns += 1;
            }
            return NumberOfTurns;
        }

        public int NumberOfArrowsIndex(int numberOfArrows, bool isPurchase)
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
                wumpusBonus = 50;
            }
            else wumpusBonus = 0;
            int HighScore = 100 - numberOfTurns + numberOfCoins + (5 * numberOfArrows) + wumpusBonus;
            Score = HighScore;
            return Score;
        }
    }
}
