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

        bool ButtonYesClicked = false;
        bool ButtonNoClicked = false;
        public MessageBoxYesorNoCustom()
        {
            InitializeComponent();
        }

        private void MessageBoxYesorNoCustom_Activated(object sender, EventArgs e)
        {
            bool Statment = (ButtonYesClicked == false && ButtonNoClicked == false);

            while (Statment)
            {
                Statment = (ButtonYesClicked == false && ButtonNoClicked == false);
            }

            if (ButtonYesClicked)
            {
                ResultOfQuestion = true;
            }
            else
            {
                ResultOfQuestion = false;
            }
        }

        private void buttonYesContiue_Click(object sender, EventArgs e)
        {
            ButtonYesClicked = true;
        }

        private void buttonNoCountiue_Click(object sender, EventArgs e)
        {
            ButtonNoClicked = true;
        }
    }
}
