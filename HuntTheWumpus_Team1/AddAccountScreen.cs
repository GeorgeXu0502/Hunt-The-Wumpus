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
    public partial class AddAccountScreen : Form
    {
        int AmountofLetters = 0;
        string StringPassword = "";

        PlayerDataBase_Offical ObjectToInteractwithDataBase = new PlayerDataBase_Offical();
        public AddAccountScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If the User chooses to return to the Home Screen, close the current Form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturnToHomeScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// If the User chooses to create an Account, allow the User to do this. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) != true && string.IsNullOrWhiteSpace(textBoxUsername.Text) != true && string.IsNullOrWhiteSpace(textBoxPassword.Text) != true) // Make sure all the information is in cluded. 
            {
                if (ObjectToInteractwithDataBase.IsUserNameValid(textBoxUsername.Text) && ObjectToInteractwithDataBase.IsEmailValid(textBoxEmail.Text)) // Make sure the Username and Email have not been used before. 
                {
                    int UserIdentificationNumberToUse = ObjectToInteractwithDataBase.GetLatestIdentificationNumber()+1;
                    UserLoginObject UserToAdd = new UserLoginObject(textBoxUsername.Text, StringPassword, UserIdentificationNumberToUse, textBoxEmail.Text, 0);
                    ObjectToInteractwithDataBase.AddUserToList(UserToAdd); // Add the actual user. 
                    DisplayaMessage("User sucessfully added. Please login into your new account! ");
                    this.Close();
                }
                else
                {
                    if (ObjectToInteractwithDataBase.IsUserNameValid(textBoxUsername.Text) != true)
                    {
                        DisplayaMessage("The Username has already been used. Please choose a new username. ");
                    }
                    else
                    {
                        DisplayaMessage("The Email has already been used. Please user another email, or login to the account associatated with the email. ");
                    }
                }
            }
            else
            {
                DisplayaMessage("Not all the information has been filled in. Please contiue filling in all of the fields. ");
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
        /// Universal function that whenever the User enters a key into the Password Textbox, it stores the Password, but prints *.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text) != true)
            {
                if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.LShiftKey && e.KeyCode != Keys.RShiftKey && e.KeyCode != Keys.Back)
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
                else if (e.KeyCode == Keys.Back)
                {
                    if (AmountofLetters != 1)
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
    }
}
