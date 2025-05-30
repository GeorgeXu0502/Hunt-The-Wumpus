namespace HuntTheWumpus_Team1
{
    partial class RegainUssernamePassword
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
            textBoxEmailEntered = new TextBox();
            buttonRegainEmail = new Button();
            textBoxUsername = new TextBox();
            label2 = new Label();
            textBoxPassword = new TextBox();
            label3 = new Label();
            buttonReturnToHomeScreen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(93, 116);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 0;
            label1.Text = "Email: ";
            // 
            // textBoxEmailEntered
            // 
            textBoxEmailEntered.Font = new Font("Segoe UI", 12F);
            textBoxEmailEntered.Location = new Point(247, 109);
            textBoxEmailEntered.Name = "textBoxEmailEntered";
            textBoxEmailEntered.Size = new Size(421, 39);
            textBoxEmailEntered.TabIndex = 1;
            // 
            // buttonRegainEmail
            // 
            buttonRegainEmail.Font = new Font("Segoe UI", 12F);
            buttonRegainEmail.Location = new Point(93, 474);
            buttonRegainEmail.Name = "buttonRegainEmail";
            buttonRegainEmail.Size = new Size(306, 102);
            buttonRegainEmail.TabIndex = 2;
            buttonRegainEmail.Text = "Regain Username and Password";
            buttonRegainEmail.UseVisualStyleBackColor = true;
            buttonRegainEmail.Click += buttonRegainEmail_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(247, 264);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.ReadOnly = true;
            textBoxUsername.Size = new Size(421, 39);
            textBoxUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(93, 271);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 3;
            label2.Text = "Username: ";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(247, 329);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.ReadOnly = true;
            textBoxPassword.Size = new Size(421, 39);
            textBoxPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(93, 336);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // buttonReturnToHomeScreen
            // 
            buttonReturnToHomeScreen.Font = new Font("Segoe UI", 12F);
            buttonReturnToHomeScreen.Location = new Point(422, 474);
            buttonReturnToHomeScreen.Name = "buttonReturnToHomeScreen";
            buttonReturnToHomeScreen.Size = new Size(306, 102);
            buttonReturnToHomeScreen.TabIndex = 7;
            buttonReturnToHomeScreen.Text = "Return to HomeScreen";
            buttonReturnToHomeScreen.UseVisualStyleBackColor = true;
            buttonReturnToHomeScreen.Click += buttonReturnToHomeScreen_Click;
            // 
            // RegainUssernamePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1143, 750);
            Controls.Add(buttonReturnToHomeScreen);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(buttonRegainEmail);
            Controls.Add(textBoxEmailEntered);
            Controls.Add(label1);
            Name = "RegainUssernamePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegainUssernamePassword";
            FormClosing += RegainUssernamePassword_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxEmailEntered;
        private Button buttonRegainEmail;
        private TextBox textBoxUsername;
        private Label label2;
        private TextBox textBoxPassword;
        private Label label3;
        private Button buttonReturnToHomeScreen;
    }
}