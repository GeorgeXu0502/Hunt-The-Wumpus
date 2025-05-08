using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerInventory_Offical
{
    public class HighScoreObject
    {
        public string UserNameOfScorer { get; set; }

        public int Score { get; set; }

        public HighScoreObject(string userNameOfScorer, int score)
        {
            UserNameOfScorer = userNameOfScorer;
            Score = score;
        }
    }
}
