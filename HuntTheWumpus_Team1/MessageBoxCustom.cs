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
        public MessageBoxCustom()
        {
            InitializeComponent();

            richTextBoxDispaly.Text = StringToDispaly;

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
