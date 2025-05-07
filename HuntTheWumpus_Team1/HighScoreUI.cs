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
                List<string> TopScores = GameControlObject.GetTopScores();
                textBoxUserName1.Text = TopScores[0];
                textBoxUserScore1.Text = TopScores[1].ToString();
                textBoxUserName2.Text = TopScores[2];
                textBoxUserScore2.Text = TopScores[3].ToString();
                textBoxUserName3.Text = TopScores[4];
                textBoxUserScore3.Text = TopScores[5].ToString();
                textBoxUserName4.Text = TopScores[6];
                textBoxUserScore4.Text = TopScores[7].ToString();
                textBoxUserName5.Text = TopScores[8];
                textBoxUserScore5.Text = TopScores[9].ToString();
            }
            else
            {
                textBoxPlayerScore.Text = "0";
                List<string> TopScores = GameControlObject.GetTopScores();
                textBoxUserName1.Text = TopScores[0];
                textBoxUserScore1.Text = TopScores[1].ToString();
                textBoxUserName2.Text = TopScores[2];
                textBoxUserScore2.Text = TopScores[3].ToString();
                textBoxUserName3.Text = TopScores[4];
                textBoxUserScore3.Text = TopScores[5].ToString();
                textBoxUserName4.Text = TopScores[6];
                textBoxUserScore4.Text = TopScores[7].ToString();
                textBoxUserName5.Text = TopScores[8];
                textBoxUserScore5.Text = TopScores[9].ToString();
            }
        }

    }
}
