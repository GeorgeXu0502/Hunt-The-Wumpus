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
        bool AllowedtoClose = false;
        public int AmountofQuestions { get; set; } // Amount of Questions to Ask. 

        public bool GotOffWithQuestions; // Did we make the required question amount?

        public bool GotOffWithCoins; // Do we still have more than -1 coins? 

        public Player_GameControl GameControlObject { get; set; }

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

        /// <summary>
        /// Print the Correct Question along with the Right Answer Choiced. Enable all of the buttons to be pressed. 
        /// </summary>
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

        /// <summary>
        /// Allow the Form to move to a Screen so that the User can only choose to go to the next Question. 
        /// </summary>
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

        /// <summary>
        /// Process the Answer of the User. Showcase the correct Answer and showcase the incorrect answer if it was choosen by the User. 
        /// </summary>
        /// <param name="ButtonPrececd"> The button answer that the USer Clicked. 0 - A, 1- B, 2- C, 3 - D. </param>
        public void ProcessAnswer(int ButtonPrececd)
        {
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

            if (ButtonPrececd == 0)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 0)
                {
                    AmountofCorrectQuestions += 1;
                }
                else
                {
                    buttonOptionA.BackColor = Color.DarkRed;
                }

                    MovetoTheMidScreen();
            }
            else if (ButtonPrececd == 1)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 1)
                {
                    AmountofCorrectQuestions += 1;
                }
                else
                {
                    buttonOptionB.BackColor = Color.DarkRed;
                }

                MovetoTheMidScreen();
            }
            else if (ButtonPrececd == 2)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 2)
                {
                    AmountofCorrectQuestions += 1;
                }
                else
                {
                    buttonOptionC.BackColor = Color.DarkRed;
                }

                MovetoTheMidScreen();
            }
            else if (ButtonPrececd == 3)
            {
                if (CurrentTriviaQuestion.CorrectAnswerIndex == 3)
                {
                    AmountofCorrectQuestions += 1;
                }
                else
                {
                    buttonOptionD.BackColor = Color.DarkRed;
                }

                MovetoTheMidScreen();
            }
        }

        // Next few buttons showcase what to do when the User clickes an answer button. 
        private void buttonOptionA_Click(object sender, EventArgs e)
        {
            GameControlObject.RemoveGoldCoin();
            System.Diagnostics.Debug.WriteLine("Amount of Coins: " + GameControlObject.PlayerGoldCoinAmount().ToString());
            ProcessAnswer(0);
        }

        private void buttonOptionB_Click(object sender, EventArgs e)
        {
            GameControlObject.RemoveGoldCoin();
            ProcessAnswer(1);
        }

        private void buttonOptionC_Click(object sender, EventArgs e)
        {
            GameControlObject.RemoveGoldCoin();
            ProcessAnswer(2);
        }

        private void buttonOptionD_Click(object sender, EventArgs e)
        {
            GameControlObject.RemoveGoldCoin();
            ProcessAnswer(3);
        }

        /// <summary>
        /// Move on to the Next Question, by printing the next question, but if all the questions have already been asked, caluclate all the quantities and move on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                else if (AmountofQuestions == 3 && AmountofCorrectQuestions < 2)
                {
                    GotOffWithQuestions = false;
                }
                else
                {
                    GotOffWithQuestions = true;
                }
                AllowedtoClose = true;
                this.Close();
            }
        }

        /// <summary>
        /// Only allow the form to close when the Game allows for it. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriviaQuestionUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedtoClose)
            {
                e.Cancel = true;
            }
        }
    }
}
