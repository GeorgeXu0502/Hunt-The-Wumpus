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
    public partial class MessageBoxYesorNoCustom : Form
    {
        public string QuestionToDisplay { get; set; }
        public bool ResultOfQuestion;

        bool AllowedtoClose = false;
        public MessageBoxYesorNoCustom()
        {
            InitializeComponent();
        }

        private void MessageBoxYesorNoCustom_Activated(object sender, EventArgs e)
        {
            richTextBoxMainQuestion.Text = QuestionToDisplay;
        }

        private void buttonYesContiue_Click(object sender, EventArgs e)
        {
            ResultOfQuestion = true;
            AllowedtoClose = true;
            this.Close();
        }

        private void buttonNoCountiue_Click(object sender, EventArgs e)
        {
            ResultOfQuestion = false;
            AllowedtoClose = true;
            this.Close();
        }

        private void MessageBoxYesorNoCustom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedtoClose)
            {
                e.Cancel = true;
            }
        }
    }
}
