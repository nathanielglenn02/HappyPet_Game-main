using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace E_PetGame_Dogon_LukySalmanGlenn
{
    [Serializable]
    public class Fish : Pet
    {


 
        public Fish(string name, Image picture, Player owner, string selectedPet) : base(name, picture, owner, selectedPet)
        {


        }


        public override void Feed()
        {
            base.Health += 20;
            base.Energy += 40;
            //coin player bertambah 50% dari kenaikan indikator * 100
            base.Owner.Coins += (int)(0.5 * 20 * 100);
            base.Owner.Coins += (int)(0.5 * 40 * 100);
        }
        public void Clean()
        {
            //cek apakah coin player mencukupi (biaya cleaning = 500 coins)
            if (base.Owner.Coins >= 500)
            {
                base.Health += 60;
                base.Happiness += 50;
                base.Owner.Coins -= 500;
                //coin player bertambah 50% dari kenaikan indikator * 100
                base.Owner.Coins += (int)(0.5 * 60 * 100);
                base.Owner.Coins += (int)(0.5 * 50 * 100);
            }
            else
            {
                throw new Exception("Not enough coins. Cleaning cost = 500 coins.");
            }

        }
    }
}