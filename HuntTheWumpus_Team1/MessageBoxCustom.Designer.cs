namespace HuntTheWumpus_Team1
{
    partial class MessageBoxCustom
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
            richTextBoxDispaly = new RichTextBox();
            buttonContinue = new Button();
            SuspendLayout();
            // 
            // richTextBoxDispaly
            // 
            richTextBoxDispaly.Location = new Point(93, 40);
            richTextBoxDispaly.Name = "richTextBoxDispaly";
            richTextBoxDispaly.ReadOnly = true;
            richTextBoxDispaly.Size = new Size(612, 285);
            richTextBoxDispaly.TabIndex = 0;
            richTextBoxDispaly.Text = "";
            // 
            // buttonContinue
            // 
            buttonContinue.Location = new Point(234, 340);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(327, 122);
            buttonContinue.TabIndex = 1;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // MessageBoxCustom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(862, 487);
            Controls.Add(buttonContinue);
            Controls.Add(richTextBoxDispaly);
            Name = "MessageBoxCustom";
            Text = "MessageBoxCustom";
            Load += MessageBoxCustom_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxDispaly;
        private Button buttonContinue;
    }
}