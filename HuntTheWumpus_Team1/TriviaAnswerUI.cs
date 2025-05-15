using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrivaMachine_Offical;

namespace HuntTheWumpus_Team1
{
    public partial class TriviaAnswerUI : Form
    {

        public TriviaQuestion TriviaAnswerToUse { get; set; }

        bool AllowedtoClose = false;
        public TriviaAnswerUI()
        {
            InitializeComponent();
        }
        private void buttonContiue_Click(object sender, EventArgs e)
        {
            AllowedtoClose = true;
            this.Close();
        }

        private void TriviaAnswerUI_Load(object sender, EventArgs e)
        {
            buttonOptionA.Enabled = false;
            buttonOptionB.Enabled = false;
            buttonOptionC.Enabled = false;
            buttonOptionD.Enabled = false;

            richTextBoxMainQuestion.Text = TriviaAnswerToUse.QuestionTrivia;

            richTextBoxOptionA.Text = TriviaAnswerToUse.PossibleAnswers[0];
            richTextBoxOptionB.Text = TriviaAnswerToUse.PossibleAnswers[1];
            richTextBoxOptionC.Text = TriviaAnswerToUse.PossibleAnswers[2];
            richTextBoxOptionD.Text = TriviaAnswerToUse.PossibleAnswers[3];

            if (TriviaAnswerToUse.CorrectAnswerIndex == 0)
            {
                buttonOptionA.BackColor = Color.DarkGreen;
            }
            else if (TriviaAnswerToUse.CorrectAnswerIndex == 1)
            {
                buttonOptionB.BackColor = Color.DarkGreen;
            }
            else if (TriviaAnswerToUse.CorrectAnswerIndex == 2)
            {
                buttonOptionC.BackColor = Color.DarkGreen;
            }
            else
            {
                buttonOptionD.BackColor = Color.DarkGreen;
            }
        }

        private void TriviaAnswerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedtoClose)
            {
                e.Cancel = true;
            }
        }
    }
}
