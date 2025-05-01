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
        public OpeningMenu()
        {
            InitializeComponent();
            UsernameToReturn = string.Empty;
        }

        private void buttoStarttheGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                UsernameToReturn = textBoxUsername.Text;
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
            HighScoreDlg.ShowDialog();
        }

        private void DisplayaMessage(string StringToDisplay)
        {
            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();
        }
    }
}
