using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E_PetGame_Dogon_LukySalmanGlenn
{
    [Serializable]
    public class Chameleon : Pet
    {
        #region DATA MEMBER
        private Color currentColor;
        #endregion

        #region CONSTRUCTORS
        public Chameleon(string name, Image picture, Player owner, string selectedPet) : base(name, picture, owner, selectedPet)
        {
            this.CurrentColor = Color.Green;
        }
        #endregion

        #region PROPERTIES
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion

        #region METHODS
        public override string DisplayData()
        {
            string data = base.DisplayData() +
                          "\nCurrent Color : " + this.CurrentColor + "\n";
            return data;
        }

        public void ChangeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }

        public void Sleep()
        {
            base.Health += 60;
            base.Energy += 60;
            //coin player bertambah 50% dari kenaikan indikator * 100
            base.Owner.Coins += (int)(0.5 * 60 * 100);
            base.Owner.Coins += (int)(0.5 * 60 * 100);
        }
        #endregion
    }
}