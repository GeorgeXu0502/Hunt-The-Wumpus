namespace HuntTheWumpus_Team1
{
    partial class OpeningMenu
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
            buttoStarttheGame = new Button();
            buttonViewPreviousHighScores = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome to this Hunt the Wumpus Game!";
            // 
            // buttoStarttheGame
            // 
            buttoStarttheGame.Location = new Point(243, 256);
            buttoStarttheGame.Name = "buttoStarttheGame";
            buttoStarttheGame.Size = new Size(303, 75);
            buttoStarttheGame.TabIndex = 1;
            buttoStarttheGame.Text = "Start Game";
            buttoStarttheGame.UseVisualStyleBackColor = true;
            buttoStarttheGame.Click += buttoStarttheGame_Click;
            // 
            // buttonViewPreviousHighScores
            // 
            buttonViewPreviousHighScores.Location = new Point(243, 337);
            buttonViewPreviousHighScores.Name = "buttonViewPreviousHighScores";
            buttonViewPreviousHighScores.Size = new Size(303, 75);
            buttonViewPreviousHighScores.TabIndex = 2;
            buttonViewPreviousHighScores.Text = "View Previous High Scores";
            buttonViewPreviousHighScores.UseVisualStyleBackColor = true;
            // 
            // OpeningMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonViewPreviousHighScores);
            Controls.Add(buttoStarttheGame);
            Controls.Add(label1);
            Name = "OpeningMenu";
            Text = "OpeningMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttoStarttheGame;
        private Button buttonViewPreviousHighScores;
    }
}