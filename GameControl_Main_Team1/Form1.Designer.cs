namespace GameControl_Main_Team1
{
    partial class Form1
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
            buttonDisplayHighScore = new Button();
            buttonStartNewGame = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonDisplayHighScore
            // 
            buttonDisplayHighScore.Location = new Point(20, 71);
            buttonDisplayHighScore.Name = "buttonDisplayHighScore";
            buttonDisplayHighScore.Size = new Size(136, 43);
            buttonDisplayHighScore.TabIndex = 0;
            buttonDisplayHighScore.Text = "Display High Score";
            buttonDisplayHighScore.UseVisualStyleBackColor = true;
            // 
            // buttonStartNewGame
            // 
            buttonStartNewGame.Location = new Point(20, 12);
            buttonStartNewGame.Name = "buttonStartNewGame";
            buttonStartNewGame.Size = new Size(136, 43);
            buttonStartNewGame.TabIndex = 1;
            buttonStartNewGame.Text = "Start New Game";
            buttonStartNewGame.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(20, 133);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(136, 43);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonStartNewGame);
            Controls.Add(buttonDisplayHighScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDisplayHighScore;
        private Button buttonStartNewGame;
        private Button buttonExit;
    }
}