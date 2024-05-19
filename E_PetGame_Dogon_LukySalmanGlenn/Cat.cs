using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_PetGame_Dogon_LukySalmanGlenn
{
    [Serializable]
    public class Cat : Pet
    {
        #region DATA MEMBER
        private bool vaccinationStatus;
        #endregion

        #region CONSTRUCTORS
        public Cat(string name, Image picture, Player owner, string selectedPet) : base(name, picture, owner, selectedPet)
        {
            this.VaccinationStatus = false;
        }
        #endregion

        #region PROPERTIES
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
        #endregion

        #region METHODS

        public override string DisplayData()
        {
            string status = "No";
            if (this.VaccinationStatus == true)
            {
                status = "Yes";
            }
            string data = base.DisplayData() +
                          "\nVaccination Status : " + status;
            return data;
        }
        public override void Feed()
        {
            base.Feed();
        }
        public void Play()
        {
            base.Happiness += 50;
            base.Energy -= 30;
            //coin player bertambah 50% dari kenaikan indikator * 100
            base.Owner.Coins += (int)(0.5 * 50 * 100);
        }

        public void Sleep()
        {
            base.Happiness += 20;
            base.Energy += 70;
            //coin player bertambah 50% dari kenaikan indikator * 100
            base.Owner.Coins += (int)(0.5 * 20 * 100);
        }

        public void Bath()
        {
            base.Health += 30;
            //coin player bertambah 50% dari kenaikan indikator * 100
            base.Owner.Coins += (int)(0.5 * 30 * 100);
        }

        public void Vaccinate()
        {
            //vaksin hanya bisa 1x saja
            //cek apakah sebelumnya sudah pernah divaksin
            if (this.VaccinationStatus == false)
            {
                //cek apakah coin player mencukupi (biaya vaksin = 1000 coins)
                if (base.Owner.Coins >= 1000)
                {
                    base.Health += 40;
                    base.Happiness -= 10;
                    this.VaccinationStatus = true;
                    base.Owner.Coins -= 1000;
                    //coin player bertambah 50% dari kenaikan indikator * 100
                    base.Owner.Coins += (int)(0.5 * 40 * 100);
                }
                else
                {
                    throw new Exception("Not enough coins. Vaccination cost = 1000 coins.");
                }
            }
            else
            {
                throw new Exception("Your pet has already vaccinated");
            }
        }
        #endregion
    }
}