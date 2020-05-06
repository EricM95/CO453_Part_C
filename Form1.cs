using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlyBy
{
    public partial class Form1 : Form
    {
        const int MAX = 8;                  // there are 8 images
        Image[] images = new Image[MAX];    // set up an array to hold them

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // store all the images in the array
            for(int i = 0; i < MAX; i++)
            {
                images[i] = Image.FromFile("bfly" + i +".gif");
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxBFly_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}