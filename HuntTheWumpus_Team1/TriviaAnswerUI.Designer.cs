namespace HuntTheWumpus_Team1
{
    partial class TriviaAnswerUI
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
            label1 = new Label();
            richTextBoxMainQuestion = new RichTextBox();
            buttonOptionA = new Button();
            richTextBoxOptionA = new RichTextBox();
            richTextBoxOptionB = new RichTextBox();
            buttonOptionB = new Button();
            richTextBoxOptionC = new RichTextBox();
            buttonOptionC = new Button();
            richTextBoxOptionD = new RichTextBox();
            buttonOptionD = new Button();
            buttonContiue = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(193, 54);
            label1.TabIndex = 0;
            label1.Text = "Question:";
            // 
            // richTextBoxMainQuestion
            // 
            richTextBoxMainQuestion.Location = new Point(241, 37);
            richTextBoxMainQuestion.Name = "richTextBoxMainQuestion";
            richTextBoxMainQuestion.ReadOnly = true;
            richTextBoxMainQuestion.Size = new Size(1254, 164);
            richTextBoxMainQuestion.TabIndex = 1;
            richTextBoxMainQuestion.Text = "";
            // 
            // buttonOptionA
            // 
            buttonOptionA.Location = new Point(10, 262);
            buttonOptionA.Name = "buttonOptionA";
            buttonOptionA.Size = new Size(233, 97);
            buttonOptionA.TabIndex = 2;
            buttonOptionA.Text = "Option A:";
            buttonOptionA.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOptionA
            // 
            richTextBoxOptionA.Location = new Point(263, 262);
            richTextBoxOptionA.Name = "richTextBoxOptionA";
            richTextBoxOptionA.ReadOnly = true;
            richTextBoxOptionA.Size = new Size(1254, 97);
            richTextBoxOptionA.TabIndex = 3;
            richTextBoxOptionA.Text = "";
            // 
            // richTextBoxOptionB
            // 
            richTextBoxOptionB.Location = new Point(263, 382);
            richTextBoxOptionB.Name = "richTextBoxOptionB";
            richTextBoxOptionB.ReadOnly = true;
            richTextBoxOptionB.Size = new Size(1254, 97);
            richTextBoxOptionB.TabIndex = 5;
            richTextBoxOptionB.Text = "";
            // 
            // buttonOptionB
            // 
            buttonOptionB.Location = new Point(10, 382);
            buttonOptionB.Name = "buttonOptionB";
            buttonOptionB.Size = new Size(233, 97);
            buttonOptionB.TabIndex = 4;
            buttonOptionB.Text = "Option B:";
            buttonOptionB.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOptionC
            // 
            richTextBoxOptionC.Location = new Point(263, 497);
            richTextBoxOptionC.Name = "richTextBoxOptionC";
            richTextBoxOptionC.ReadOnly = true;
            richTextBoxOptionC.Size = new Size(1254, 97);
            richTextBoxOptionC.TabIndex = 7;
            richTextBoxOptionC.Text = "";
            // 
            // buttonOptionC
            // 
            buttonOptionC.Location = new Point(10, 497);
            buttonOptionC.Name = "buttonOptionC";
            buttonOptionC.Size = new Size(233, 97);
            buttonOptionC.TabIndex = 6;
            buttonOptionC.Text = "Option C:";
            buttonOptionC.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOptionD
            // 
            richTextBoxOptionD.Location = new Point(263, 618);
            richTextBoxOptionD.Name = "richTextBoxOptionD";
            richTextBoxOptionD.ReadOnly = true;
            richTextBoxOptionD.Size = new Size(1254, 97);
            richTextBoxOptionD.TabIndex = 9;
            richTextBoxOptionD.Text = "";
            // 
            // buttonOptionD
            // 
            buttonOptionD.Location = new Point(10, 618);
            buttonOptionD.Name = "buttonOptionD";
            buttonOptionD.Size = new Size(233, 97);
            buttonOptionD.TabIndex = 8;
            buttonOptionD.Text = "Option D:";
            buttonOptionD.UseVisualStyleBackColor = true;
            // 
            // buttonContiue
            // 
            buttonContiue.Location = new Point(11, 743);
            buttonContiue.Name = "buttonContiue";
            buttonContiue.Size = new Size(233, 97);
            buttonContiue.TabIndex = 10;
            buttonContiue.Text = "Contiue to the Room";
            buttonContiue.UseVisualStyleBackColor = true;
            buttonContiue.Click += buttonContiue_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(814, 757);
            label2.Name = "label2";
            label2.Size = new Size(682, 54);
            label2.TabIndex = 11;
            label2.Text = "A hint to help in the comming Room!";
            // 
            // TriviaAnswerUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1547, 868);
            Controls.Add(label2);
            Controls.Add(buttonContiue);
            Controls.Add(richTextBoxOptionD);
            Controls.Add(buttonOptionD);
            Controls.Add(richTextBoxOptionC);
            Controls.Add(buttonOptionC);
            Controls.Add(richTextBoxOptionB);
            Controls.Add(buttonOptionB);
            Controls.Add(richTextBoxOptionA);
            Controls.Add(buttonOptionA);
            Controls.Add(richTextBoxMainQuestion);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TriviaAnswerUI";
            Text = "TriviaAnswerUI";
            FormClosing += TriviaAnswerUI_FormClosing;
            Load += TriviaAnswerUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxMainQuestion;
        private Button buttonOptionA;
        private RichTextBox richTextBoxOptionA;
        private RichTextBox richTextBoxOptionB;
        private Button buttonOptionB;
        private RichTextBox richTextBoxOptionC;
        private Button buttonOptionC;
        private RichTextBox richTextBoxOptionD;
        private Button buttonOptionD;
        private Button buttonContiue;
        private Label label2;
    }
}