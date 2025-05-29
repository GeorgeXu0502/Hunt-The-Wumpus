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
        bool AllowedtoClose = false; // Keeps the form from closing without direct user input. 
        public bool DoneFromOpeningMenu { get; set; } // Define the Closing attempt. 
        public Player_GameControl GameControlObject { get; set; }

        public bool PlayedGameOrNot { get; set; } // If the Player just wants to see High Scores from the Opening Menu. 
        public UserLoginObject UserThatPlayer { get; set; } // Player Object to Return. 
        public HighScoreUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function that fully closes the game and the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitTheGame_Click(object sender, EventArgs e)
        {
            if (DoneFromOpeningMenu)
            {
                AllowedtoClose = true;
                this.Close();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        /// <summary>
        /// Fully stops the highlighting of the textboxes in the form.
        /// </summary>
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

        /// <summary>
        /// When the form loads put in the TopScore by reading them from the Game Control Object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighScoreUI_Load(object sender, EventArgs e)
        {
            DisableSelectingOfText();
            if (PlayedGameOrNot)
            {
                // If the game was played include the User Score and Write it to the File. 
                textBoxPlayerScore.Text = GameControlObject.PlayerScoreFinal().ToString();
                HighScoreObject IndividualPlayerObject = new HighScoreObject(UserThatPlayer.UserUsername, GameControlObject.PlayerScoreFinal());
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
                // If the game was not played, then do not include the User Score. 
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

        /// <summary>
        /// Only close the form, is the Allowed to Close Variable. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighScoreUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedtoClose)
            {
                e.Cancel = true;
            }
        }
    }
}
