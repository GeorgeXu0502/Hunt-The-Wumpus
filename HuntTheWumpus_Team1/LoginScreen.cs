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
    public partial class LoginScreen : Form
    {
        int AmountofLetters = 0; // Letters in the password. 
        string StringPassword = ""; // Password String that stores the Password. 

        public UserLoginObject UserToReturn;

        bool AllowedtoClose = false;

        PlayerDataBase_Offical ObjectToInteractwithDataBase = new PlayerDataBase_Offical();
        public LoginScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the Login Button is Clicked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string UserEnteredUsername = textBoxUsername.Text;
            string UesrEnteredPassword = StringPassword;

            if (ObjectToInteractwithDataBase.DoesUserExsit(UserEnteredUsername, UesrEnteredPassword)) // Check if such a User exsists. Then sign in and close the form. 
            {
                UserToReturn = ObjectToInteractwithDataBase.GetUserInformation(UserEnteredUsername);
                DisplayaMessage("Sucessfully signed In!");
                AllowedtoClose = true;
                this.Close();
            }
            else // Otherwise have the user restart. 
            {
                DisplayaMessage("Username and Password do not match. Please Retry");
                textBoxPassword.Clear();
                textBoxUsername.Focus();
                AmountofLetters = 0;
                StringPassword = "";
            }
        }

        /// <summary>
        /// Universal function that whenever the User enters a key into the Password Textbox, it stores the Password, but prints *.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text) != true)
            {
                if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.LShiftKey && e.KeyCode != Keys.RShiftKey && e.KeyCode != Keys.Back) // Check for exagerant keys. 
                {
                    string StringtoAdd = textBoxPassword.Text.Last().ToString();

                    if (StringtoAdd != "*")
                    {
                        StringPassword += textBoxPassword.Text.Last().ToString();
                        System.Diagnostics.Debug.WriteLine(StringPassword);
                        AmountofLetters += 1;

                        string StringToShowcase = "";

                        for (int i = 0; i < AmountofLetters; i++)
                        {
                            StringToShowcase += "*";
                        }

                        textBoxPassword.Text = StringToShowcase;
                    }
                    textBoxPassword.SelectionStart = textBoxPassword.TextLength;
                    textBoxPassword.SelectionLength = 0;

                }
                else if (e.KeyCode == Keys.Back) // Write back one letter for each backspace pressed. 
                {
                    if (AmountofLetters != 1) // Certain case that takes care of the last character in the password text. 
                    {
                        StringPassword = StringPassword.Remove(StringPassword.Length - 1);
                        System.Diagnostics.Debug.WriteLine(StringPassword);
                        AmountofLetters -= 1;

                        string StringToShowcase = "";

                        for (int i = 0; i < AmountofLetters; i++)
                        {
                            StringToShowcase += "*";
                        }

                        textBoxPassword.Text = StringToShowcase;
                    }
                    else
                    {
                        AmountofLetters = 0;
                        StringPassword = "";
                        textBoxPassword.Clear();
                    }
                }
            }

            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                AmountofLetters = 0;
                StringPassword = "";
                textBoxPassword.Clear();
            }
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
        /// Return to Home Screen with a empty User Object. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturntoHomeScreen_Click(object sender, EventArgs e)
        {
            UserToReturn = new UserLoginObject("None", "None", -1, "None");
            AllowedtoClose = true;
            this.Close();
        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedtoClose)
            {
                e.Cancel = true;
            }
        }
    }
}
