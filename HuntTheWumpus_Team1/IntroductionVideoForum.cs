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
    public partial class IntroductionVideoForum : Form
    {
        int IndexOfStory = 0;
        bool AllowedToClose = false;
        public IntroductionVideoForum()
        {
            InitializeComponent();
        }

        private void IntroductionVideoForum_Load(object sender, EventArgs e)
        {
            pictureBoxGalaxy.Visible = false;
            labelTextToStory.Visible = false;
        }

        private void ContinueWithTheStory(int IndexofStory)
        {
            if (IndexofStory == 1)
            {
                labelTextToStory.Visible = true;
            }
            else if (IndexofStory == 2)
            {
                labelTextToStory.Text = "A giant galaxy appread out of no where!";
                pictureBoxGalaxy.Visible = true;
            }
            else if (IndexofStory == 3)
            {
                labelTextToStory.Text = "You could not get away from it!";

                while (pictureBoxAustronaut.Location.X < pictureBoxGalaxy.Location.X || pictureBoxAustronaut.Location.Y > pictureBoxGalaxy.Location.Y)
                {
                    int originalXValue = pictureBoxAustronaut.Location.X;
                    int originalYValue = pictureBoxAustronaut.Location.Y;

                    pictureBoxAustronaut.Location = new Point(originalXValue + 5, originalYValue - 2);
                    Thread.Sleep(50);
                }

                pictureBoxGalaxy.Visible = false;
                labelTextToStory.Visible = false;
                pictureBoxAustronaut.Visible = false;
                pictureBoxJupiter.Visible = false;
                pictureBoxStaturn.Visible = false;
                buttonContiueWithStory.Visible = false;

                int IndexColorChange = 0;

                while (IndexColorChange < 500)
                {
                    Random RandomVariable = new Random();
                    int RValue = RandomVariable.Next(1, 250);
                    int GValue = RandomVariable.Next(1, 250);
                    int BValue = RandomVariable.Next(1, 250);
                    this.BackColor = Color.FromArgb(RValue, GValue, BValue);
                    IndexColorChange += 1;
                }
                buttonContiueWithStory.Visible = true;
            }
            else if (IndexofStory == 4)
            {

                labelTextToStory.Text = "Good Luck in the Game!";
                labelTextToStory.Visible = true;
                
            }
            else if (IndexofStory == 5)
            {
                AllowedToClose = true;
                this.Close();
            }
        }
        private void buttonContiueWithStory_Click(object sender, EventArgs e)
        {
            IndexOfStory += 1;
            ContinueWithTheStory(IndexOfStory);
        }

        private void IntroductionVideoForum_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowedToClose)
            {
                e.Cancel = true;
            }
        }
    }
}
