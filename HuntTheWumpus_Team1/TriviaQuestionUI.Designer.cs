namespace HuntTheWumpus_Team1
{
    partial class TriviaQuestionUI
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
            labelTopBanner = new Label();
            richTextBoxMainQuestion = new RichTextBox();
            buttonOptionA = new Button();
            richTextBoxOptionAText = new RichTextBox();
            richTextBoxOptionBText = new RichTextBox();
            buttonOptionB = new Button();
            richTextBoxOptionCText = new RichTextBox();
            buttonOptionC = new Button();
            richTextBoxOptionDText = new RichTextBox();
            buttonOptionD = new Button();
            buttonMoveOnToTheNextQuestion = new Button();
            label1 = new Label();
            textBoxAmoutOfQuestionsCorrect = new TextBox();
            SuspendLayout();
            // 
            // labelTopBanner
            // 
            labelTopBanner.AutoSize = true;
            labelTopBanner.Font = new Font("Segoe UI", 20F);
            labelTopBanner.Location = new Point(8, 11);
            labelTopBanner.Margin = new Padding(2, 0, 2, 0);
            labelTopBanner.Name = "labelTopBanner";
            labelTopBanner.Size = new Size(137, 37);
            labelTopBanner.TabIndex = 0;
            labelTopBanner.Text = "Question: ";
            // 
            // richTextBoxMainQuestion
            // 
            richTextBoxMainQuestion.Location = new Point(219, 11);
            richTextBoxMainQuestion.Margin = new Padding(2);
            richTextBoxMainQuestion.Name = "richTextBoxMainQuestion";
            richTextBoxMainQuestion.ReadOnly = true;
            richTextBoxMainQuestion.Size = new Size(792, 92);
            richTextBoxMainQuestion.TabIndex = 1;
            richTextBoxMainQuestion.Text = "";
            // 
            // buttonOptionA
            // 
            buttonOptionA.Location = new Point(26, 136);
            buttonOptionA.Margin = new Padding(2);
            buttonOptionA.Name = "buttonOptionA";
            buttonOptionA.Size = new Size(128, 56);
            buttonOptionA.TabIndex = 2;
            buttonOptionA.Text = "Option A:";
            buttonOptionA.UseVisualStyleBackColor = true;
            buttonOptionA.Click += buttonOptionA_Click;
            // 
            // richTextBoxOptionAText
            // 
            richTextBoxOptionAText.Location = new Point(179, 136);
            richTextBoxOptionAText.Margin = new Padding(2);
            richTextBoxOptionAText.Name = "richTextBoxOptionAText";
            richTextBoxOptionAText.ReadOnly = true;
            richTextBoxOptionAText.Size = new Size(856, 57);
            richTextBoxOptionAText.TabIndex = 3;
            richTextBoxOptionAText.Text = "";
            // 
            // richTextBoxOptionBText
            // 
            richTextBoxOptionBText.Location = new Point(179, 206);
            richTextBoxOptionBText.Margin = new Padding(2);
            richTextBoxOptionBText.Name = "richTextBoxOptionBText";
            richTextBoxOptionBText.ReadOnly = true;
            richTextBoxOptionBText.Size = new Size(856, 57);
            richTextBoxOptionBText.TabIndex = 5;
            richTextBoxOptionBText.Text = "";
            // 
            // buttonOptionB
            // 
            buttonOptionB.Location = new Point(26, 206);
            buttonOptionB.Margin = new Padding(2);
            buttonOptionB.Name = "buttonOptionB";
            buttonOptionB.Size = new Size(128, 56);
            buttonOptionB.TabIndex = 4;
            buttonOptionB.Text = "Option B:";
            buttonOptionB.UseVisualStyleBackColor = true;
            buttonOptionB.Click += buttonOptionB_Click;
            // 
            // richTextBoxOptionCText
            // 
            richTextBoxOptionCText.Location = new Point(179, 275);
            richTextBoxOptionCText.Margin = new Padding(2);
            richTextBoxOptionCText.Name = "richTextBoxOptionCText";
            richTextBoxOptionCText.ReadOnly = true;
            richTextBoxOptionCText.Size = new Size(856, 57);
            richTextBoxOptionCText.TabIndex = 7;
            richTextBoxOptionCText.Text = "";
            // 
            // buttonOptionC
            // 
            buttonOptionC.Location = new Point(26, 275);
            buttonOptionC.Margin = new Padding(2);
            buttonOptionC.Name = "buttonOptionC";
            buttonOptionC.Size = new Size(128, 56);
            buttonOptionC.TabIndex = 6;
            buttonOptionC.Text = "Opion C:";
            buttonOptionC.UseVisualStyleBackColor = true;
            buttonOptionC.Click += buttonOptionC_Click;
            // 
            // richTextBoxOptionDText
            // 
            richTextBoxOptionDText.Location = new Point(179, 343);
            richTextBoxOptionDText.Margin = new Padding(2);
            richTextBoxOptionDText.Name = "richTextBoxOptionDText";
            richTextBoxOptionDText.ReadOnly = true;
            richTextBoxOptionDText.Size = new Size(856, 57);
            richTextBoxOptionDText.TabIndex = 9;
            richTextBoxOptionDText.Text = "";
            // 
            // buttonOptionD
            // 
            buttonOptionD.Location = new Point(26, 343);
            buttonOptionD.Margin = new Padding(2);
            buttonOptionD.Name = "buttonOptionD";
            buttonOptionD.Size = new Size(128, 56);
            buttonOptionD.TabIndex = 8;
            buttonOptionD.Text = "Option D:";
            buttonOptionD.UseVisualStyleBackColor = true;
            buttonOptionD.Click += buttonOptionD_Click;
            // 
            // buttonMoveOnToTheNextQuestion
            // 
            buttonMoveOnToTheNextQuestion.Location = new Point(26, 424);
            buttonMoveOnToTheNextQuestion.Margin = new Padding(2);
            buttonMoveOnToTheNextQuestion.Name = "buttonMoveOnToTheNextQuestion";
            buttonMoveOnToTheNextQuestion.Size = new Size(128, 56);
            buttonMoveOnToTheNextQuestion.TabIndex = 10;
            buttonMoveOnToTheNextQuestion.Text = "Move On To The Next Question";
            buttonMoveOnToTheNextQuestion.UseVisualStyleBackColor = true;
            buttonMoveOnToTheNextQuestion.Click += buttonMoveOnToTheNextQuestion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 424);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 11;
            label1.Text = "Amout of Questions Correct:";
            // 
            // textBoxAmoutOfQuestionsCorrect
            // 
            textBoxAmoutOfQuestionsCorrect.Location = new Point(367, 416);
            textBoxAmoutOfQuestionsCorrect.Name = "textBoxAmoutOfQuestionsCorrect";
            textBoxAmoutOfQuestionsCorrect.ReadOnly = true;
            textBoxAmoutOfQuestionsCorrect.Size = new Size(191, 23);
            textBoxAmoutOfQuestionsCorrect.TabIndex = 12;
            // 
            // TriviaQuestionUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1049, 487);
            Controls.Add(textBoxAmoutOfQuestionsCorrect);
            Controls.Add(label1);
            Controls.Add(buttonMoveOnToTheNextQuestion);
            Controls.Add(richTextBoxOptionDText);
            Controls.Add(buttonOptionD);
            Controls.Add(richTextBoxOptionCText);
            Controls.Add(buttonOptionC);
            Controls.Add(richTextBoxOptionBText);
            Controls.Add(buttonOptionB);
            Controls.Add(richTextBoxOptionAText);
            Controls.Add(buttonOptionA);
            Controls.Add(richTextBoxMainQuestion);
            Controls.Add(labelTopBanner);
            Margin = new Padding(2);
            Name = "TriviaQuestionUI";
            Text = "TriviaQuestionUI";
            Load += TriviaQuestionUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTopBanner;
        private RichTextBox richTextBoxMainQuestion;
        private Button buttonOptionA;
        private RichTextBox richTextBoxOptionAText;
        private RichTextBox richTextBoxOptionBText;
        private Button buttonOptionB;
        private RichTextBox richTextBoxOptionCText;
        private Button buttonOptionC;
        private RichTextBox richTextBoxOptionDText;
        private Button buttonOptionD;
        private Button buttonMoveOnToTheNextQuestion;
        private Label label1;
        private TextBox textBoxAmoutOfQuestionsCorrect;
    }
}