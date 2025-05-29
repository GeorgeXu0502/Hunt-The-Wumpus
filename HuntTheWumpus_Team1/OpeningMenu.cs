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
using System.Media;

namespace HuntTheWumpus_Team1
{
    public partial class OpeningMenu : Form
    {
        public string UsernameToReturn;
        public UserLoginObject UserToReturn;

        SoundPlayer openingMusicPlayer = new SoundPlayer("C:\\Users\\Sergei\\Downloads\\AdhesiveWombat - Night Shade-[AudioTrimmer.com].wav");

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
                UserToReturn = new UserLoginObject(UsernameToReturn, "None", -1, "None");
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
            HighScoreDlg.DoneFromOpeningMenu = true;
            this.Hide();
            HighScoreDlg.ShowDialog();
            System.Environment.Exit(1);
        }

        private void DisplayaMessage(string StringToDisplay)
        {
            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();
        }

        private void OpeningMenu_Load(object sender, EventArgs e)
        {
            //openingMusicPlayer.Play();
        }

        private void OpeningMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            openingMusicPlayer.Stop();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LoginScreen LoginScreenDlg = new LoginScreen();
            this.Hide();
            LoginScreenDlg.ShowDialog();
            this.Show();
            UserToReturn = LoginScreenDlg.UserToReturn;

            if (UserToReturn.UserIdentificationNumber != -1)
            {
                this.Close();
            }
        }
    }
}
