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
    public partial class RegainUssernamePassword : Form
    {
        bool AllowedToClose = false;

        PlayerDataBase_Offical ObjectToInteractwithDataBase = new PlayerDataBase_Offical();
        public RegainUssernamePassword()
        {
            InitializeComponent();
        }

        private void buttonRegainEmail_Click(object sender, EventArgs e)
        {
            string EmailToUse = textBoxEmailEntered.Text;

            if (ObjectToInteractwithDataBase.IsEmailValid(EmailToUse) == false)
            {
                UserLoginObject UserThatIsConsidered = ObjectToInteractwithDataBase.GetUserFromEmail(EmailToUse);
                textBoxUsername.Text = UserThatIsConsidered.UserUsername;
                textBoxPassword.Text = UserThatIsConsidered.UserPassword;
            }
            else
            {
                DisplayaMessage("No User with this Email Exsists.");
            }
        }

        private void RegainUssernamePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedToClose)
            {
                e.Cancel = true;
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

        private void buttonReturnToHomeScreen_Click(object sender, EventArgs e)
        {
            AllowedToClose = true;
            this.Close();
        }
    }
}
