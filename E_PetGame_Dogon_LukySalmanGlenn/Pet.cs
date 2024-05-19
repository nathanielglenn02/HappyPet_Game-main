using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace E_PetGame_Dogon_LukySalmanGlenn
{
    [Serializable]

    public abstract class Pet
    {
        #region DATA MEMBER
        private string name;
        private int energy;
        private int health;
        private int happiness;
        private Image picture;
        private Player owner;
        private List<Toy> listToys;
        private string selectedPet;
        #endregion

        #region CONSTRUCTORS
        public Pet(string name, Image picture, Player owner, string selectedPet)
        {
            this.Name = name;
            this.Health = 100;
            this.Energy = 100;
            this.Happiness = 100;
            this.Picture = picture;
            this.Owner = owner;
            this.ListToys = new List<Toy>();
            this.SelectedPet = selectedPet;

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
                    throw new Exception("Pet name can not be empty");
                }
            }
        }
        public int Health
        {
            get => health;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    health = value;
                }
                else if (value < 10)
                {
                    health = 10;
                }
                else
                {
                    health = 100;
                }
            }
        }
        public int Energy
        {
            get => energy;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    energy = value;
                }
                else if (value < 10)
                {
                    energy = 10;
                }
                else
                {
                    energy = 100;
                }
            }
        }
        public int Happiness
        {
            get => happiness;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    happiness = value;
                }
                else if (value < 10)
                {
                    happiness = 10;
                }
                else
                {
                    happiness = 100;
                }
            }
        }
        public Image Picture { get => picture; set => picture = value; }
        public List<Toy> ListToys { get => listToys; private set => listToys = value; }
        public Player Owner { get => owner; set => owner = value; }
        public string SelectedPet { get => selectedPet; set => selectedPet = value; }
        #endregion

        #region METHODS
        public virtual void Feed()
        {
            this.Health += 30;
            this.Energy += 50;
        }
     
        public virtual string DisplayData()
        {
            string data = this.Name;
            return data;
        }

        public void BuyToy(Toy newToy)
        {
            if (this.Owner.Coins >= newToy.Price)
            {
                this.ListToys.Add(newToy);
                this.Owner.Coins -= newToy.Price;
                this.Happiness += newToy.Benefit;
            }
            else
            {
                throw new Exception("Not enough coins. Toy's price = " + newToy.Price);
            }
        }

        public string GetHealthCondition()
        {
            string condition = "";
            if (this.Health >= 80)
            {
                condition = "Very Good";
            }
            else if (this.Health >= 61)
            {
                condition = "Good";
            }
            else if (this.Health >= 26)
            {
                condition = "Poor";
            }
            else
            {
                condition = "Very Poor";
            }
            return condition;
        }

        public string GetEnergyCondition()
        {
            string condition = "";
            if (this.Energy >= 76)
            {
                condition = "Strong";
            }
            else if (this.Health >= 51)
            {
                condition = "Moderate";
            }
            else
            {
                condition = "Weak";
            }
            return condition;
        }

        public string GetHappinessCondition()
        {
            string condition = "";
            if (this.Happiness >= 61)
            {
                condition = "Happy";
            }
            else
            {
                condition = "Unhappy";
            }
            return condition;
        }
        #endregion
    }
    


}