using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Final
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        string userName;
        public Form1()
        {
            InitializeComponent();

            player.SoundLocation = "wiisong.wav";
            btnClickToPlay.Enabled = false;
            
        }

        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {
            userName = txtEnterName.Text;
            btnClickToPlay.Enabled = txtEnterName.Text.Trim().Length > 0;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }

      
    }
}
