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
            label2 = new Label();
            textBoxUsername = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(515, 37);
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
            buttonViewPreviousHighScores.Click += buttonViewPreviousHighScores_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(184, 21);
            label2.TabIndex = 3;
            label2.Text = "Please Enter a Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(219, 115);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(378, 29);
            textBoxUsername.TabIndex = 4;
            // 
            // OpeningMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(buttonViewPreviousHighScores);
            Controls.Add(buttoStarttheGame);
            Controls.Add(label1);
            Name = "OpeningMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpeningMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttoStarttheGame;
        private Button buttonViewPreviousHighScores;
        private Label label2;
        private TextBox textBoxUsername;
    }
}