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
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(); //this is what allows the songs to be played. 
        // bellow are all the different names of the songs. This is what the user would have to input to get the correct answer. 
        string song1 = "gucci gang";
        string song3 = "rockstar";
        string song2 = "wii theme";
        string song4 = "humble";
        string song5 = "gods plan";



       // static Random rnd = new Random(); Will be used in a future version. 


        string songPicked;



        int songPick = 1;
        int score = 0;
        string userInput;
        int duration = 90; //timer length in seconds. 


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
            playSong();
        }




        private void txtUserGuess_TextChanged(object sender, EventArgs e) //Changes the users input to all lower case as they type to make it easier to match to the song name. 
        {
            txtUserGuess.CharacterCasing = CharacterCasing.Lower;
            userInput = txtUserGuess.Text;
        }




        private void btnCheckAnswer_Click(object sender, EventArgs e) //this is what checks the user's answer to see if it is correct.
        {
            
            if (userInput == songPicked)
            {
                lblRightWrong.Text = "Correct!";
                score = score +25;
                player.Stop();
                songPick++;
                playSong();
               
            }
            else
            {
                score= score -5;
                lblRightWrong.Text = "Wrong!!!";
            }
            
            lblScore.Text = score.ToString();          
        }

        public void chooseSong()
        {
            //int songPick = rnd.Next(1, 6); This will randomize the song order in a future version. 
        
        }




        public void playSong() // this is what plays the songs when they are picked.
        {
           
           
           if(songPick == 1)
           {
               songPicked = song1;
               this.player.SoundLocation = @"E:\MusicForFinal\guccigang.wav"; //This tells it where to get the audio from. 
               this.player.PlayLooping(); //Plays it in a loop. 
           }
           if (songPick == 2)
           {
               songPicked = song2;
               this.player.SoundLocation = @"E:\MusicForFinal\wiimusic.wav";
               this.player.PlayLooping();
           }

           if (songPick == 3)
           {
               songPicked = song3;
               this.player.SoundLocation = @"E:\MusicForFinal\rockstar.wav";
               this.player.PlayLooping();
           }

           if (songPick == 4)
           {
               songPicked = song4;
               this.player.SoundLocation = @"E:\MusicForFinal\humble.wav";
               this.player.PlayLooping();
           }

           if (songPick == 5)
           {
               songPicked = song5;
               this.player.SoundLocation = @"E:\MusicForFinal\godsplan.wav";
               this.player.PlayLooping();

           }
            if (songPick == 6)
            {
                this.player.SoundLocation = @"E:\MusicForFinal\mariowin.wav";
                this.player.Play();
                score = score + (duration * 10);
                MessageBox.Show("You won with a score of: " + score.ToString() , "You win!!!!!!!");
            }

        } 

    }
}
