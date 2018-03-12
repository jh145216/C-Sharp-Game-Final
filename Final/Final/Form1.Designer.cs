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
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClickToPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(97, 342);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(117, 20);
            this.txtEnterName.TabIndex = 0;
            this.txtEnterName.TextChanged += new System.EventHandler(this.txtEnterName_TextChanged);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(94, 260);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(120, 13);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter Your Name Below";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(326, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(114, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to our game!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnClickToPlay
            // 
            this.btnClickToPlay.Location = new System.Drawing.Point(97, 394);
            this.btnClickToPlay.Name = "btnClickToPlay";
            this.btnClickToPlay.Size = new System.Drawing.Size(75, 23);
            this.btnClickToPlay.TabIndex = 4;
            this.btnClickToPlay.Text = "Click To Play";
            this.btnClickToPlay.UseVisualStyleBackColor = true;
            this.btnClickToPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 474);
            this.Controls.Add(this.btnClickToPlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtEnterName);
            this.Name = "Form1";
            this.Text = "Song Guessing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClickToPlay;
    }
}

