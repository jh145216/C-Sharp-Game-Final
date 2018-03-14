using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace Final
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
       
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnClickToPlay_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
          //  this.player.Stop(); //stops the background music
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   this.player.SoundLocation = @"C:\Users\mc137344\Downloads\guccigang.wav";
         //  this.player.PlayLooping();
        }
    }
}
