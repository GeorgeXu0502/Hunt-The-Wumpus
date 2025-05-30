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
            buttonLogIn = new Button();
            buttonCreateAnAccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(17, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(769, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome to this Hunt the Wumpus Game!";
            // 
            // buttoStarttheGame
            // 
            buttoStarttheGame.Location = new Point(112, 335);
            buttoStarttheGame.Margin = new Padding(4, 5, 4, 5);
            buttoStarttheGame.Name = "buttoStarttheGame";
            buttoStarttheGame.Size = new Size(433, 125);
            buttoStarttheGame.TabIndex = 1;
            buttoStarttheGame.Text = "Start Game: (Please enter a Username to Use As a Guest)";
            buttoStarttheGame.UseVisualStyleBackColor = true;
            buttoStarttheGame.Click += buttoStarttheGame_Click;
            // 
            // buttonViewPreviousHighScores
            // 
            buttonViewPreviousHighScores.Location = new Point(112, 470);
            buttonViewPreviousHighScores.Margin = new Padding(4, 5, 4, 5);
            buttonViewPreviousHighScores.Name = "buttonViewPreviousHighScores";
            buttonViewPreviousHighScores.Size = new Size(433, 125);
            buttonViewPreviousHighScores.TabIndex = 2;
            buttonViewPreviousHighScores.Text = "View Previous High Scores";
            buttonViewPreviousHighScores.UseVisualStyleBackColor = true;
            buttonViewPreviousHighScores.Click += buttonViewPreviousHighScores_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 205);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(281, 32);
            label2.TabIndex = 3;
            label2.Text = "Please Enter a Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(313, 192);
            textBoxUsername.Margin = new Padding(4, 5, 4, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(538, 39);
            textBoxUsername.TabIndex = 4;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(553, 335);
            buttonLogIn.Margin = new Padding(4, 5, 4, 5);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(433, 125);
            buttonLogIn.TabIndex = 5;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonCreateAnAccount
            // 
            buttonCreateAnAccount.Location = new Point(553, 470);
            buttonCreateAnAccount.Margin = new Padding(4, 5, 4, 5);
            buttonCreateAnAccount.Name = "buttonCreateAnAccount";
            buttonCreateAnAccount.Size = new Size(433, 125);
            buttonCreateAnAccount.TabIndex = 6;
            buttonCreateAnAccount.Text = "Create an Account";
            buttonCreateAnAccount.UseVisualStyleBackColor = true;
            buttonCreateAnAccount.Click += buttonCreateAnAccount_Click;
            // 
            // OpeningMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1143, 750);
            Controls.Add(buttonCreateAnAccount);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(buttonViewPreviousHighScores);
            Controls.Add(buttoStarttheGame);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OpeningMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpeningMenu";
            FormClosing += OpeningMenu_FormClosing;
            Load += OpeningMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttoStarttheGame;
        private Button buttonViewPreviousHighScores;
        private Label label2;
        private TextBox textBoxUsername;
        private Button buttonLogIn;
        private Button buttonCreateAnAccount;
    }
}