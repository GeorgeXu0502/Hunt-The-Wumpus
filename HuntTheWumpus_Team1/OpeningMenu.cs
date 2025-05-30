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
        bool AllowedToClose = false;

        public string UsernameToReturn;
        public UserLoginObject UserToReturn;

        SoundPlayer openingMusicPlayer = new SoundPlayer("C:\\Users\\Sergei\\Downloads\\AdhesiveWombat - Night Shade-[AudioTrimmer.com].wav");

        public OpeningMenu()
        {
            InitializeComponent();
            UsernameToReturn = string.Empty;
        }

        /// <summary>
        /// If the User just wants to play with a simple Username, return a Simple USer Object with no Identitifcation Number. Do not allow User to play with no Username. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttoStarttheGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) != true)
            {
                UsernameToReturn = textBoxUsername.Text;
                UserToReturn = new UserLoginObject(UsernameToReturn, "None", -1, "None");
                AllowedToClose = true;
                this.Close();
            }
            else
            {
                DisplayaMessage("Please enter a Username first.");
            }

        }

        /// <summary>
        /// Showcase the previous High Scores in the High Score Form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Universal Function to Display a Message with the Custom Message Box. 
        /// </summary>
        /// <param name="StringToDisplay"> String to Showcase </param>
        private void DisplayaMessage(string StringToDisplay)
        {
            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();
        }

        /// <summary>
        /// Start the Music when opening the Menu. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpeningMenu_Load(object sender, EventArgs e)
        {
            //openingMusicPlayer.Play();
        }

        /// <summary>
        /// Stop the Music when closing the Form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpeningMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedToClose)
            {
                e.Cancel = true;
            }
            else
            {
                openingMusicPlayer.Stop();
            }
        }

        /// <summary>
        /// When the User clicks the button to Login, showcase the Login Form. Only close if the User actually was able to login. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LoginScreen LoginScreenDlg = new LoginScreen();
            this.Hide();
            LoginScreenDlg.ShowDialog();
            this.Show();
            UserToReturn = LoginScreenDlg.UserToReturn;

            if (UserToReturn.UserIdentificationNumber != -1)
            {
                AllowedToClose = true;
                this.Close();
            }
        }

        /// <summary>
        /// Allow the User to Create an Account throught the Account Form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateAnAccount_Click(object sender, EventArgs e)
        {
            AddAccountScreen AddAcountDlg = new AddAccountScreen();
            this.Hide();
            AddAcountDlg.ShowDialog();
            this.Show();
        }
    }
}
