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
        public OpeningMenu()
        {
            InitializeComponent();
        }

        private void buttoStarttheGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewPreviousHighScores_Click(object sender, EventArgs e)
        {
            HighScoreUI HighScoreDlg = new HighScoreUI();
            HighScoreDlg.PlayedGameOrNot = false;
            HighScoreDlg.ShowDialog();
        }
    }
}
