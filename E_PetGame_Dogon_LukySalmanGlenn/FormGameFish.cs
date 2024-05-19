using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_PetGame_Dogon_LukySalmanGlenn
{
    public partial class FormGameFish : Form
    {
        public FormGameFish()
        {
            InitializeComponent();
        }
        LetsPlay form;
        int pipeSpeed = 9;
        int fall = 5;
        int score = 0;
        private void FormGameFish_Load(object sender, EventArgs e)
        {
            form = (LetsPlay)this.Owner;
            pictureBoxGameOver.Visible = false;
            buttonBack.Visible = false;
        }

        private void FormGameFish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                fall = -5;
            }
        }

        private void FormGameFish_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                fall = 5;
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            pictureBoxFish.Top += fall;
            pictureBoxTop1.Left -= pipeSpeed;
            
            pictureBoxBottom1.Left -= pipeSpeed;
            
            labelScore.Text = score.ToString();

            if (pictureBoxBottom1.Left < -50)
            {
                pictureBoxBottom1.Left = 600;
                score++;
            }
            if (pictureBoxTop1.Left < -50)
            {
                pictureBoxTop1.Left = 750;
                score++;
            }


            if (pictureBoxFish.Bounds.IntersectsWith(pictureBoxBottom1.Bounds) ||
                pictureBoxFish.Bounds.IntersectsWith(pictureBoxTop1.Bounds) ||
                pictureBoxFish.Bounds.IntersectsWith(pictureBoxGround.Bounds))
            {
                pictureBoxGameOver.Visible = true;
                buttonBack.Visible = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
