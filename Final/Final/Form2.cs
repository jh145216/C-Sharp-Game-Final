﻿using System;
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
        int duration = 60;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
        }
    }
}
