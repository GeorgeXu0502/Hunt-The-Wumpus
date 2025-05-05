using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameControl_Offical;
using TrivaMachine_Offical;

namespace HuntTheWumpus_Team1
{
    public partial class TriviaQuestionUI : Form
    {
        public int AmountofQuestions { get; set; }

        public bool GotOffWithQuestions;

        public bool GotOffWithCoins;

        Player_GameControl GameControlObject = new GameControl_Offical.Player_GameControl();

        int AmountofCorrectQuestions = 0;
         
        // Button Click Event Checkers:

        bool WasButtonAClicked = false;
        bool WasButtonBClicked = false;
        bool WasButtonCClicked = false;
        bool WasButtonDClicked = false;
        bool WasButtonNextClicked = false;

        public TriviaQuestionUI()
        {
            InitializeComponent(); // Might need to change this to a Form_Activated Area. 
            buttonMoveOnToTheNextQuestion.Enabled = false;
            buttonMoveOnToTheNextQuestion.Visible = false;

            for (int i = 0; i < AmountofQuestions; i++)
            {
                AskQuestion();
                GameControlObject.RemoveGoldCoin();
            }

            if (GameControlObject.PlayerGoldCoinAmount() < 0)
            {
                GotOffWithCoins = false;
            }
            else
            {
                GotOffWithCoins = true;
            }

            if (AmountofQuestions == 5 && AmountofCorrectQuestions < 3)
            {
                GotOffWithQuestions = false;
            }

            if (AmountofQuestions == 3 && AmountofCorrectQuestions < 2)
            {
                GotOffWithQuestions = false;
            }
        }

        async void WaitForUserToClick()
        {
            bool Statment = (WasButtonAClicked == false && WasButtonBClicked == false && WasButtonCClicked == false && WasButtonDClicked == false);

            while (Statment == true)
            {
                await Task.Delay(100)
                Statment = (WasButtonAClicked == false && WasButtonBClicked == false && WasButtonCClicked == false && WasButtonDClicked == false);
            }
        }
        
        private void AskQuestion()
        {
            TriviaQuestion CurrentTriviaQuestion = GameControlObject.GetQuestion();

            richTextBoxMainQuestion.Text = CurrentTriviaQuestion.QuestionTrivia;
            richTextBoxOptionAText.Text = CurrentTriviaQuestion.PossibleAnswers[0];
            richTextBoxOptionBText.Text = CurrentTriviaQuestion.PossibleAnswers[1];
            richTextBoxOptionCText.Text = CurrentTriviaQuestion.PossibleAnswers[2];
            richTextBoxOptionDText.Text = CurrentTriviaQuestion.PossibleAnswers[3];

            WaitForUserToClick();
            if (WasButtonAClicked)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 0)
                {
                    AmountofCorrectQuestions += 1;
                }
            }
            else if (WasButtonBClicked)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 1)
                {
                    AmountofCorrectQuestions += 1;
                }
            }
            else if (WasButtonCClicked)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 2)
                {
                    AmountofCorrectQuestions += 1;
                }
            }
            else
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 3)
                {
                    AmountofCorrectQuestions += 1;
                }
            }

            WasButtonAClicked = false;
            WasButtonAClicked = false;
            WasButtonAClicked = false;
            WasButtonAClicked = false;

            labelTopBanner.Text = "Correct Answer:";
            richTextBoxMainQuestion.Visible = false;
            buttonMoveOnToTheNextQuestion.Enabled = true;
            buttonMoveOnToTheNextQuestion.Visible = true;

            if (CurrentTriviaQuestion.CorrectAnswerIndex == 0)
            {
                buttonOptionA.BackColor = Color.DarkGreen;
            }
            else if (CurrentTriviaQuestion.CorrectAnswerIndex == 1)
            {
                buttonOptionB.BackColor = Color.DarkGreen;
            }
            else if (CurrentTriviaQuestion.CorrectAnswerIndex == 2)
            {
                buttonOptionC.BackColor = Color.DarkGreen;
            }
            else
            {
                buttonOptionD.BackColor = Color.DarkGreen;
            }

            if (WasButtonNextClicked == true)
            {
                labelTopBanner.Text = "Question:";
                richTextBoxMainQuestion.Visible = true;
                buttonOptionA.BackColor = Color.White;
                buttonOptionB.BackColor = Color.White;
                buttonOptionC.BackColor = Color.White;
                buttonOptionD.BackColor = Color.White;
                WasButtonNextClicked = false;
                buttonMoveOnToTheNextQuestion.Enabled = false;
                buttonMoveOnToTheNextQuestion.Visible = false;
            }

            return;

        }

        private void buttonOptionA_Click(object sender, EventArgs e)
        {
            WasButtonAClicked = true;
        }

        private void buttonOptionB_Click(object sender, EventArgs e)
        {
            WasButtonBClicked = true;
        }

        private void buttonOptionC_Click(object sender, EventArgs e)
        {
            WasButtonCClicked = true;
        }

        private void buttonOptionD_Click(object sender, EventArgs e)
        {
            WasButtonDClicked = true;
        }

        private void buttonMoveOnToTheNextQuestion_Click(object sender, EventArgs e)
        {
            WasButtonNextClicked = true;
        }
    }
}
