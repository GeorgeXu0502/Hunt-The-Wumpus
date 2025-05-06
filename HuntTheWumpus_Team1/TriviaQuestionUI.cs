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
using Newtonsoft.Json.Bson;
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

        int AmoutofQuestionsAsked = 0;

        TriviaQuestion CurrentTriviaQuestion;

        public TriviaQuestionUI()
        {
            InitializeComponent();
        }

        private void TriviaQuestionUI_Load(object sender, EventArgs e)
        {
            buttonMoveOnToTheNextQuestion.Enabled = false;
            buttonMoveOnToTheNextQuestion.Visible = false;
            PrintQuestion();
        }

        private void PrintQuestion()
        {
            buttonOptionA.Enabled = true;
            buttonOptionB.Enabled = true;
            buttonOptionC.Enabled = true;
            buttonOptionD.Enabled = true;

            buttonMoveOnToTheNextQuestion.Enabled = false;
            buttonMoveOnToTheNextQuestion.Visible = false;

            buttonOptionA.BackColor = Color.White;
            buttonOptionB.BackColor = Color.White;
            buttonOptionC.BackColor = Color.White;
            buttonOptionD.BackColor = Color.White;

            CurrentTriviaQuestion = GameControlObject.GetQuestion();
            AmoutofQuestionsAsked += 1;
            richTextBoxMainQuestion.Text = CurrentTriviaQuestion.QuestionTrivia.ToString();
            richTextBoxOptionAText.Text = CurrentTriviaQuestion.PossibleAnswers[0].ToString();
            richTextBoxOptionBText.Text = CurrentTriviaQuestion.PossibleAnswers[1].ToString();
            richTextBoxOptionCText.Text = CurrentTriviaQuestion.PossibleAnswers[2].ToString();
            richTextBoxOptionDText.Text = CurrentTriviaQuestion.PossibleAnswers[3].ToString();
        }

        private void MovetoTheMidScreen()
        {
            textBoxAmoutOfQuestionsCorrect.Text = AmountofCorrectQuestions.ToString();
            buttonOptionA.Enabled = false;
            buttonOptionB.Enabled = false;
            buttonOptionC.Enabled = false;
            buttonOptionD.Enabled = false;

            buttonMoveOnToTheNextQuestion.Enabled = true;
            buttonMoveOnToTheNextQuestion.Visible = true;
        }

        public void ProcessAnswer(int ButtonPrececd)
        {
            if (ButtonPrececd == 0)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 0)
                {
                    AmountofCorrectQuestions += 1;
                }
                buttonOptionA.BackColor = Color.DarkGreen;
                MovetoTheMidScreen();
            }
            else if (ButtonPrececd == 1)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 1)
                {
                    AmountofCorrectQuestions += 1;
                }
                buttonOptionB.BackColor = Color.DarkGreen;
                MovetoTheMidScreen();
            }
            else if (ButtonPrececd == 2)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 2)
                {
                    AmountofCorrectQuestions += 1;
                }
                buttonOptionC.BackColor = Color.DarkGreen;
                MovetoTheMidScreen();
            }
            else if (ButtonPrececd == 3)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 3)
                {
                    AmountofCorrectQuestions += 1;
                }
                buttonOptionD.BackColor = Color.DarkGreen;
                MovetoTheMidScreen();
            }
        }

        private void buttonOptionA_Click(object sender, EventArgs e)
        {
            ProcessAnswer(0);
        }

        private void buttonOptionB_Click(object sender, EventArgs e)
        {
            ProcessAnswer(1);
        }

        private void buttonOptionC_Click(object sender, EventArgs e)
        {
            ProcessAnswer(2);
        }

        private void buttonOptionD_Click(object sender, EventArgs e)
        {
            ProcessAnswer(3);
        }

        private void buttonMoveOnToTheNextQuestion_Click(object sender, EventArgs e)
        {
            if (AmoutofQuestionsAsked < AmountofQuestions)
            {
                PrintQuestion();
            }
            else
            {

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

                this.Close();
            }
        }
    }
}
