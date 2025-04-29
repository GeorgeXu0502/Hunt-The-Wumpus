namespace HuntTheWumpus_Team1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxGeneralRoomBackground = new PictureBox();
            buttonRoom1 = new Button();
            buttonRoom2 = new Button();
            buttonRoom3 = new Button();
            buttonRoom4 = new Button();
            buttonRoom5 = new Button();
            buttonRoom6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGeneralRoomBackground).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGeneralRoomBackground
            // 
            pictureBoxGeneralRoomBackground.Image = (Image)resources.GetObject("pictureBoxGeneralRoomBackground.Image");
            pictureBoxGeneralRoomBackground.Location = new Point(71, 61);
            pictureBoxGeneralRoomBackground.Name = "pictureBoxGeneralRoomBackground";
            pictureBoxGeneralRoomBackground.Size = new Size(1520, 1342);
            pictureBoxGeneralRoomBackground.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGeneralRoomBackground.TabIndex = 0;
            pictureBoxGeneralRoomBackground.TabStop = false;
            // 
            // buttonRoom1
            // 
            buttonRoom1.BackColor = SystemColors.ActiveCaption;
            buttonRoom1.Location = new Point(258, 221);
            buttonRoom1.Name = "buttonRoom1";
            buttonRoom1.Size = new Size(324, 138);
            buttonRoom1.TabIndex = 1;
            buttonRoom1.Text = "button1";
            buttonRoom1.UseVisualStyleBackColor = false;
            // 
            // buttonRoom2
            // 
            buttonRoom2.BackColor = SystemColors.ActiveCaption;
            buttonRoom2.Location = new Point(50, 651);
            buttonRoom2.Name = "buttonRoom2";
            buttonRoom2.Size = new Size(324, 138);
            buttonRoom2.TabIndex = 2;
            buttonRoom2.Text = "button1";
            buttonRoom2.UseVisualStyleBackColor = false;
            // 
            // buttonRoom3
            // 
            buttonRoom3.BackColor = SystemColors.ActiveCaption;
            buttonRoom3.Location = new Point(245, 1100);
            buttonRoom3.Name = "buttonRoom3";
            buttonRoom3.Size = new Size(324, 138);
            buttonRoom3.TabIndex = 3;
            buttonRoom3.Text = "button1";
            buttonRoom3.UseVisualStyleBackColor = false;
            // 
            // buttonRoom4
            // 
            buttonRoom4.BackColor = SystemColors.ActiveCaption;
            buttonRoom4.Location = new Point(1073, 1110);
            buttonRoom4.Name = "buttonRoom4";
            buttonRoom4.Size = new Size(324, 138);
            buttonRoom4.TabIndex = 4;
            buttonRoom4.Text = "button1";
            buttonRoom4.UseVisualStyleBackColor = false;
            // 
            // buttonRoom5
            // 
            buttonRoom5.BackColor = SystemColors.ActiveCaption;
            buttonRoom5.Location = new Point(1294, 677);
            buttonRoom5.Name = "buttonRoom5";
            buttonRoom5.Size = new Size(324, 138);
            buttonRoom5.TabIndex = 5;
            buttonRoom5.Text = "button1";
            buttonRoom5.UseVisualStyleBackColor = false;
            // 
            // buttonRoom6
            // 
            buttonRoom6.BackColor = SystemColors.ActiveCaption;
            buttonRoom6.Location = new Point(1117, 221);
            buttonRoom6.Name = "buttonRoom6";
            buttonRoom6.Size = new Size(324, 138);
            buttonRoom6.TabIndex = 6;
            buttonRoom6.Text = "button1";
            buttonRoom6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1816, 1475);
            Controls.Add(buttonRoom6);
            Controls.Add(buttonRoom5);
            Controls.Add(buttonRoom4);
            Controls.Add(buttonRoom3);
            Controls.Add(buttonRoom2);
            Controls.Add(buttonRoom1);
            Controls.Add(pictureBoxGeneralRoomBackground);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "UI: Hunt the Wumpus";
            Activated += Form1_Activated;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGeneralRoomBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxGeneralRoomBackground;
        private Button buttonRoom1;
        private Button buttonRoom2;
        private Button buttonRoom3;
        private Button buttonRoom4;
        private Button buttonRoom5;
        private Button buttonRoom6;
    }
}
