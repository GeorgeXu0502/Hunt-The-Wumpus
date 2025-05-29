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
            pictureBoxGeneralRoomBackground = new PictureBox();
            buttonNextRoom5 = new Button();
            checkBoxwumpusneabry = new CheckBox();
            checkBoxpitnearby = new CheckBox();
            checkBoxbatsnearby = new CheckBox();
            buttonNextRoom2 = new Button();
            buttonNextRoom1 = new Button();
            buttonNextRoom6 = new Button();
            buttonNextRoom3 = new Button();
            buttonNextRoom4 = new Button();
            groupBoxplayeractions = new GroupBox();
            buttonEndGameNow = new Button();
            buttonPurchaseSecret = new Button();
            buttonPurchaseArrow = new Button();
            buttonShootanArrow = new Button();
            buttonMovetoNextRoom = new Button();
            groupBoxPlayerInventory = new GroupBox();
            textBoxAmountofTurns = new TextBox();
            label1 = new Label();
            textBoxArrowAmount = new TextBox();
            textBoxGoldCoinAmount = new TextBox();
            label3 = new Label();
            label2 = new Label();
            listBoxTriviaQuestion = new ListBox();
            groupBoxRoomWarnings = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGeneralRoomBackground).BeginInit();
            groupBoxplayeractions.SuspendLayout();
            groupBoxPlayerInventory.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxGeneralRoomBackground
            // 
            pictureBoxGeneralRoomBackground.Image = Properties.Resources.HuntheWumpusRoom1;
            pictureBoxGeneralRoomBackground.Location = new Point(96, 170);
            pictureBoxGeneralRoomBackground.Name = "pictureBoxGeneralRoomBackground";
            pictureBoxGeneralRoomBackground.Size = new Size(1156, 1003);
            pictureBoxGeneralRoomBackground.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGeneralRoomBackground.TabIndex = 0;
            pictureBoxGeneralRoomBackground.TabStop = false;
            // 
            // buttonNextRoom5
            // 
            buttonNextRoom5.BackColor = SystemColors.ActiveCaption;
            buttonNextRoom5.Location = new Point(966, 590);
            buttonNextRoom5.Name = "buttonNextRoom5";
            buttonNextRoom5.Size = new Size(286, 138);
            buttonNextRoom5.TabIndex = 5;
            buttonNextRoom5.Text = "button1";
            buttonNextRoom5.UseVisualStyleBackColor = false;
            buttonNextRoom5.Click += buttonNextRoom5_Click;
            // 
            // checkBoxwumpusneabry
            // 
            checkBoxwumpusneabry.AutoSize = true;
            checkBoxwumpusneabry.Location = new Point(50, 28);
            checkBoxwumpusneabry.Margin = new Padding(4, 5, 4, 5);
            checkBoxwumpusneabry.Name = "checkBoxwumpusneabry";
            checkBoxwumpusneabry.Size = new Size(283, 29);
            checkBoxwumpusneabry.TabIndex = 8;
            checkBoxwumpusneabry.Text = "Device senses Wumpus nearby";
            checkBoxwumpusneabry.UseVisualStyleBackColor = true;
            checkBoxwumpusneabry.CheckedChanged += checkBoxwumpusneabry_CheckedChanged;
            // 
            // checkBoxpitnearby
            // 
            checkBoxpitnearby.AutoSize = true;
            checkBoxpitnearby.Location = new Point(50, 72);
            checkBoxpitnearby.Margin = new Padding(4, 5, 4, 5);
            checkBoxpitnearby.Name = "checkBoxpitnearby";
            checkBoxpitnearby.Size = new Size(231, 29);
            checkBoxpitnearby.TabIndex = 9;
            checkBoxpitnearby.Text = "Device senses Pit nearby";
            checkBoxpitnearby.UseVisualStyleBackColor = true;
            checkBoxpitnearby.CheckedChanged += checkBoxpitnearby_CheckedChanged;
            // 
            // checkBoxbatsnearby
            // 
            checkBoxbatsnearby.AutoSize = true;
            checkBoxbatsnearby.Location = new Point(50, 113);
            checkBoxbatsnearby.Margin = new Padding(4, 5, 4, 5);
            checkBoxbatsnearby.Name = "checkBoxbatsnearby";
            checkBoxbatsnearby.Size = new Size(244, 29);
            checkBoxbatsnearby.TabIndex = 10;
            checkBoxbatsnearby.Text = "Device senses Bats nearby";
            checkBoxbatsnearby.UseVisualStyleBackColor = true;
            checkBoxbatsnearby.CheckedChanged += checkBoxbatsnearby_CheckedChanged;
            // 
            // buttonNextRoom2
            // 
            buttonNextRoom2.BackColor = SystemColors.ActiveCaption;
            buttonNextRoom2.Location = new Point(96, 590);
            buttonNextRoom2.Name = "buttonNextRoom2";
            buttonNextRoom2.Size = new Size(286, 138);
            buttonNextRoom2.TabIndex = 11;
            buttonNextRoom2.Text = "button1";
            buttonNextRoom2.UseVisualStyleBackColor = false;
            buttonNextRoom2.Click += buttonNextRoom2_Click;
            // 
            // buttonNextRoom1
            // 
            buttonNextRoom1.BackColor = SystemColors.ActiveCaption;
            buttonNextRoom1.Location = new Point(189, 265);
            buttonNextRoom1.Name = "buttonNextRoom1";
            buttonNextRoom1.Size = new Size(286, 138);
            buttonNextRoom1.TabIndex = 12;
            buttonNextRoom1.Text = "button1";
            buttonNextRoom1.UseVisualStyleBackColor = false;
            buttonNextRoom1.Click += buttonNextRoom1_Click;
            // 
            // buttonNextRoom6
            // 
            buttonNextRoom6.BackColor = SystemColors.ActiveCaption;
            buttonNextRoom6.Location = new Point(884, 265);
            buttonNextRoom6.Name = "buttonNextRoom6";
            buttonNextRoom6.Size = new Size(286, 138);
            buttonNextRoom6.TabIndex = 13;
            buttonNextRoom6.Text = "button1";
            buttonNextRoom6.UseVisualStyleBackColor = false;
            buttonNextRoom6.Click += buttonNextRoom6_Click;
            // 
            // buttonNextRoom3
            // 
            buttonNextRoom3.BackColor = SystemColors.ActiveCaption;
            buttonNextRoom3.Location = new Point(189, 933);
            buttonNextRoom3.Name = "buttonNextRoom3";
            buttonNextRoom3.Size = new Size(286, 138);
            buttonNextRoom3.TabIndex = 14;
            buttonNextRoom3.Text = "button1";
            buttonNextRoom3.UseVisualStyleBackColor = false;
            buttonNextRoom3.Click += buttonNextRoom3_Click;
            // 
            // buttonNextRoom4
            // 
            buttonNextRoom4.BackColor = SystemColors.ActiveCaption;
            buttonNextRoom4.Location = new Point(884, 933);
            buttonNextRoom4.Name = "buttonNextRoom4";
            buttonNextRoom4.Size = new Size(286, 138);
            buttonNextRoom4.TabIndex = 15;
            buttonNextRoom4.Text = "button1";
            buttonNextRoom4.UseVisualStyleBackColor = false;
            buttonNextRoom4.Click += buttonNextRoom4_Click;
            // 
            // groupBoxplayeractions
            // 
            groupBoxplayeractions.Controls.Add(buttonEndGameNow);
            groupBoxplayeractions.Controls.Add(buttonPurchaseSecret);
            groupBoxplayeractions.Controls.Add(buttonPurchaseArrow);
            groupBoxplayeractions.Controls.Add(buttonShootanArrow);
            groupBoxplayeractions.Controls.Add(buttonMovetoNextRoom);
            groupBoxplayeractions.Location = new Point(1261, 23);
            groupBoxplayeractions.Margin = new Padding(4, 5, 4, 5);
            groupBoxplayeractions.Name = "groupBoxplayeractions";
            groupBoxplayeractions.Padding = new Padding(4, 5, 4, 5);
            groupBoxplayeractions.Size = new Size(363, 800);
            groupBoxplayeractions.TabIndex = 16;
            groupBoxplayeractions.TabStop = false;
            groupBoxplayeractions.Text = "Possible Actions";
            // 
            // buttonEndGameNow
            // 
            buttonEndGameNow.BackColor = SystemColors.ActiveCaption;
            buttonEndGameNow.Location = new Point(7, 650);
            buttonEndGameNow.Name = "buttonEndGameNow";
            buttonEndGameNow.Size = new Size(349, 138);
            buttonEndGameNow.TabIndex = 22;
            buttonEndGameNow.Text = "End Game Now";
            buttonEndGameNow.UseVisualStyleBackColor = false;
            buttonEndGameNow.Click += buttonEndGameNow_Click;
            // 
            // buttonPurchaseSecret
            // 
            buttonPurchaseSecret.BackColor = SystemColors.ActiveCaption;
            buttonPurchaseSecret.Location = new Point(7, 505);
            buttonPurchaseSecret.Name = "buttonPurchaseSecret";
            buttonPurchaseSecret.Size = new Size(349, 138);
            buttonPurchaseSecret.TabIndex = 21;
            buttonPurchaseSecret.Text = "Purchase Secret";
            buttonPurchaseSecret.UseVisualStyleBackColor = false;
            buttonPurchaseSecret.Click += buttonPurchaseSecret_Click;
            // 
            // buttonPurchaseArrow
            // 
            buttonPurchaseArrow.BackColor = SystemColors.ActiveCaption;
            buttonPurchaseArrow.Location = new Point(7, 360);
            buttonPurchaseArrow.Name = "buttonPurchaseArrow";
            buttonPurchaseArrow.Size = new Size(349, 138);
            buttonPurchaseArrow.TabIndex = 20;
            buttonPurchaseArrow.Text = "Purchase Arrow";
            buttonPurchaseArrow.UseVisualStyleBackColor = false;
            buttonPurchaseArrow.Click += buttonPurchaseArrow_Click;
            // 
            // buttonShootanArrow
            // 
            buttonShootanArrow.BackColor = SystemColors.ActiveCaption;
            buttonShootanArrow.Location = new Point(7, 215);
            buttonShootanArrow.Name = "buttonShootanArrow";
            buttonShootanArrow.Size = new Size(349, 138);
            buttonShootanArrow.TabIndex = 19;
            buttonShootanArrow.Text = "Shoot an Arrow";
            buttonShootanArrow.UseVisualStyleBackColor = false;
            buttonShootanArrow.Click += buttonShootanArrow_Click;
            // 
            // buttonMovetoNextRoom
            // 
            buttonMovetoNextRoom.AutoSize = true;
            buttonMovetoNextRoom.BackColor = SystemColors.ActiveCaption;
            buttonMovetoNextRoom.Location = new Point(7, 70);
            buttonMovetoNextRoom.Name = "buttonMovetoNextRoom";
            buttonMovetoNextRoom.Size = new Size(349, 138);
            buttonMovetoNextRoom.TabIndex = 18;
            buttonMovetoNextRoom.Text = "Move to Next Room";
            buttonMovetoNextRoom.UseVisualStyleBackColor = false;
            buttonMovetoNextRoom.Click += buttonMovetoNextRoom_Click;
            // 
            // groupBoxPlayerInventory
            // 
            groupBoxPlayerInventory.Controls.Add(textBoxAmountofTurns);
            groupBoxPlayerInventory.Controls.Add(label1);
            groupBoxPlayerInventory.Controls.Add(textBoxArrowAmount);
            groupBoxPlayerInventory.Controls.Add(textBoxGoldCoinAmount);
            groupBoxPlayerInventory.Controls.Add(label3);
            groupBoxPlayerInventory.Controls.Add(label2);
            groupBoxPlayerInventory.Location = new Point(401, 3);
            groupBoxPlayerInventory.Margin = new Padding(4, 5, 4, 5);
            groupBoxPlayerInventory.Name = "groupBoxPlayerInventory";
            groupBoxPlayerInventory.Padding = new Padding(4, 5, 4, 5);
            groupBoxPlayerInventory.Size = new Size(363, 167);
            groupBoxPlayerInventory.TabIndex = 17;
            groupBoxPlayerInventory.TabStop = false;
            groupBoxPlayerInventory.Text = "Player Inventory";
            // 
            // textBoxAmountofTurns
            // 
            textBoxAmountofTurns.Location = new Point(237, 128);
            textBoxAmountofTurns.Margin = new Padding(4, 5, 4, 5);
            textBoxAmountofTurns.Name = "textBoxAmountofTurns";
            textBoxAmountofTurns.ReadOnly = true;
            textBoxAmountofTurns.Size = new Size(115, 31);
            textBoxAmountofTurns.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 128);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 4;
            label1.Text = "Amount of Turns:";
            // 
            // textBoxArrowAmount
            // 
            textBoxArrowAmount.Location = new Point(237, 80);
            textBoxArrowAmount.Margin = new Padding(4, 5, 4, 5);
            textBoxArrowAmount.Name = "textBoxArrowAmount";
            textBoxArrowAmount.ReadOnly = true;
            textBoxArrowAmount.Size = new Size(115, 31);
            textBoxArrowAmount.TabIndex = 3;
            // 
            // textBoxGoldCoinAmount
            // 
            textBoxGoldCoinAmount.Location = new Point(237, 32);
            textBoxGoldCoinAmount.Margin = new Padding(4, 5, 4, 5);
            textBoxGoldCoinAmount.Name = "textBoxGoldCoinAmount";
            textBoxGoldCoinAmount.ReadOnly = true;
            textBoxGoldCoinAmount.Size = new Size(115, 31);
            textBoxGoldCoinAmount.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 93);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 1;
            label3.Text = "Amount of Arrows:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 0;
            label2.Text = "Amount of Gold Coins:";
            // 
            // listBoxTriviaQuestion
            // 
            listBoxTriviaQuestion.FormattingEnabled = true;
            listBoxTriviaQuestion.ItemHeight = 25;
            listBoxTriviaQuestion.Location = new Point(1261, 832);
            listBoxTriviaQuestion.Name = "listBoxTriviaQuestion";
            listBoxTriviaQuestion.Size = new Size(505, 304);
            listBoxTriviaQuestion.TabIndex = 18;
            listBoxTriviaQuestion.SelectedIndexChanged += listBoxTriviaQuestion_SelectedIndexChanged;
            // 
            // groupBoxRoomWarnings
            // 
            groupBoxRoomWarnings.Location = new Point(7, 3);
            groupBoxRoomWarnings.Name = "groupBoxRoomWarnings";
            groupBoxRoomWarnings.Size = new Size(353, 167);
            groupBoxRoomWarnings.TabIndex = 19;
            groupBoxRoomWarnings.TabStop = false;
            groupBoxRoomWarnings.Text = "Room Warnings";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(98, 127, 149);
            ClientSize = new Size(1814, 1062);
            Controls.Add(listBoxTriviaQuestion);
            Controls.Add(groupBoxPlayerInventory);
            Controls.Add(groupBoxplayeractions);
            Controls.Add(buttonNextRoom4);
            Controls.Add(buttonNextRoom3);
            Controls.Add(buttonNextRoom6);
            Controls.Add(buttonNextRoom1);
            Controls.Add(buttonNextRoom2);
            Controls.Add(checkBoxbatsnearby);
            Controls.Add(checkBoxpitnearby);
            Controls.Add(checkBoxwumpusneabry);
            Controls.Add(buttonNextRoom5);
            Controls.Add(pictureBoxGeneralRoomBackground);
            Controls.Add(groupBoxRoomWarnings);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UI: Hunt the Wumpus";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGeneralRoomBackground).EndInit();
            groupBoxplayeractions.ResumeLayout(false);
            groupBoxplayeractions.PerformLayout();
            groupBoxPlayerInventory.ResumeLayout(false);
            groupBoxPlayerInventory.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxGeneralRoomBackground;
        private Button buttonNextRoom5;
        private CheckBox checkBoxwumpusneabry;
        private CheckBox checkBoxpitnearby;
        private CheckBox checkBoxbatsnearby;
        private Button buttonNextRoom2;
        private Button buttonNextRoom1;
        private Button buttonNextRoom6;
        private Button buttonNextRoom3;
        private Button buttonNextRoom4;
        private GroupBox groupBoxplayeractions;
        private GroupBox groupBoxPlayerInventory;
        private TextBox textBoxArrowAmount;
        private TextBox textBoxGoldCoinAmount;
        private Label label3;
        private Label label2;
        private Button buttonPurchaseSecret;
        private Button buttonPurchaseArrow;
        private Button buttonShootanArrow;
        private Button buttonMovetoNextRoom;
        private Button buttonEndGameNow;
        private ListBox listBoxTriviaQuestion;
        private GroupBox groupBoxRoomWarnings;
        private TextBox textBoxAmountofTurns;
        private Label label1;
    }
}
