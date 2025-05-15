using GameControl_Offical;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntTheWumpus_Team1
{
    public partial class OpeningMenu : Form
    {
        public string UsernameToReturn;

        bool AllowedtoClose = false;

        public OpeningMenu()
        {
            InitializeComponent();
            UsernameToReturn = string.Empty;
        }

        private void buttoStarttheGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) != true)
            {
                UsernameToReturn = textBoxUsername.Text;
                AllowedtoClose = true;
                this.Close();
            }
            else
            {
                DisplayaMessage("Please enter a Username first.");
            }

        }

        private void buttonViewPreviousHighScores_Click(object sender, EventArgs e)
        {
            HighScoreUI HighScoreDlg = new HighScoreUI();
            HighScoreDlg.PlayedGameOrNot = false;
            Player_GameControl GameControlObject = new Player_GameControl();
            HighScoreDlg.GameControlObject = GameControlObject;
            this.Hide();
            HighScoreDlg.ShowDialog();
        }

        private void DisplayaMessage(string StringToDisplay)
        {
            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();
        }

        private void OpeningMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedtoClose)
            {
                e.Cancel = true;
            }
        }
    }
}
