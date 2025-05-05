namespace CaveMain_Test
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
            button_Generate = new Button();
            label1 = new Label();
            textBox_WumpusRoom = new TextBox();
            textBox_Bat1Room = new TextBox();
            label2 = new Label();
            textBox_Bat2Room = new TextBox();
            label3 = new Label();
            textBox_PitRoom = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button_Generate
            // 
            button_Generate.Location = new Point(426, 94);
            button_Generate.Name = "button_Generate";
            button_Generate.Size = new Size(185, 63);
            button_Generate.TabIndex = 0;
            button_Generate.Text = "Generate Random Hazard Location";
            button_Generate.UseVisualStyleBackColor = true;
            button_Generate.Click += button_Generate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 92);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Wumpus Room:";
            // 
            // textBox_WumpusRoom
            // 
            textBox_WumpusRoom.Location = new Point(175, 90);
            textBox_WumpusRoom.Name = "textBox_WumpusRoom";
            textBox_WumpusRoom.Size = new Size(111, 23);
            textBox_WumpusRoom.TabIndex = 2;
            // 
            // textBox_Bat1Room
            // 
            textBox_Bat1Room.Location = new Point(175, 134);
            textBox_Bat1Room.Name = "textBox_Bat1Room";
            textBox_Bat1Room.Size = new Size(111, 23);
            textBox_Bat1Room.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 136);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Bat1 Room:";
            // 
            // textBox_Bat2Room
            // 
            textBox_Bat2Room.Location = new Point(175, 185);
            textBox_Bat2Room.Name = "textBox_Bat2Room";
            textBox_Bat2Room.Size = new Size(111, 23);
            textBox_Bat2Room.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 187);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Bat2 Room:";
            // 
            // textBox_PitRoom
            // 
            textBox_PitRoom.Location = new Point(175, 233);
            textBox_PitRoom.Name = "textBox_PitRoom";
            textBox_PitRoom.Size = new Size(111, 23);
            textBox_PitRoom.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 235);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Pit Room:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_PitRoom);
            Controls.Add(label4);
            Controls.Add(textBox_Bat2Room);
            Controls.Add(label3);
            Controls.Add(textBox_Bat1Room);
            Controls.Add(label2);
            Controls.Add(textBox_WumpusRoom);
            Controls.Add(label1);
            Controls.Add(button_Generate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Generate;
        private Label label1;
        private TextBox textBox_WumpusRoom;
        private TextBox textBox_Bat1Room;
        private Label label2;
        private TextBox textBox_Bat2Room;
        private Label label3;
        private TextBox textBox_PitRoom;
        private Label label4;
    }
}
