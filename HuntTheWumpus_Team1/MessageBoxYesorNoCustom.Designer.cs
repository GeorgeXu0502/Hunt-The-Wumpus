namespace HuntTheWumpus_Team1
{
    partial class MessageBoxYesorNoCustom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBoxMainQuestion = new RichTextBox();
            buttonYesContiue = new Button();
            buttonNoCountiue = new Button();
            SuspendLayout();
            // 
            // richTextBoxMainQuestion
            // 
            richTextBoxMainQuestion.BackColor = SystemColors.Window;
            richTextBoxMainQuestion.Location = new Point(119, 65);
            richTextBoxMainQuestion.Name = "richTextBoxMainQuestion";
            richTextBoxMainQuestion.Size = new Size(672, 298);
            richTextBoxMainQuestion.TabIndex = 0;
            richTextBoxMainQuestion.Text = "";
            // 
            // buttonYesContiue
            // 
            buttonYesContiue.Location = new Point(156, 385);
            buttonYesContiue.Name = "buttonYesContiue";
            buttonYesContiue.Size = new Size(227, 139);
            buttonYesContiue.TabIndex = 1;
            buttonYesContiue.Text = "Yes, Continue";
            buttonYesContiue.UseVisualStyleBackColor = true;
            buttonYesContiue.Click += buttonYesContiue_Click;
            // 
            // buttonNoCountiue
            // 
            buttonNoCountiue.Location = new Point(451, 385);
            buttonNoCountiue.Name = "buttonNoCountiue";
            buttonNoCountiue.Size = new Size(227, 139);
            buttonNoCountiue.TabIndex = 2;
            buttonNoCountiue.Text = "No, Stop";
            buttonNoCountiue.UseVisualStyleBackColor = true;
            buttonNoCountiue.Click += buttonNoCountiue_Click;
            // 
            // MessageBoxYesorNoCustom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(966, 536);
            Controls.Add(buttonNoCountiue);
            Controls.Add(buttonYesContiue);
            Controls.Add(richTextBoxMainQuestion);
            Name = "MessageBoxYesorNoCustom";
            Text = "MessageBoxYesorNoCustom";
            Activated += MessageBoxYesorNoCustom_Activated;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxMainQuestion;
        private Button buttonYesContiue;
        private Button buttonNoCountiue;
    }
}