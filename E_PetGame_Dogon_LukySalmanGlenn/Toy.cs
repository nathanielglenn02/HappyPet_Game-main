using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace E_PetGame_Dogon_LukySalmanGlenn
{
    [Serializable]
    public class Toy
    {
        #region DATA MEMBER
        private string name;
        private int price;
        private int benefit;
        private Image picture;
        #endregion

        #region CONSTRUCTORS
        public Toy(string name, int price, int benefit, Image picture)
        {
            this.Name = name;
            this.Price = price;
            this.Benefit = benefit;
            this.Picture = picture;
        }
        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Benefit { get => benefit; set => benefit = value; }
        public Image Picture { get => picture; set => picture = value; }
        #endregion

        #region METHODS
        public string DisplayData()
        {
            string data = this.Name +
                         "\n" + this.price + " coins " +
                         "\n+ " + this.Benefit + " %";
            return data;
        }
        #endregion
    }
}