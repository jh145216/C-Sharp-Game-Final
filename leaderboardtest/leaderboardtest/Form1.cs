using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace leaderboardtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] scores;
            List<int> listx = new List<int>();
            listx.Add(5);
            Console.WriteLine("hello");
            string scores2 = string.Join(",", listx.ToArray());
            File.WriteAllText("C:\\Users\\mc137344\\AppData\\Local\\Temporary Projects\\leaderboardtest\\Resources\\results.txt", scores2);
            scores = File.ReadAllLines("C:\\Users\\mc137344\\AppData\\Local\\Temporary Projects\\leaderboardtest\\Resources\\results.txt");
            scores.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string readText = File.ReadAllText("C:\\Users\\mc137344\\AppData\\Local\\Temporary Projects\\leaderboardtest\\Resources\\results.txt");
            label1.Text = readText; 
        }
    }
}
