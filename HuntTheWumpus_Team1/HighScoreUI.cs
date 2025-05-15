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
        bool AllowedtoClose = false;

        public Player_GameControl GameControlObject { get; set; }

        public bool PlayedGameOrNot { get; set; } // If the Player just wants to see High Scores from the Opening Menu. 
        public string UserUsername { get; set; }
        public HighScoreUI()
        {
            InitializeComponent();
        }

        private void buttonExitTheGame_Click(object sender, EventArgs e)
        {
            AllowedtoClose = true;
            System.Windows.Forms.Application.Exit();
        }

        private void DisableSelectingOfText()
        {
            textBoxPlayerScore.TabStop = false;
            textBoxUserName1.TabStop = false;
            textBoxUserName2.TabStop = false;
            textBoxUserName3.TabStop = false;
            textBoxUserName4.TabStop = false;
            textBoxUserName5.TabStop = false;
            textBoxUserScore1.TabStop = false;
            textBoxUserScore2.TabStop = false;
            textBoxUserScore3.TabStop = false;
            textBoxUserScore4.TabStop = false;
            textBoxUserScore5.TabStop = false;
        }

        private void HighScoreUI_Load(object sender, EventArgs e)
        {
            DisableSelectingOfText();
            if (PlayedGameOrNot)
            {
                textBoxPlayerScore.Text = GameControlObject.PlayerScoreFinal().ToString();
                HighScoreObject IndividualPlayerObject = new HighScoreObject(UserUsername, GameControlObject.PlayerScoreFinal());
                GameControlObject.AddPlayerScoreToList(IndividualPlayerObject);
                List<HighScoreObject> TopScores = GameControlObject.GetTopScores();
                int TopScoreCount = TopScores.Count;

                textBoxUserName1.Text = TopScores[TopScoreCount - 1].UserNameOfScorer;
                textBoxUserScore1.Text = TopScores[TopScoreCount - 1].Score.ToString();
                textBoxUserName2.Text = TopScores[TopScoreCount - 2].UserNameOfScorer;
                textBoxUserScore2.Text = TopScores[TopScoreCount - 2].Score.ToString();
                textBoxUserName3.Text = TopScores[TopScoreCount - 3].UserNameOfScorer;
                textBoxUserScore3.Text = TopScores[TopScoreCount - 3].Score.ToString();
                textBoxUserName4.Text = TopScores[TopScoreCount - 4].UserNameOfScorer;
                textBoxUserScore4.Text = TopScores[TopScoreCount - 4].Score.ToString();
                textBoxUserName5.Text = TopScores[TopScoreCount - 5].UserNameOfScorer;
                textBoxUserScore5.Text = TopScores[TopScoreCount - 5].Score.ToString();
            }
            else
            {
                textBoxPlayerScore.Text = "0";
                List<HighScoreObject> TopScores = GameControlObject.GetTopScores();
                int TopScoreCount = TopScores.Count;

                textBoxUserName1.Text = TopScores[TopScoreCount - 1].UserNameOfScorer;
                textBoxUserScore1.Text = TopScores[TopScoreCount - 1].Score.ToString();
                textBoxUserName2.Text = TopScores[TopScoreCount - 2].UserNameOfScorer;
                textBoxUserScore2.Text = TopScores[TopScoreCount - 2].Score.ToString();
                textBoxUserName3.Text = TopScores[TopScoreCount - 3].UserNameOfScorer;
                textBoxUserScore3.Text = TopScores[TopScoreCount - 3].Score.ToString();
                textBoxUserName4.Text = TopScores[TopScoreCount - 4].UserNameOfScorer;
                textBoxUserScore4.Text = TopScores[TopScoreCount - 4].Score.ToString();
                textBoxUserName5.Text = TopScores[TopScoreCount - 5].UserNameOfScorer;
                textBoxUserScore5.Text = TopScores[TopScoreCount - 5].Score.ToString();
            }
        }

        private void HighScoreUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedtoClose)
            {
                e.Cancel = true;
            }
        }
    }
}
