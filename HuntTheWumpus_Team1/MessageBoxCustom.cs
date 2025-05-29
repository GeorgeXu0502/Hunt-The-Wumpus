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
    public partial class MessageBoxCustom : Form
    {
        public string StringToDispaly { get; set; } = string.Empty; // This get rid of the Warning for Non-Null Value.

        bool AllowedtoClose = false;
        public MessageBoxCustom()
        {
            InitializeComponent();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            AllowedtoClose = true; // Allow the Application to Close. 
            this.Close();
        }

        /// <summary>
        /// Display the Message Nesscary. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageBoxCustom_Load(object sender, EventArgs e)
        {
            richTextBoxDispaly.Text = StringToDispaly;
            richTextBoxDispaly.TabStop = false;
        }

        /// <summary>
        /// Close the Form, but only if it is allowed to. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageBoxCustom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedtoClose)
            {
                e.Cancel = true;
            }
        }
    }
}
