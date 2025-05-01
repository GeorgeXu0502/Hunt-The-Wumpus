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
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(769, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome to this Hunt the Wumpus Game!";
            // 
            // buttoStarttheGame
            // 
            buttoStarttheGame.Location = new Point(347, 427);
            buttoStarttheGame.Margin = new Padding(4, 5, 4, 5);
            buttoStarttheGame.Name = "buttoStarttheGame";
            buttoStarttheGame.Size = new Size(433, 125);
            buttoStarttheGame.TabIndex = 1;
            buttoStarttheGame.Text = "Start Game";
            buttoStarttheGame.UseVisualStyleBackColor = true;
            buttoStarttheGame.Click += buttoStarttheGame_Click;
            // 
            // buttonViewPreviousHighScores
            // 
            buttonViewPreviousHighScores.Location = new Point(347, 562);
            buttonViewPreviousHighScores.Margin = new Padding(4, 5, 4, 5);
            buttonViewPreviousHighScores.Name = "buttonViewPreviousHighScores";
            buttonViewPreviousHighScores.Size = new Size(433, 125);
            buttonViewPreviousHighScores.TabIndex = 2;
            buttonViewPreviousHighScores.Text = "View Previous High Scores";
            buttonViewPreviousHighScores.UseVisualStyleBackColor = true;
            // 
            // OpeningMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1143, 750);
            Controls.Add(buttonViewPreviousHighScores);
            Controls.Add(buttoStarttheGame);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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