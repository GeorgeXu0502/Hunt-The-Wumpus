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
            labelTopBanner.Location = new Point(11, 18);
            labelTopBanner.Name = "labelTopBanner";
            labelTopBanner.Size = new Size(204, 54);
            labelTopBanner.TabIndex = 0;
            labelTopBanner.Text = "Question: ";
            // 
            // richTextBoxMainQuestion
            // 
            richTextBoxMainQuestion.Location = new Point(313, 18);
            richTextBoxMainQuestion.Name = "richTextBoxMainQuestion";
            richTextBoxMainQuestion.ReadOnly = true;
            richTextBoxMainQuestion.Size = new Size(1130, 151);
            richTextBoxMainQuestion.TabIndex = 1;
            richTextBoxMainQuestion.Text = "";
            // 
            // buttonOptionA
            // 
            buttonOptionA.Location = new Point(37, 227);
            buttonOptionA.Name = "buttonOptionA";
            buttonOptionA.Size = new Size(183, 93);
            buttonOptionA.TabIndex = 2;
            buttonOptionA.Text = "Option A:";
            buttonOptionA.UseVisualStyleBackColor = true;
            buttonOptionA.Click += buttonOptionA_Click;
            // 
            // richTextBoxOptionAText
            // 
            richTextBoxOptionAText.Location = new Point(256, 227);
            richTextBoxOptionAText.Name = "richTextBoxOptionAText";
            richTextBoxOptionAText.ReadOnly = true;
            richTextBoxOptionAText.Size = new Size(1221, 92);
            richTextBoxOptionAText.TabIndex = 3;
            richTextBoxOptionAText.Text = "";
            // 
            // richTextBoxOptionBText
            // 
            richTextBoxOptionBText.Location = new Point(256, 343);
            richTextBoxOptionBText.Name = "richTextBoxOptionBText";
            richTextBoxOptionBText.ReadOnly = true;
            richTextBoxOptionBText.Size = new Size(1221, 92);
            richTextBoxOptionBText.TabIndex = 5;
            richTextBoxOptionBText.Text = "";
            // 
            // buttonOptionB
            // 
            buttonOptionB.Location = new Point(37, 343);
            buttonOptionB.Name = "buttonOptionB";
            buttonOptionB.Size = new Size(183, 93);
            buttonOptionB.TabIndex = 4;
            buttonOptionB.Text = "Option B:";
            buttonOptionB.UseVisualStyleBackColor = true;
            buttonOptionB.Click += buttonOptionB_Click;
            // 
            // richTextBoxOptionCText
            // 
            richTextBoxOptionCText.Location = new Point(256, 458);
            richTextBoxOptionCText.Name = "richTextBoxOptionCText";
            richTextBoxOptionCText.ReadOnly = true;
            richTextBoxOptionCText.Size = new Size(1221, 92);
            richTextBoxOptionCText.TabIndex = 7;
            richTextBoxOptionCText.Text = "";
            // 
            // buttonOptionC
            // 
            buttonOptionC.Location = new Point(37, 458);
            buttonOptionC.Name = "buttonOptionC";
            buttonOptionC.Size = new Size(183, 93);
            buttonOptionC.TabIndex = 6;
            buttonOptionC.Text = "Opion C:";
            buttonOptionC.UseVisualStyleBackColor = true;
            buttonOptionC.Click += buttonOptionC_Click;
            // 
            // richTextBoxOptionDText
            // 
            richTextBoxOptionDText.Location = new Point(256, 572);
            richTextBoxOptionDText.Name = "richTextBoxOptionDText";
            richTextBoxOptionDText.ReadOnly = true;
            richTextBoxOptionDText.Size = new Size(1221, 92);
            richTextBoxOptionDText.TabIndex = 9;
            richTextBoxOptionDText.Text = "";
            // 
            // buttonOptionD
            // 
            buttonOptionD.Location = new Point(37, 572);
            buttonOptionD.Name = "buttonOptionD";
            buttonOptionD.Size = new Size(183, 93);
            buttonOptionD.TabIndex = 8;
            buttonOptionD.Text = "Option D:";
            buttonOptionD.UseVisualStyleBackColor = true;
            buttonOptionD.Click += buttonOptionD_Click;
            // 
            // buttonMoveOnToTheNextQuestion
            // 
            buttonMoveOnToTheNextQuestion.Location = new Point(37, 707);
            buttonMoveOnToTheNextQuestion.Name = "buttonMoveOnToTheNextQuestion";
            buttonMoveOnToTheNextQuestion.Size = new Size(183, 93);
            buttonMoveOnToTheNextQuestion.TabIndex = 10;
            buttonMoveOnToTheNextQuestion.Text = "Move On To The Next Question";
            buttonMoveOnToTheNextQuestion.UseVisualStyleBackColor = true;
            buttonMoveOnToTheNextQuestion.Click += buttonMoveOnToTheNextQuestion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 707);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 11;
            label1.Text = "Amout of Questions Correct:";
            // 
            // textBoxAmoutOfQuestionsCorrect
            // 
            textBoxAmoutOfQuestionsCorrect.Location = new Point(537, 701);
            textBoxAmoutOfQuestionsCorrect.Margin = new Padding(4, 5, 4, 5);
            textBoxAmoutOfQuestionsCorrect.Name = "textBoxAmoutOfQuestionsCorrect";
            textBoxAmoutOfQuestionsCorrect.ReadOnly = true;
            textBoxAmoutOfQuestionsCorrect.Size = new Size(271, 31);
            textBoxAmoutOfQuestionsCorrect.TabIndex = 12;
            // 
            // TriviaQuestionUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1499, 812);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TriviaQuestionUI";
            Text = "TriviaQuestionUI";
            FormClosing += TriviaQuestionUI_FormClosing;
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