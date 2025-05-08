using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameControl_Offical;
using PlayerInventory_Offical;

namespace HuntTheWumpus_Team1
{
    public partial class HighScoreUI : Form
    {
        Player_GameControl GameControlObject = new GameControl_Offical.Player_GameControl();

        public bool PlayedGameOrNot { get; set; } // If the Player just wants to see High Scores from the Opening Menu. 
        public HighScoreUI()
        {
            InitializeComponent();
        }

        private void buttonExitTheGame_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void HighScoreUI_Load(object sender, EventArgs e)
        {
            if (PlayedGameOrNot)
            {
                textBoxPlayerScore.Text = GameControlObject.PlayerScoreFinal().ToString();
                List<HighScoreObject> TopScores = GameControlObject.GetTopScores();
                textBoxUserName1.Text = TopScores[0].UserNameOfScorer;
                textBoxUserScore1.Text = TopScores[0].Score.ToString();
                textBoxUserName2.Text = TopScores[1].UserNameOfScorer;
                textBoxUserScore2.Text = TopScores[1].Score.ToString();
                textBoxUserName3.Text = TopScores[2].UserNameOfScorer;
                textBoxUserScore3.Text = TopScores[2].Score.ToString();
                textBoxUserName4.Text = TopScores[3].UserNameOfScorer;
                textBoxUserScore4.Text = TopScores[3].Score.ToString();
                textBoxUserName5.Text = TopScores[4].UserNameOfScorer;
                textBoxUserScore5.Text = TopScores[4].Score.ToString();
            }
            else
            {
                textBoxPlayerScore.Text = "0";
                List<HighScoreObject> TopScores = GameControlObject.GetTopScores();
                textBoxUserName1.Text = TopScores[0].UserNameOfScorer;
                textBoxUserScore1.Text = TopScores[0].Score.ToString();
                textBoxUserName2.Text = TopScores[1].UserNameOfScorer;
                textBoxUserScore2.Text = TopScores[1].Score.ToString();
                textBoxUserName3.Text = TopScores[2].UserNameOfScorer;
                textBoxUserScore3.Text = TopScores[2].Score.ToString();
                textBoxUserName4.Text = TopScores[3].UserNameOfScorer;
                textBoxUserScore4.Text = TopScores[3].Score.ToString();
                textBoxUserName5.Text = TopScores[4].UserNameOfScorer;
                textBoxUserScore5.Text = TopScores[4].Score.ToString();
            }
        }

    }
}
