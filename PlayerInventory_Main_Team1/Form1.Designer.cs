namespace PlayerInventory_Main_Team1
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
            checkBoxSelfWanted = new CheckBox();
            label1 = new Label();
            checkBoxWumpusDefeated = new CheckBox();
            label2 = new Label();
            label5 = new Label();
            label7 = new Label();
            textBoxGoldCount = new TextBox();
            textBoxTurns = new TextBox();
            textBoxArrows = new TextBox();
            textBoxHighScore = new TextBox();
            buttonMoveForward = new Button();
            buttonPitEncounter = new Button();
            buttonWumpusEncounter = new Button();
            buttonBuyArrows = new Button();
            buttonShootArrows = new Button();
            buttonCalculateHighScore = new Button();
            buttonConstructor = new Button();
            SuspendLayout();
            // 
            // checkBoxSelfWanted
            // 
            checkBoxSelfWanted.AutoSize = true;
            checkBoxSelfWanted.Location = new Point(41, 12);
            checkBoxSelfWanted.Name = "checkBoxSelfWanted";
            checkBoxSelfWanted.Size = new Size(89, 19);
            checkBoxSelfWanted.TabIndex = 1;
            checkBoxSelfWanted.Text = "Self Wanted";
            checkBoxSelfWanted.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 69);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "Gold Count";
            // 
            // checkBoxWumpusDefeated
            // 
            checkBoxWumpusDefeated.AutoSize = true;
            checkBoxWumpusDefeated.Location = new Point(41, 37);
            checkBoxWumpusDefeated.Name = "checkBoxWumpusDefeated";
            checkBoxWumpusDefeated.Size = new Size(124, 19);
            checkBoxWumpusDefeated.TabIndex = 3;
            checkBoxWumpusDefeated.Text = "Wumpus Defeated";
            checkBoxWumpusDefeated.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 103);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Turns";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 138);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 7;
            label5.Text = "Arrows";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 173);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 9;
            label7.Text = "High Score";
            // 
            // textBoxGoldCount
            // 
            textBoxGoldCount.Location = new Point(199, 61);
            textBoxGoldCount.Name = "textBoxGoldCount";
            textBoxGoldCount.ReadOnly = true;
            textBoxGoldCount.Size = new Size(100, 23);
            textBoxGoldCount.TabIndex = 10;
            // 
            // textBoxTurns
            // 
            textBoxTurns.Location = new Point(199, 95);
            textBoxTurns.Name = "textBoxTurns";
            textBoxTurns.ReadOnly = true;
            textBoxTurns.Size = new Size(100, 23);
            textBoxTurns.TabIndex = 11;
            // 
            // textBoxArrows
            // 
            textBoxArrows.Location = new Point(199, 131);
            textBoxArrows.Name = "textBoxArrows";
            textBoxArrows.ReadOnly = true;
            textBoxArrows.Size = new Size(100, 23);
            textBoxArrows.TabIndex = 14;
            // 
            // textBoxHighScore
            // 
            textBoxHighScore.Location = new Point(199, 170);
            textBoxHighScore.Name = "textBoxHighScore";
            textBoxHighScore.ReadOnly = true;
            textBoxHighScore.Size = new Size(100, 23);
            textBoxHighScore.TabIndex = 16;
            // 
            // buttonMoveForward
            // 
            buttonMoveForward.Location = new Point(305, 60);
            buttonMoveForward.Name = "buttonMoveForward";
            buttonMoveForward.Size = new Size(209, 58);
            buttonMoveForward.TabIndex = 18;
            buttonMoveForward.Text = "Move Forward";
            buttonMoveForward.UseVisualStyleBackColor = true;
            buttonMoveForward.Click += buttonMoveForward_Click;
            // 
            // buttonPitEncounter
            // 
            buttonPitEncounter.Location = new Point(325, 130);
            buttonPitEncounter.Name = "buttonPitEncounter";
            buttonPitEncounter.Size = new Size(177, 23);
            buttonPitEncounter.TabIndex = 19;
            buttonPitEncounter.Text = "Pit Encounter";
            buttonPitEncounter.UseVisualStyleBackColor = true;
            buttonPitEncounter.Click += buttonPitEncounter_Click;
            // 
            // buttonWumpusEncounter
            // 
            buttonWumpusEncounter.Location = new Point(325, 165);
            buttonWumpusEncounter.Name = "buttonWumpusEncounter";
            buttonWumpusEncounter.Size = new Size(177, 23);
            buttonWumpusEncounter.TabIndex = 20;
            buttonWumpusEncounter.Text = "Wumpus Encounter";
            buttonWumpusEncounter.UseVisualStyleBackColor = true;
            buttonWumpusEncounter.Click += buttonWumpusEncounter_Click;
            // 
            // buttonBuyArrows
            // 
            buttonBuyArrows.Location = new Point(325, 195);
            buttonBuyArrows.Name = "buttonBuyArrows";
            buttonBuyArrows.Size = new Size(177, 23);
            buttonBuyArrows.TabIndex = 21;
            buttonBuyArrows.Text = "Buy Arrows";
            buttonBuyArrows.UseVisualStyleBackColor = true;
            buttonBuyArrows.Click += buttonBuyArrows_Click;
            // 
            // buttonShootArrows
            // 
            buttonShootArrows.Location = new Point(325, 233);
            buttonShootArrows.Name = "buttonShootArrows";
            buttonShootArrows.Size = new Size(177, 23);
            buttonShootArrows.TabIndex = 22;
            buttonShootArrows.Text = "Shoot Arrows";
            buttonShootArrows.UseVisualStyleBackColor = true;
            buttonShootArrows.Click += buttonShootArrows_Click;
            // 
            // buttonCalculateHighScore
            // 
            buttonCalculateHighScore.Location = new Point(325, 264);
            buttonCalculateHighScore.Name = "buttonCalculateHighScore";
            buttonCalculateHighScore.Size = new Size(177, 23);
            buttonCalculateHighScore.TabIndex = 23;
            buttonCalculateHighScore.Text = "Calculate High Score";
            buttonCalculateHighScore.UseVisualStyleBackColor = true;
            buttonCalculateHighScore.Click += buttonCalculateHighScore_Click;
            // 
            // buttonConstructor
            // 
            buttonConstructor.Location = new Point(557, 60);
            buttonConstructor.Name = "buttonConstructor";
            buttonConstructor.Size = new Size(148, 58);
            buttonConstructor.TabIndex = 24;
            buttonConstructor.Text = "Constructor Button";
            buttonConstructor.UseVisualStyleBackColor = true;
            buttonConstructor.Click += buttonConstructor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConstructor);
            Controls.Add(buttonCalculateHighScore);
            Controls.Add(buttonShootArrows);
            Controls.Add(buttonBuyArrows);
            Controls.Add(buttonWumpusEncounter);
            Controls.Add(buttonPitEncounter);
            Controls.Add(buttonMoveForward);
            Controls.Add(textBoxHighScore);
            Controls.Add(textBoxArrows);
            Controls.Add(textBoxTurns);
            Controls.Add(textBoxGoldCount);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(checkBoxWumpusDefeated);
            Controls.Add(label1);
            Controls.Add(checkBoxSelfWanted);
            Name = "Form1";
            Text = "Wumpus Player & HighScore";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBoxSelfWanted;
        private Label label1;
        private CheckBox checkBoxWumpusDefeated;
        private Label label2;
        private Label label5;
        private Label label7;
        private TextBox textBoxGoldCount;
        private TextBox textBoxTurns;
        private TextBox textBoxArrows;
        private TextBox textBoxHighScore;
        private Button buttonMoveForward;
        private Button buttonPitEncounter;
        private Button buttonWumpusEncounter;
        private Button buttonBuyArrows;
        private Button buttonShootArrows;
        private Button buttonCalculateHighScore;
        private Button buttonConstructor;
    }
}
