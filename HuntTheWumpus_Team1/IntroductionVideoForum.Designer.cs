namespace HuntTheWumpus_Team1
{
    partial class IntroductionVideoForum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroductionVideoForum));
            pictureBoxAustronaut = new PictureBox();
            pictureBoxJupiter = new PictureBox();
            pictureBoxStaturn = new PictureBox();
            labelTextToStory = new Label();
            pictureBoxGalaxy = new PictureBox();
            buttonContiueWithStory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAustronaut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStaturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGalaxy).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAustronaut
            // 
            pictureBoxAustronaut.Image = (Image)resources.GetObject("pictureBoxAustronaut.Image");
            pictureBoxAustronaut.Location = new Point(39, 433);
            pictureBoxAustronaut.Name = "pictureBoxAustronaut";
            pictureBoxAustronaut.Size = new Size(179, 184);
            pictureBoxAustronaut.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAustronaut.TabIndex = 0;
            pictureBoxAustronaut.TabStop = false;
            // 
            // pictureBoxJupiter
            // 
            pictureBoxJupiter.Image = (Image)resources.GetObject("pictureBoxJupiter.Image");
            pictureBoxJupiter.Location = new Point(39, 38);
            pictureBoxJupiter.Name = "pictureBoxJupiter";
            pictureBoxJupiter.Size = new Size(253, 199);
            pictureBoxJupiter.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxJupiter.TabIndex = 1;
            pictureBoxJupiter.TabStop = false;
            // 
            // pictureBoxStaturn
            // 
            pictureBoxStaturn.Image = (Image)resources.GetObject("pictureBoxStaturn.Image");
            pictureBoxStaturn.Location = new Point(722, 491);
            pictureBoxStaturn.Name = "pictureBoxStaturn";
            pictureBoxStaturn.Size = new Size(259, 194);
            pictureBoxStaturn.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxStaturn.TabIndex = 2;
            pictureBoxStaturn.TabStop = false;
            // 
            // labelTextToStory
            // 
            labelTextToStory.AutoSize = true;
            labelTextToStory.BackColor = Color.White;
            labelTextToStory.Location = new Point(39, 637);
            labelTextToStory.Name = "labelTextToStory";
            labelTextToStory.Size = new Size(225, 25);
            labelTextToStory.TabIndex = 3;
            labelTextToStory.Text = "While Working in Space .... ";
            // 
            // pictureBoxGalaxy
            // 
            pictureBoxGalaxy.Image = (Image)resources.GetObject("pictureBoxGalaxy.Image");
            pictureBoxGalaxy.Location = new Point(832, 25);
            pictureBoxGalaxy.Name = "pictureBoxGalaxy";
            pictureBoxGalaxy.Size = new Size(225, 225);
            pictureBoxGalaxy.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxGalaxy.TabIndex = 4;
            pictureBoxGalaxy.TabStop = false;
            // 
            // buttonContiueWithStory
            // 
            buttonContiueWithStory.Location = new Point(39, 669);
            buttonContiueWithStory.Name = "buttonContiueWithStory";
            buttonContiueWithStory.Size = new Size(162, 69);
            buttonContiueWithStory.TabIndex = 5;
            buttonContiueWithStory.Text = "Continue with Story";
            buttonContiueWithStory.UseVisualStyleBackColor = true;
            buttonContiueWithStory.Click += buttonContiueWithStory_Click;
            // 
            // IntroductionVideoForum
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1143, 750);
            Controls.Add(buttonContiueWithStory);
            Controls.Add(pictureBoxGalaxy);
            Controls.Add(labelTextToStory);
            Controls.Add(pictureBoxStaturn);
            Controls.Add(pictureBoxJupiter);
            Controls.Add(pictureBoxAustronaut);
            Name = "IntroductionVideoForum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IntroductionVideoForum";
            FormClosing += IntroductionVideoForum_FormClosing;
            Load += IntroductionVideoForum_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAustronaut).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJupiter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStaturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGalaxy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAustronaut;
        private PictureBox pictureBoxJupiter;
        private PictureBox pictureBoxStaturn;
        private Label labelTextToStory;
        private PictureBox pictureBoxGalaxy;
        private Button buttonContiueWithStory;
    }
}