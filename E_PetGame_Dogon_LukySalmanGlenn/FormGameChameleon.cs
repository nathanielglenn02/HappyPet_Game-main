using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_PetGame_Dogon_LukySalmanGlenn
{
    public partial class FormGameChameleon : Form
    {
        public FormGameChameleon()
        {
            InitializeComponent();
        }

        LetsPlay form;

        int pipeSpeed = 9;
        int fall = 5;
        int score = 0;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGameChameleon_Load(object sender, EventArgs e)
        {
            form = (LetsPlay)this.Owner;
            pictureBoxGameOver.Visible = false;
            buttonBack.Visible = false;
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            pictureBoxChameleon.Top += fall;
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


            if (pictureBoxChameleon.Bounds.IntersectsWith(pictureBoxBottom1.Bounds) ||
                pictureBoxChameleon.Bounds.IntersectsWith(pictureBoxTop1.Bounds) ||
                pictureBoxChameleon.Bounds.IntersectsWith(pictureBoxGround.Bounds))
            {
                pictureBoxGameOver.Visible = true;
                buttonBack.Visible = true;
            }
        }

        private void FormGameChameleon_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                fall = 5;
            }
        }

        private void FormGameChameleon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                fall = -5;
            }
        }
    }
}
