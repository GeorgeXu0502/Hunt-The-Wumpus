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
            SuspendLayout();
            // 
            // labelTopBanner
            // 
            labelTopBanner.AutoSize = true;
            labelTopBanner.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelTopBanner.Location = new Point(12, 18);
            labelTopBanner.Name = "labelTopBanner";
            labelTopBanner.Size = new Size(204, 54);
            labelTopBanner.TabIndex = 0;
            labelTopBanner.Text = "Question: ";
            // 
            // richTextBoxMainQuestion
            // 
            richTextBoxMainQuestion.Location = new Point(313, 18);
            richTextBoxMainQuestion.Name = "richTextBoxMainQuestion";
            richTextBoxMainQuestion.Size = new Size(1130, 150);
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
            richTextBoxOptionAText.Size = new Size(1221, 93);
            richTextBoxOptionAText.TabIndex = 3;
            richTextBoxOptionAText.Text = "";
            // 
            // richTextBoxOptionBText
            // 
            richTextBoxOptionBText.Location = new Point(256, 343);
            richTextBoxOptionBText.Name = "richTextBoxOptionBText";
            richTextBoxOptionBText.Size = new Size(1221, 93);
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
            richTextBoxOptionCText.Size = new Size(1221, 93);
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
            richTextBoxOptionDText.Location = new Point(256, 571);
            richTextBoxOptionDText.Name = "richTextBoxOptionDText";
            richTextBoxOptionDText.Size = new Size(1221, 93);
            richTextBoxOptionDText.TabIndex = 9;
            richTextBoxOptionDText.Text = "";
            // 
            // buttonOptionD
            // 
            buttonOptionD.Location = new Point(37, 571);
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
            // TriviaQuestionUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1498, 812);
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
            Name = "TriviaQuestionUI";
            Text = "TriviaQuestionUI";
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
    }
}