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

            if (PlayedGameOrNot)
            {
                textBoxPlayerScore.Text = GameControlObject.PlayerScoreFinal().ToString();
                List<int> TopScores = GameControlObject.GetTopScores();
                textBoxTopScore1.Text = TopScores[0].ToString();
                textBoxTopScore2.Text = TopScores[1].ToString();
                textBoxTopScore3.Text = TopScores[2].ToString();
                textBoxTopScore4.Text = TopScores[3].ToString();
                textBoxTopScore5.Text = TopScores[4].ToString();
            }
            else
            {
                textBoxPlayerScore.Text = "0";
                List<int> TopScores = GameControlObject.GetTopScores();
                textBoxTopScore1.Text = TopScores[0].ToString();
                textBoxTopScore2.Text = TopScores[1].ToString();
                textBoxTopScore3.Text = TopScores[2].ToString();
                textBoxTopScore4.Text = TopScores[3].ToString();
                textBoxTopScore5.Text = TopScores[4].ToString();
            }

        }

        private void buttonExitTheGame_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
