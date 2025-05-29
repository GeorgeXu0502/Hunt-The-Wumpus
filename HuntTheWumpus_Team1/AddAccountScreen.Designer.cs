namespace HuntTheWumpus_Team1
{
    partial class AddAccountScreen
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
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            buttonAddAccount = new Button();
            buttonReturnToHomeScreen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(71, 126);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(231, 119);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(476, 39);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(231, 198);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(476, 39);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.KeyUp += textBoxPassword_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(71, 205);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(71, 426);
            label3.Name = "label3";
            label3.Size = new Size(485, 32);
            label3.TabIndex = 4;
            label3.Text = "Please type slowly! One Character at a Time.";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(231, 283);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(476, 39);
            textBoxEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(71, 290);
            label4.Name = "label4";
            label4.Size = new Size(76, 32);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Location = new Point(71, 536);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(337, 106);
            buttonAddAccount.TabIndex = 7;
            buttonAddAccount.Text = "Add Account";
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += buttonAddAccount_Click;
            // 
            // buttonReturnToHomeScreen
            // 
            buttonReturnToHomeScreen.Location = new Point(436, 536);
            buttonReturnToHomeScreen.Name = "buttonReturnToHomeScreen";
            buttonReturnToHomeScreen.Size = new Size(337, 106);
            buttonReturnToHomeScreen.TabIndex = 8;
            buttonReturnToHomeScreen.Text = "Return to Home Screen";
            buttonReturnToHomeScreen.UseVisualStyleBackColor = true;
            buttonReturnToHomeScreen.Click += buttonReturnToHomeScreen_Click;
            // 
            // AddAccountScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1143, 750);
            Controls.Add(buttonReturnToHomeScreen);
            Controls.Add(buttonAddAccount);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Name = "AddAccountScreen";
            Text = "AddAccountScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private Button buttonAddAccount;
        private Button buttonReturnToHomeScreen;
    }
}