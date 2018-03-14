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
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        string song1 = "gucci gang";
        string song2 = "rockstar";
        string song3 = "wii theme";
        string song4 = "humble";
        string song5 = "xo tour llif3";
        static Random rnd = new Random();
        string songPicked;
        int songPick = rnd.Next(1,6); 

        int score = 0;
        string userInput;
        int duration = 60;
        public Form2()
        {
            InitializeComponent();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
        duration--; 
           lblTimer.Text = duration.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            gameTimer.Start();
            lblScore.Text = score.ToString();
         
            
        }

        private void txtUserGuess_TextChanged(object sender, EventArgs e)
        {
            txtUserGuess.CharacterCasing = CharacterCasing.Lower;
            userInput = txtUserGuess.Text;
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            
            if (userInput == song1)
            {
                score++;
            }
            else
            {
                score--;
            }
            
            lblScore.Text = score.ToString();          
        }
        public void playSong()
        {
           if(songPick == 1)
           {
               
               this.player.SoundLocation = @"C:\Users\mc137344\Downloads\guccigang.wav";
               this.player.PlayLooping();
           }
        } 

    }
}
