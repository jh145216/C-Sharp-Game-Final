namespace Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClickToPlay = new System.Windows.Forms.Button();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGameInfo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(411, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(114, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to our game!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnClickToPlay
            // 
            this.btnClickToPlay.Location = new System.Drawing.Point(414, 403);
            this.btnClickToPlay.Name = "btnClickToPlay";
            this.btnClickToPlay.Size = new System.Drawing.Size(111, 23);
            this.btnClickToPlay.TabIndex = 4;
            this.btnClickToPlay.Text = "Click To Play";
            this.btnClickToPlay.UseVisualStyleBackColor = true;
            this.btnClickToPlay.Click += new System.EventHandler(this.btnClickToPlay_Click);
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.Location = new System.Drawing.Point(35, 73);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(67, 13);
            this.lblGameInfo.TabIndex = 5;
            this.lblGameInfo.Text = "How to Play:";
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Location = new System.Drawing.Point(3, 139);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(254, 13);
            this.lblHowToPlay.TabIndex = 6;
            this.lblHowToPlay.Text = "Listen to the song and type what song you think it is!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Guess as many songs as you can in 1 minute";
            // 
            // lblGameInfo2
            // 
            this.lblGameInfo2.AutoSize = true;
            this.lblGameInfo2.Location = new System.Drawing.Point(3, 171);
            this.lblGameInfo2.Name = "lblGameInfo2";
            this.lblGameInfo2.Size = new System.Drawing.Size(261, 13);
            this.lblGameInfo2.TabIndex = 8;
            this.lblGameInfo2.Text = "Try to use correct spelling when entering your answer!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 474);
            this.Controls.Add(this.lblGameInfo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.lblGameInfo);
            this.Controls.Add(this.btnClickToPlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Song Guessing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClickToPlay;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGameInfo2;
    }
}

