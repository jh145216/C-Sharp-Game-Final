namespace Final
{
    partial class Form2
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.txtUserGuess = new System.Windows.Forms.TextBox();
            this.lblSongName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblRightWrong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(63, 213);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 2;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(12, 161);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(86, 13);
            this.lblTimeLeft.TabIndex = 3;
            this.lblTimeLeft.Text = "Time Remaining:";
            // 
            // txtUserGuess
            // 
            this.txtUserGuess.Location = new System.Drawing.Point(373, 337);
            this.txtUserGuess.Name = "txtUserGuess";
            this.txtUserGuess.Size = new System.Drawing.Size(100, 20);
            this.txtUserGuess.TabIndex = 4;
            this.txtUserGuess.TextChanged += new System.EventHandler(this.txtUserGuess_TextChanged);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(301, 344);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(66, 13);
            this.lblSongName.TabIndex = 5;
            this.lblSongName.Text = "Song Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(227, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Location = new System.Drawing.Point(652, 119);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(38, 13);
            this.lblYourScore.TabIndex = 7;
            this.lblYourScore.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(655, 146);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "label1";
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(511, 337);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(109, 23);
            this.btnCheckAnswer.TabIndex = 9;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // lblRightWrong
            // 
            this.lblRightWrong.AutoSize = true;
            this.lblRightWrong.Location = new System.Drawing.Point(373, 374);
            this.lblRightWrong.Name = "lblRightWrong";
            this.lblRightWrong.Size = new System.Drawing.Size(0, 13);
            this.lblRightWrong.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 465);
            this.Controls.Add(this.lblRightWrong);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.txtUserGuess);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblTimer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.TextBox txtUserGuess;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblRightWrong;

    }
}