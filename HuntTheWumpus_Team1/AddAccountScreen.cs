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

        private void buttonReturnToHomeScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) != true && string.IsNullOrWhiteSpace(textBoxUsername.Text) != true && string.IsNullOrWhiteSpace(textBoxPassword.Text) != true)
            {
                if (ObjectToInteractwithDataBase.IsUserNameValid(textBoxUsername.Text) && ObjectToInteractwithDataBase.IsEmailValid(textBoxEmail.Text))
                {
                    int UserIdentificationNumberToUse = ObjectToInteractwithDataBase.GetLatestIdentificationNumber();
                    UserLoginObject UserToAdd = new UserLoginObject(textBoxUsername.Text, StringPassword, UserIdentificationNumberToUse, textBoxEmail.Text);
                    ObjectToInteractwithDataBase.AddUserToList(UserToAdd);
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

        private void DisplayaMessage(string StringToDisplay)
        {
            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();
        }

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
        }
    }
}
