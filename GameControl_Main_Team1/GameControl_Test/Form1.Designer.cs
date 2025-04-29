namespace GameControl_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonConstructor = new Button();
            SuspendLayout();
            // 
            // buttonConstructor
            // 
            buttonConstructor.Location = new Point(22, 28);
            buttonConstructor.Name = "buttonConstructor";
            buttonConstructor.Size = new Size(125, 38);
            buttonConstructor.TabIndex = 0;
            buttonConstructor.Text = "Constructor";
            buttonConstructor.UseVisualStyleBackColor = true;
            buttonConstructor.Click += buttonConstructor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConstructor);
            Name = "Form1";
            Text = "Game Control";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConstructor;
    }
}
