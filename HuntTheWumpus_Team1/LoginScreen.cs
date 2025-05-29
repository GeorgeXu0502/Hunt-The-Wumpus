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
        int AmountofLetters = 0;
        string StringPassword = "";

        public UserLoginObject UserToReturn;

        PlayerDataBase_Offical ObjectToInteractwithDataBase = new PlayerDataBase_Offical();
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string UserEnteredUsername = textBoxUsername.Text;
            string UesrEnteredPassword = StringPassword;

            if (ObjectToInteractwithDataBase.DoesUserExsit(UserEnteredUsername, UesrEnteredPassword))
            {
                UserToReturn = ObjectToInteractwithDataBase.GetUserInformation(UserEnteredUsername);
                DisplayaMessage("Sucessfully signed In!");
                this.Close();
            }
            else
            {
                DisplayaMessage("Username and Password do not match. Please Retry");
                textBoxPassword.Clear();
                textBoxUsername.Clear();
                AmountofLetters = 0;
                StringPassword = "";
            }
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
            }
        }

        private void DisplayaMessage(string StringToDisplay)
        {
            MessageBoxCustom MessageBoxDlg = new MessageBoxCustom();
            MessageBoxDlg.StringToDispaly = StringToDisplay;
            MessageBoxDlg.ShowDialog();
        }

        private void buttonReturntoHomeScreen_Click(object sender, EventArgs e)
        {
            UserToReturn = new UserLoginObject("None", "None", -1, "None");
            this.Close();
        }
    }
}
