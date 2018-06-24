using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Birds
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 5;
        int Inscore = 0;

        public Form1()
        {
            InitializeComponent();
            endText1.Text = "Game Over!";
            endText2.Text = "Your final score is: " + Inscore;
            gameDesigner.Text = "TeMePyT";
            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            scoreText.Text = "" + Inscore;
            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }
            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 1000;
                Inscore += 1;
            }
            else if (pipeTop.Left < -95)
            {
                pipeTop.Left = 1050;
                Inscore += 1;
            }
        }

        private void inGameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
        }
    }
}
