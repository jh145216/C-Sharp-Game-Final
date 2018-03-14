namespace Guessing
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
            this.txtGuessSong = new System.Windows.Forms.TextBox();
            this.lblguccigang = new System.Windows.Forms.Label();
            this.lblrockstar = new System.Windows.Forms.Label();
            this.lblwiitheme = new System.Windows.Forms.Label();
            this.lblhumble = new System.Windows.Forms.Label();
            this.lblxotourllif3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGuessSong
            // 
            this.txtGuessSong.Location = new System.Drawing.Point(216, 168);
            this.txtGuessSong.Name = "txtGuessSong";
            this.txtGuessSong.Size = new System.Drawing.Size(100, 20);
            this.txtGuessSong.TabIndex = 0;
            this.txtGuessSong.TextChanged += new System.EventHandler(this.txtGuessSong_TextChanged);
            // 
            // lblguccigang
            // 
            this.lblguccigang.AutoSize = true;
            this.lblguccigang.Location = new System.Drawing.Point(73, 65);
            this.lblguccigang.Name = "lblguccigang";
            this.lblguccigang.Size = new System.Drawing.Size(60, 13);
            this.lblguccigang.TabIndex = 1;
            this.lblguccigang.Text = "gucci gang";
            // 
            // lblrockstar
            // 
            this.lblrockstar.AutoSize = true;
            this.lblrockstar.Location = new System.Drawing.Point(73, 122);
            this.lblrockstar.Name = "lblrockstar";
            this.lblrockstar.Size = new System.Drawing.Size(45, 13);
            this.lblrockstar.TabIndex = 2;
            this.lblrockstar.Text = "rockstar";
            // 
            // lblwiitheme
            // 
            this.lblwiitheme.AutoSize = true;
            this.lblwiitheme.Location = new System.Drawing.Point(73, 175);
            this.lblwiitheme.Name = "lblwiitheme";
            this.lblwiitheme.Size = new System.Drawing.Size(51, 13);
            this.lblwiitheme.TabIndex = 3;
            this.lblwiitheme.Text = "wii theme";
            // 
            // lblhumble
            // 
            this.lblhumble.AutoSize = true;
            this.lblhumble.Location = new System.Drawing.Point(73, 217);
            this.lblhumble.Name = "lblhumble";
            this.lblhumble.Size = new System.Drawing.Size(41, 13);
            this.lblhumble.TabIndex = 4;
            this.lblhumble.Text = "humble";
            // 
            // lblxotourllif3
            // 
            this.lblxotourllif3.AutoSize = true;
            this.lblxotourllif3.Location = new System.Drawing.Point(73, 261);
            this.lblxotourllif3.Name = "lblxotourllif3";
            this.lblxotourllif3.Size = new System.Drawing.Size(57, 13);
            this.lblxotourllif3.TabIndex = 5;
            this.lblxotourllif3.Text = "xo tour llif3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 343);
            this.Controls.Add(this.lblxotourllif3);
            this.Controls.Add(this.lblhumble);
            this.Controls.Add(this.lblwiitheme);
            this.Controls.Add(this.lblrockstar);
            this.Controls.Add(this.lblguccigang);
            this.Controls.Add(this.txtGuessSong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuessSong;
        private System.Windows.Forms.Label lblguccigang;
        private System.Windows.Forms.Label lblrockstar;
        private System.Windows.Forms.Label lblwiitheme;
        private System.Windows.Forms.Label lblhumble;
        private System.Windows.Forms.Label lblxotourllif3;
    }
}

