namespace E_PetGame_Dogon_LukySalmanGlenn
{
    partial class FormGameChameleon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameChameleon));
            this.pictureBoxTop1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBottom1 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxGameOver = new System.Windows.Forms.PictureBox();
            this.pictureBoxChameleon = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChameleon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTop1
            // 
            this.pictureBoxTop1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTop1.BackgroundImage")));
            this.pictureBoxTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTop1.Location = new System.Drawing.Point(223, -22);
            this.pictureBoxTop1.Name = "pictureBoxTop1";
            this.pictureBoxTop1.Size = new System.Drawing.Size(188, 149);
            this.pictureBoxTop1.TabIndex = 34;
            this.pictureBoxTop1.TabStop = false;
            // 
            // pictureBoxBottom1
            // 
            this.pictureBoxBottom1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBottom1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBottom1.BackgroundImage")));
            this.pictureBoxBottom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBottom1.Location = new System.Drawing.Point(553, 300);
            this.pictureBoxBottom1.Name = "pictureBoxBottom1";
            this.pictureBoxBottom1.Size = new System.Drawing.Size(208, 229);
            this.pictureBoxBottom1.TabIndex = 37;
            this.pictureBoxBottom1.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Bisque;
            this.buttonBack.Location = new System.Drawing.Point(331, 349);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(180, 80);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxGameOver
            // 
            this.pictureBoxGameOver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGameOver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGameOver.Image")));
            this.pictureBoxGameOver.Location = new System.Drawing.Point(97, 4);
            this.pictureBoxGameOver.Name = "pictureBoxGameOver";
            this.pictureBoxGameOver.Size = new System.Drawing.Size(631, 425);
            this.pictureBoxGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGameOver.TabIndex = 38;
            this.pictureBoxGameOver.TabStop = false;
            // 
            // pictureBoxChameleon
            // 
            this.pictureBoxChameleon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChameleon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxChameleon.BackgroundImage")));
            this.pictureBoxChameleon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxChameleon.Location = new System.Drawing.Point(45, 206);
            this.pictureBoxChameleon.Name = "pictureBoxChameleon";
            this.pictureBoxChameleon.Size = new System.Drawing.Size(108, 84);
            this.pictureBoxChameleon.TabIndex = 33;
            this.pictureBoxChameleon.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(10, 472);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(118, 39);
            this.labelScore.TabIndex = 35;
            this.labelScore.Text = "Score : ";
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGround.Location = new System.Drawing.Point(-3, 424);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(805, 144);
            this.pictureBoxGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGround.TabIndex = 36;
            this.pictureBoxGround.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // FormGameChameleon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 541);
            this.Controls.Add(this.pictureBoxTop1);
            this.Controls.Add(this.pictureBoxBottom1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxGameOver);
            this.Controls.Add(this.pictureBoxChameleon);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxGround);
            this.DoubleBuffered = true;
            this.Name = "FormGameChameleon";
            this.Text = "FormGameChameleon";
            this.Load += new System.EventHandler(this.FormGameChameleon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGameChameleon_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGameChameleon_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChameleon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTop1;
        private System.Windows.Forms.PictureBox pictureBoxBottom1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxGameOver;
        private System.Windows.Forms.PictureBox pictureBoxChameleon;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxGround;
        private System.Windows.Forms.Timer timerGame;
    }
}