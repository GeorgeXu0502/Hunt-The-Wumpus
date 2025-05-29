namespace HuntTheWumpus_Team1
{
    partial class LoginScreen
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
            buttonLogIn = new Button();
            buttonForgotUserInformation = new Button();
            buttonReturntoHomeScreen = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(82, 92);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(239, 86);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(583, 39);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(239, 179);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(583, 39);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.KeyUp += textBoxPassword_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(82, 185);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Font = new Font("Segoe UI", 12F);
            buttonLogIn.Location = new Point(91, 473);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(384, 120);
            buttonLogIn.TabIndex = 4;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonForgotUserInformation
            // 
            buttonForgotUserInformation.Font = new Font("Segoe UI", 12F);
            buttonForgotUserInformation.Location = new Point(494, 473);
            buttonForgotUserInformation.Name = "buttonForgotUserInformation";
            buttonForgotUserInformation.Size = new Size(384, 120);
            buttonForgotUserInformation.TabIndex = 5;
            buttonForgotUserInformation.Text = "Forgot Username or Password";
            buttonForgotUserInformation.UseVisualStyleBackColor = true;
            // 
            // buttonReturntoHomeScreen
            // 
            buttonReturntoHomeScreen.Font = new Font("Segoe UI", 12F);
            buttonReturntoHomeScreen.Location = new Point(315, 608);
            buttonReturntoHomeScreen.Name = "buttonReturntoHomeScreen";
            buttonReturntoHomeScreen.Size = new Size(384, 120);
            buttonReturntoHomeScreen.TabIndex = 6;
            buttonReturntoHomeScreen.Text = "Return to Home Screen";
            buttonReturntoHomeScreen.UseVisualStyleBackColor = true;
            buttonReturntoHomeScreen.Click += buttonReturntoHomeScreen_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(92, 277);
            label3.Name = "label3";
            label3.Size = new Size(432, 32);
            label3.TabIndex = 7;
            label3.Text = "Please Type Slowly! One Key at a Time!";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1143, 750);
            Controls.Add(label3);
            Controls.Add(buttonReturntoHomeScreen);
            Controls.Add(buttonForgotUserInformation);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label2;
        private Button buttonLogIn;
        private Button buttonForgotUserInformation;
        private Button buttonReturntoHomeScreen;
        private Label label3;
    }
}