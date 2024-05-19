using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace E_PetGame_Dogon_LukySalmanGlenn
{
    [Serializable]
    public class Player
    {
        #region DATA MEMBER
        private string name;
        private int coins;
        private DateTime lastPlay;
        #endregion

        #region CONSTRUCTORS
        public Player(string name)
        {
            this.Name = name;
            this.Coins = 100;
            this.LastPlay = DateTime.Now;
        }
        #endregion

        #region PROPERTIES
        public string Name
        {
            get => name;
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Player name can not be empty");
                }
            }
        }
        public int Coins { get => coins; set => coins = value; }
        public DateTime LastPlay { get => lastPlay; set => lastPlay = value; }
        #endregion

        #region METHODS
        public string DisplayData()
        {
            string data = "" + this.Coins;
            return data;
        }
        #endregion
    }
}