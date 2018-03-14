using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGuessSong_TextChanged(object sender, EventArgs e)
        {

            string song1 = "gucci gang";
            string song2 = "rockstar";
            string song3 = "wii theme";
            string song4 = "humble";
            string song5 = "xo tour llif3";

            if (txtGuessSong.Text == song1 || txtGuessSong.Text == song5)
            {
                MessageBox.Show("Your right");
            }
            else if (txtGuessSong.Text == song2 || txtGuessSong.Text == song3 || txtGuessSong.Text == song4)
            {
                MessageBox.Show("Your Worong");
            }
        }
    }
}
