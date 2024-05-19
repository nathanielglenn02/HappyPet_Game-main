using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace E_PetGame_Dogon_LukySalmanGlenn
{
    public partial class LetsPlay : Form
    {
        int activitySeconds;
        public LetsPlay()
        {
            InitializeComponent();
        }
        FormMenu menu;
        List<Toy> listToys = new List<Toy>();
        public Toy selectedToys;

        private void LetsPlay_Load(object sender, EventArgs e)
        {
            menu = (FormMenu)this.Owner;
            panelCat.Visible = false;
            panelChameleon.Visible = false;
            panelSelectToys.Visible = false;
            panelAddNewPet.Visible = false;
            panelProgressBar.Visible = false;
            panelAkuarium.Visible = false;
            panelBuyToys.Visible = false;

            pictureBoxCat.Visible = false;
            pictureBoxChameleon.Visible = false;
            pictureBoxFish.Visible = false;

            labelNamePet.Text = menu.myPet.DisplayData();
            labelNamePlayer.Text = menu.myPlayer.Name;
            labelCoin.Text = menu.myPlayer.Coins.ToString();
            labelDateTime.Text = menu.myPlayer.LastPlay.ToString();



            timerTime.Interval = 1000;
            StartGame();
        }
        public void StartGame()
        {
            try
            {
                labelNamePlayer.Text = menu.myPlayer.Name;
                labelNamePet.Text = menu.myPet.Name;
                if (menu.myPet.SelectedPet == "cat")
                {
                    CatStart();
                }
                else if (menu.myPet.SelectedPet == "chameleon")
                {
                    ChameleonStart();
                }
                else
                {
                    FishStart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxCat_Click(object sender, EventArgs e)
        {
            panelCat.Visible = true;
            panelChameleon.Visible = false;
            panelSelectToys.Visible = false;
            panelAddNewPet.Visible = false;
            panelProgressBar.Visible = true;
            panelAkuarium.Visible = false;           
        }

        private void pictureBoxChameleon_Click(object sender, EventArgs e)
        {
            panelCat.Visible = false;
            panelChameleon.Visible = true;
            panelSelectToys.Visible = false;
            panelAddNewPet.Visible = false;
            panelProgressBar.Visible = true;
            panelAkuarium.Visible = false;
            timerTime.Start();
        }
        private void ChangeActivity(string activity)
        {
            if (activity == "Feed")
            {
                if (menu.myPet is Cat)
                {
                    pictureBoxCat.Image = Properties.Resources.cat_eat;
                }
                else if (menu.myPet is Fish)
                {
                    panelAkuarium.BackgroundImage = Properties.Resources.fish_eat;
                }
                else
                {
                    pictureBoxChameleon.Image = Properties.Resources.chameleon_eat;
                }
            }
            else if (activity == "Sleep")
            {
                if (menu.myPet is Cat)
                {
                    pictureBoxCat.Image = Properties.Resources.cat_sleep;
                }
                else if (menu.myPet is Chameleon)
                {
                    pictureBoxChameleon.Image = Properties.Resources.cham_sleep;
                }
            }
            else if (activity == "Play")
            {
                if (selectedToys.Name == "stick")
                {
                    pictureBoxCat.Image = Properties.Resources.cat_toy_stick;
                }
                else if (selectedToys.Name == "mouse")
                {
                    pictureBoxCat.Image = Properties.Resources.cat_toy_mouse;
                }
                else
                {
                    pictureBoxCat.Image = Properties.Resources.cat_toy_kerincing;
                }
            }
            else if (activity == "Bath")
            {
                pictureBoxCat.Image = Properties.Resources.cat_bath;
            }
            else if (activity == "Vaccinate")
            {
                pictureBoxCat.Image = Properties.Resources.cat_vaccinate;
            }
            else if (activity == "Clean")
            {
                panelAkuarium.BackgroundImage = Properties.Resources.aquarium_clean;
            }
            else if (activity == "Change Color")
            {
                pictureBoxChameleon.Image = Properties.Resources.chameleon_changeColor;
            }
            activitySeconds = 3; //lama aktivitas dilakukan = 3 detik
            timerActivity.Start();
        }
        private void AquariumActivity(string activity)
        {
            if(activity == "Dirty")
            {
                panelAkuarium.BackgroundImage = Properties.Resources.aquarium_dirty;
            }
            activitySeconds = 3;
            timerActivity.Start();
        }

        private void pictureBoxCatEat_Click(object sender, EventArgs e)
        {
            try
            {
                menu.myPet.Feed();
                DisplayData();
                ChangeActivity("Feed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxCatBath_Click(object sender, EventArgs e)
        {
            try
            {
                ((Cat)menu.myPet).Bath();
                DisplayData();
                ChangeActivity("Bath");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxCatPlay_Click(object sender, EventArgs e)
        {
            try
            {
                ((Cat)menu.myPet).Play();
                panelCat.Visible = false;
                panelSelectToys.Visible = true;
                panelProgressBar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxCatSleep_Click(object sender, EventArgs e)
        {
            try
            {
                ((Cat)menu.myPet).Sleep();
                DisplayData();
                ChangeActivity("Sleep");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxCatVaccinate_Click(object sender, EventArgs e)
        {
            try
            {
                ((Cat)menu.myPet).Vaccinate();
                DisplayData();
                ChangeActivity("Vaccinate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxChamEat_Click(object sender, EventArgs e)
        {
            try
            {
                menu.myPet.Feed();
                DisplayData();
                ChangeActivity("Feed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBoxChamChangeColor_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayData();
                ChangeActivity("Change Color");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxGameCham_Click(object sender, EventArgs e)
        {
            FormGameChameleon formGameChameleon = new FormGameChameleon();
            formGameChameleon.Owner = this;
            formGameChameleon.ShowDialog();
            timerTime.Stop();
        }
        private void pictureBoxChamSleep_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayData();
                ((Chameleon)menu.myPet).Sleep();
                ChangeActivity("Sleep");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxAddCat_Click(object sender, EventArgs e)
        {
            panelCat.Visible = false;
            panelChameleon.Visible = false;
            panelSelectToys.Visible = false;
            panelAddNewPet.Visible = true;
            panelProgressBar.Visible = false;

            radioButtonCat.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelAddNewPet.Visible = false;
        }

        private void pictureBoxAddFish_Click(object sender, EventArgs e)
        {
            panelCat.Visible = false;
            panelChameleon.Visible = false;
            panelSelectToys.Visible = false;
            panelProgressBar.Visible = false;
            panelAddNewPet.Visible = true;

            radioButtonFish.Checked = true;
        }

        private void pictureBoxAddCham_Click(object sender, EventArgs e)
        {
            panelCat.Visible = false;
            panelChameleon.Visible = false;
            panelSelectToys.Visible = false;
            panelAddNewPet.Visible = true;
            panelProgressBar.Visible = false;


            radioButtonChameleon.Checked = true;
        }
        private void buttonAddNewPet_Click(object sender, EventArgs e)
        {

            try
            {
                if (radioButtonCat.Checked)
                {
                    if (menu.myPet.SelectedPet != "cat")
                    {
                        string selectedPet = "cat";
                        menu.myPet = new Cat(textBoxAddNewPetName.Text, pictureBoxCat.Image, menu.myPlayer, selectedPet);
                        CatStart();
                    }
                    else
                    {
                        MessageBox.Show("anda sudah memiliki peliharaan kucing");
                    }
                }
                else if (radioButtonFish.Checked)
                {
                    if (menu.myPet.SelectedPet != "fish")
                    {
                        string selectedPet = "cat";
                        menu.myPet = new Fish(textBoxAddNewPetName.Text, pictureBoxFish.Image, menu.myPlayer, selectedPet);
                        FishStart();
                    }
                    else
                    {
                        MessageBox.Show("anda sudah memiliki peliharaan ikan");
                    }
                }
                else
                {
                    if (menu.myPet.SelectedPet != "chameleon")
                    {
                        string selectedPet = "cat";
                        menu.myPet = new Chameleon(textBoxAddNewPetName.Text, pictureBoxChameleon.Image, menu.myPlayer, selectedPet);
                        ChameleonStart();
                    }
                    else
                    {
                        MessageBox.Show("anda sudah memiliki peliharaan bunglon");
                    }
                }
                menu.listPets.Add(menu.myPet);
                panelAddNewPet.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBoxBackAkuarium_Click(object sender, EventArgs e)
        {
            panelAkuarium.Visible = false;
        }

        private void pictureBoxFishEat_Click_1(object sender, EventArgs e)
        {
            try
            {
                menu.myPet.Feed();
                DisplayData();
                ChangeActivity("Feed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBoxFishAkuarium_Click_1(object sender, EventArgs e)
        {
            panelProgressBar.Visible = true;
            timerTime.Start();
            
        }

        private void pictureBoxFishClean_Click_1(object sender, EventArgs e)
        {
            try
            {
                ((Fish)menu.myPet).Clean();
                DisplayData();
                ChangeActivity("Clean");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelAkuarium_Paint_1(object sender, PaintEventArgs e)
        {
            try
            {
   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBoxGameFish_Click(object sender, EventArgs e)
        {
            FormGameFish form = new FormGameFish();
            form.Owner = this;
            form.ShowDialog();
            timerTime.Stop();
        }

        private void pictureBoxFish_Click(object sender, EventArgs e)
        {
            panelAkuarium.Visible = true;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {

            menu.myPet.Health -= 5;
            menu.myPet.Energy -= 5;
            menu.myPet.Happiness -= 5;
            progressBarHealth.Value = menu.myPet.Health;
            progressBarEnergy.Value = menu.myPet.Energy;
            progressBarHappiness.Value = menu.myPet.Happiness;
            
            if (menu.myPet.GetHealthCondition() == "Very Poor" && menu.myPet.GetEnergyCondition() == "Weak" && menu.myPet.GetHappinessCondition() == "Unhappy")
            {
                timerTime.Stop();
                GameOver();
            }
        }
        private void CatStart()
        {
            pictureBoxCat.Visible = true;
            panelCat.Visible = true;

            timerTime.Start();
            timerActivity.Interval = 1000;
        }
        private void ChameleonStart()
        {
            pictureBoxChameleon.Visible = true;
            panelChameleon.Visible = true;

            timerTime.Start();
            timerActivity.Interval = 1000;
        }
        public void FishStart()
        {
            pictureBoxFish.Visible = true;

            timerTime.Start();
            timerActivity.Interval = 1000;
        }
        private void GameOver()
        {
            foreach (Pet myPet in menu.listPets)
            {
                if(myPet.Name == menu.myPlayer.Name)
                {
                    menu.listPets.Remove(myPet);
                    break;
                }
            }
            foreach (Player player in menu.listPlayers)
            {
                if(player.Name == menu.myPlayer.Name)
                {
                    menu.listPlayers.Remove(player);
                    break;
                }
            }
            MessageBox.Show("Game over!!! your pet is very poor, weak, and unhappy.");
            panelCat.Visible = false;
            panelChameleon.Visible = false;
            panelSelectToys.Visible = false;
            panelAddNewPet.Visible = false;
            panelProgressBar.Visible = false;
            panelAkuarium.Visible = false;

            pictureBoxCat.Visible = false;
            pictureBoxChameleon.Visible = false;
            pictureBoxFish.Visible = false;

            labelNamePet.Visible = false;
            labelNamePlayer.Visible = false;
            labelCoin.Visible = false;
            labelDateTime.Visible = false;

        }

        private void timerActivity_Tick(object sender, EventArgs e)
        {
            activitySeconds--;
            if(activitySeconds == 0)
            {
                timerActivity.Stop();
                if (menu.myPet is Cat)
                {
                    pictureBoxCat.Image = Properties.Resources.cat;
                }
                else if (menu.myPet is Chameleon)
                {
                    pictureBoxChameleon.Image = Properties.Resources.chameleon;
                }
                else if (menu.myPet is Fish)
                {
                    panelAkuarium.BackgroundImage = Properties.Resources.aquarium;
                }
            }
        }
        public void DisplayData()
        {
            labelNamePet.Text = menu.myPet.Name;
            labelNamePlayer.Text = menu.myPlayer.Name;
            labelCoin.Text = menu.myPlayer.Coins.ToString();
        }

        
        

        private void pictureBoxLetsPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Toy newToy = new Toy("stick", 150, 10, Properties.Resources.stick);
                listToys.Add(newToy);
                newToy = new Toy("mouse", 300, 5, Properties.Resources.mouse_toys);
                listToys.Add(newToy);
                newToy = new Toy("kerincing", 200, 20, Properties.Resources.kerincing);
                listToys.Add(newToy);

                if (comboBoxBuyToys.Text == "stick")
                {
                    menu.myPet.BuyToy(listToys[0]);
                }
                else if (comboBoxBuyToys.Text == "mouse")
                {
                    menu.myPet.BuyToy(listToys[1]);
                }
                else if (comboBoxBuyToys.Text == "kerincing")
                {
                    menu.myPet.BuyToy(listToys[2]);
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = menu.myPet.ListToys;
             
                comboBoxSelectToys.DataSource = bs;
                comboBoxSelectToys.DisplayMember = "name";

                if (comboBoxSelectToys.SelectedIndex != -1)
                {
                    selectedToys = (Toy)comboBoxSelectToys.SelectedItem;

                    pictureBoxToys.Image = selectedToys.Picture;
                }

                MessageBox.Show("Toy berhasil dibeli");
                panelBuyToys.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxBackSelectToys_Click(object sender, EventArgs e)
        {
            panelBuyToys.Visible = false;
            panelSelectToys.Visible = true;
        }

        private void pictureBoxBuyToysLetsPlay_Click(object sender, EventArgs e)
        {
            //sing select toy gae main
            selectedToys = selectedToys;
            panelSelectToys.Visible = false;
            ChangeActivity("Play");
        }

        private void linkLabelBuyToys_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSelectToys.Visible = false;
            panelBuyToys.Visible = true;
        }

        private void pictureBoxCreatePlayerBack_Click(object sender, EventArgs e)
        {
            panelSelectToys.Visible = false;
        }

        private void comboBoxSelectToys_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSelectToys.SelectedIndex != -1)
                {
                    selectedToys = (Toy)comboBoxSelectToys.SelectedItem;

                    pictureBoxToys.Image = selectedToys.Picture;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxBuyToys_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBuyToys.Text == "kerincing")
                {
                    pictureBoxSelectToys.Image = Properties.Resources.kerincing;
                    labelPriceToys.Text = listToys[0].DisplayData();
                }
                else if (comboBoxBuyToys.Text == "mouse")
                {
                    pictureBoxSelectToys.Image = Properties.Resources.mouse_toys;
                    labelPriceToys.Text = listToys[1].DisplayData();
                }
                else
                {
                    pictureBoxSelectToys.Image = Properties.Resources.stick;
                    labelPriceToys.Text = listToys[2].DisplayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelBuyToys_Paint_1(object sender, PaintEventArgs e)
        {
            Toy newToy = new Toy("stick", 150, 10, Properties.Resources.stick);
            listToys.Add(newToy);
            newToy = new Toy("mouse", 300, 5, Properties.Resources.mouse_toys);
            listToys.Add(newToy);
            newToy = new Toy("kerincing", 200, 20, Properties.Resources.kerincing);
            listToys.Add(newToy);

            
        }

        private void panelSelectToys_Paint(object sender, PaintEventArgs e)
        {
            comboBoxSelectToys.DataSource = menu.myPet.ListToys;
            comboBoxSelectToys.DisplayMember = "Name";
        }

        private void panelAkuarium_Paint(object sender, PaintEventArgs e)
        {
            panelAkuarium.BackgroundImage = Properties.Resources.aquarium_dirty;
            activitySeconds = 3;
            timerActivity.Start();
        }
        private void SaveToFile()
        {
            //save data player
            FileStream myFile1 = new FileStream("players.vc", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(myFile1, menu.listPlayers);
            myFile1.Close();

            //save data pet
            FileStream myFile2 = new FileStream("pets.vc", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter2 = new BinaryFormatter();
            formatter2.Serialize(myFile2, menu.listPets);
            myFile2.Close();
        }
        private void LetsPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }
    }
}
