using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
   
    public partial class Form1 : Form
    {
        int boruHızı = 8;
        int gravity = 10;
        int score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            kus.Top += gravity;
            boruAlt.Left -= boruHızı;
            boruUst.Left -= boruHızı;
            scoretext.Text = "Score: "+score;
            if(boruAlt.Left<-150)
            {
                boruAlt.Left = 800;
                score++;
            }
            
            if(boruUst.Left<-180)
            {
                boruUst.Left = 950;
                score++;
            }
            if (kus.Bounds.IntersectsWith(boruAlt.Bounds) || kus.Bounds.IntersectsWith(boruUst.Bounds) || kus.Bounds.IntersectsWith(zemin.Bounds))
            {
                endGame();
            }
            if(score>5)
            {
                boruHızı = 15;
            }
            if(kus.Top<-25)
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoretext.Text = "Game Over";
        }

        private void kus_Click(object sender, EventArgs e)
        {

        }
    }
}
