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

        TriviaQuestion CurrentTriviaQuestion;

        public TriviaQuestionUI()
        {
            InitializeComponent(); 
        }

        /*
        async void WaitForUserToClick()
        {
            bool Statment = (WasButtonAClicked == false && WasButtonBClicked == false && WasButtonCClicked == false && WasButtonDClicked == false);

            while (Statment == true)
            {
                await Task.Delay(100);
                Statment = (WasButtonAClicked == false && WasButtonBClicked == false && WasButtonCClicked == false && WasButtonDClicked == false);
            }
        }
        */

        private void PrintQuestion()
        {
            CurrentTriviaQuestion = GameControlObject.GetQuestion();

            richTextBoxMainQuestion.Text = CurrentTriviaQuestion.QuestionTrivia;
            richTextBoxOptionAText.Text = CurrentTriviaQuestion.PossibleAnswers[0];
            richTextBoxOptionBText.Text = CurrentTriviaQuestion.PossibleAnswers[1];
            richTextBoxOptionCText.Text = CurrentTriviaQuestion.PossibleAnswers[2];
            richTextBoxOptionDText.Text = CurrentTriviaQuestion.PossibleAnswers[3];
        }

        public void DisableQuestionButtonAnswers(TriviaQuestion CurrentTriviaQuestion)
        {
            buttonMoveOnToTheNextQuestion.Enabled = true;
            buttonMoveOnToTheNextQuestion.Visible = true;
            buttonOptionA.Enabled = false;
            buttonOptionB.Enabled = false;
            buttonOptionC.Enabled = false;
            buttonOptionD.Enabled = false;

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
        }
        private void ProcessAnswer(int QuestionClicked, TriviaQuestion CurrentTriviaQuestion)
        {

            if (QuestionClicked == 0)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 0)
                {
                    AmountofCorrectQuestions += 1;
                }
                DisableQuestionButtonAnswers(CurrentTriviaQuestion);
            }
            else if (QuestionClicked == 1)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 1)
                {
                    AmountofCorrectQuestions += 1;
                }
                DisableQuestionButtonAnswers(CurrentTriviaQuestion);
            }
            else if (QuestionClicked == 2)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 2)
                {
                    AmountofCorrectQuestions += 1;
                }
                DisableQuestionButtonAnswers(CurrentTriviaQuestion);
            }
            else if (QuestionClicked == 3)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 3)
                {
                    AmountofCorrectQuestions += 1;
                }
                DisableQuestionButtonAnswers(CurrentTriviaQuestion);
            }
            else
            {
                labelTopBanner.Text = "Question:";
                richTextBoxMainQuestion.Visible = true;
                buttonOptionA.BackColor = Color.White;
                buttonOptionB.BackColor = Color.White;
                buttonOptionC.BackColor = Color.White;
                buttonOptionD.BackColor = Color.White;
                buttonMoveOnToTheNextQuestion.Enabled = false;
                buttonMoveOnToTheNextQuestion.Visible = false;
            }
        }

        private void buttonOptionA_Click(object sender, EventArgs e)
        {
            ProcessAnswer(0, CurrentTriviaQuestion);
        }

        private void buttonOptionB_Click(object sender, EventArgs e)
        {
            ProcessAnswer(1, CurrentTriviaQuestion);
        }

        private void buttonOptionC_Click(object sender, EventArgs e)
        {
            ProcessAnswer(2, CurrentTriviaQuestion);
        }

        private void buttonOptionD_Click(object sender, EventArgs e)
        {
            ProcessAnswer(3, CurrentTriviaQuestion);
        }

        private void buttonMoveOnToTheNextQuestion_Click(object sender, EventArgs e)
        {
            ProcessAnswer(4, CurrentTriviaQuestion);
        }

        private void TriviaQuestionUI_Load(object sender, EventArgs e)
        {
            buttonMoveOnToTheNextQuestion.Enabled = false;
            buttonMoveOnToTheNextQuestion.Visible = false;

            for (int i = 0; i < AmountofQuestions; i++)
            {
                PrintQuestion();
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
    }
}
