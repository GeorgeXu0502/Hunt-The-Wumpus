namespace HuntTheWumpus_Team1
{
    partial class HighScoreUI
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
            textBoxPlayerScore = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxTopScore1 = new TextBox();
            textBoxTopScore2 = new TextBox();
            label4 = new Label();
            textBoxTopScore3 = new TextBox();
            label5 = new Label();
            textBoxTopScore4 = new TextBox();
            label6 = new Label();
            textBoxTopScore5 = new TextBox();
            label7 = new Label();
            buttonExitTheGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(218, 54);
            label1.TabIndex = 0;
            label1.Text = "Your Score:";
            // 
            // textBoxPlayerScore
            // 
            textBoxPlayerScore.Font = new Font("Segoe UI", 20F);
            textBoxPlayerScore.Location = new Point(268, 27);
            textBoxPlayerScore.Name = "textBoxPlayerScore";
            textBoxPlayerScore.ReadOnly = true;
            textBoxPlayerScore.Size = new Size(490, 61);
            textBoxPlayerScore.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(221, 54);
            label2.TabIndex = 2;
            label2.Text = "Top Scores:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(104, 245);
            label3.Name = "label3";
            label3.Size = new Size(26, 25);
            label3.TabIndex = 3;
            label3.Text = "1.";
            // 
            // textBoxTopScore1
            // 
            textBoxTopScore1.Font = new Font("Segoe UI", 9F);
            textBoxTopScore1.Location = new Point(188, 239);
            textBoxTopScore1.Name = "textBoxTopScore1";
            textBoxTopScore1.ReadOnly = true;
            textBoxTopScore1.Size = new Size(490, 31);
            textBoxTopScore1.TabIndex = 4;
            // 
            // textBoxTopScore2
            // 
            textBoxTopScore2.Font = new Font("Segoe UI", 9F);
            textBoxTopScore2.Location = new Point(188, 302);
            textBoxTopScore2.Name = "textBoxTopScore2";
            textBoxTopScore2.ReadOnly = true;
            textBoxTopScore2.Size = new Size(490, 31);
            textBoxTopScore2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(104, 308);
            label4.Name = "label4";
            label4.Size = new Size(26, 25);
            label4.TabIndex = 5;
            label4.Text = "2.";
            // 
            // textBoxTopScore3
            // 
            textBoxTopScore3.Font = new Font("Segoe UI", 9F);
            textBoxTopScore3.Location = new Point(188, 369);
            textBoxTopScore3.Name = "textBoxTopScore3";
            textBoxTopScore3.ReadOnly = true;
            textBoxTopScore3.Size = new Size(490, 31);
            textBoxTopScore3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(104, 375);
            label5.Name = "label5";
            label5.Size = new Size(26, 25);
            label5.TabIndex = 7;
            label5.Text = "3.";
            // 
            // textBoxTopScore4
            // 
            textBoxTopScore4.Font = new Font("Segoe UI", 9F);
            textBoxTopScore4.Location = new Point(188, 430);
            textBoxTopScore4.Name = "textBoxTopScore4";
            textBoxTopScore4.ReadOnly = true;
            textBoxTopScore4.Size = new Size(490, 31);
            textBoxTopScore4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(104, 436);
            label6.Name = "label6";
            label6.Size = new Size(26, 25);
            label6.TabIndex = 9;
            label6.Text = "4.";
            // 
            // textBoxTopScore5
            // 
            textBoxTopScore5.Font = new Font("Segoe UI", 9F);
            textBoxTopScore5.Location = new Point(188, 491);
            textBoxTopScore5.Name = "textBoxTopScore5";
            textBoxTopScore5.ReadOnly = true;
            textBoxTopScore5.Size = new Size(490, 31);
            textBoxTopScore5.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(104, 497);
            label7.Name = "label7";
            label7.Size = new Size(26, 25);
            label7.TabIndex = 11;
            label7.Text = "5.";
            // 
            // buttonExitTheGame
            // 
            buttonExitTheGame.Location = new Point(725, 245);
            buttonExitTheGame.Name = "buttonExitTheGame";
            buttonExitTheGame.Size = new Size(259, 128);
            buttonExitTheGame.TabIndex = 13;
            buttonExitTheGame.Text = "Close the Whole Game";
            buttonExitTheGame.UseVisualStyleBackColor = true;
            buttonExitTheGame.Click += buttonExitTheGame_Click;
            // 
            // HighScoreUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1026, 595);
            Controls.Add(buttonExitTheGame);
            Controls.Add(textBoxTopScore5);
            Controls.Add(label7);
            Controls.Add(textBoxTopScore4);
            Controls.Add(label6);
            Controls.Add(textBoxTopScore3);
            Controls.Add(label5);
            Controls.Add(textBoxTopScore2);
            Controls.Add(label4);
            Controls.Add(textBoxTopScore1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPlayerScore);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Name = "HighScoreUI";
            Text = "HighScoreUI";
            Load += HighScoreUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPlayerScore;
        private Label label2;
        private Label label3;
        private TextBox textBoxTopScore1;
        private TextBox textBoxTopScore2;
        private Label label4;
        private TextBox textBoxTopScore3;
        private Label label5;
        private TextBox textBoxTopScore4;
        private Label label6;
        private TextBox textBoxTopScore5;
        private Label label7;
        private Button buttonExitTheGame;
    }
}