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
    public partial class FormMenu : Form
    {
        LetsPlay letsPlay;
        public Player myPlayer;
        public Pet myPet;

        public Toy selectedToy;

        public List<Player> listPlayers = new List<Player>();
        public List<Pet> listPets = new List<Pet>();
        public FormMenu()
        {
            InitializeComponent();
            //soundBaground.URL = @"D:\Visual Studio C#\aset oop\super mario.mp3";
            //kalau pake sound, gif welcome jadi lemot mangkanya di nonaktif dulu      
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            panelSelectPlayer.Visible = false;
            panelSelectNewPet.Visible = false;
            panelCreatePlayer.Visible = false;
            textBoxNewPetName.Text = "My Pet";
            textBoxNewPlayerName.Text = "Dogon";

            if (File.Exists("players.gm"))
            {
                FileStream myFile1 = new FileStream("players.gm", FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter1 = new BinaryFormatter();
                listPlayers = (List<Player>)formatter1.Deserialize(myFile1);
                myFile1.Close();
            }

            if (File.Exists("pets.gm"))
            {
                FileStream myFile2 = new FileStream("pets.gm", FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter2 = new BinaryFormatter();
                listPets = (List<Pet>)formatter2.Deserialize(myFile2);
                myFile2.Close();
            }
        }

        private void comboBoxSelectPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = listPlayers;
            comboBoxSelectPlayer.DataSource = bs;
            comboBoxSelectPlayer.DisplayMember = "Name";
        }

        private void pictureBoxLetsPlay_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectPlayer.SelectedIndex != -1)
            {
                Player selectedPlayer = (Player)comboBoxSelectPlayer.SelectedItem;

                foreach (Pet p in listPets)
                {
                    if (p.Owner.Name == selectedPlayer.Name)
                    {
                        myPet = p;
                        myPlayer = selectedPlayer;

                        LetsPlay play = new LetsPlay();
                        play.Owner = this;
                        play.ShowDialog();
                        
                        break;
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("you must create new player!!!");
            }
        }

        private void linkLabelNewPlayer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ini create player baru
            //buat disambungin ke form new player
            panelSelectPlayer.Visible = false;
            panelSelectNewPet.Visible = false;
            panelCreatePlayer.Visible = true;
        }

        private void pictureBoxButtonPlay_Click(object sender, EventArgs e)
        {
            panelSelectPlayer.Visible = true;
            panelSelectNewPet.Visible = false;
            panelCreatePlayer.Visible = false;
        }

        private void pictureBoxButtonReset_Click(object sender, EventArgs e)
        {
            panelSelectNewPet.Visible = true;
        }

        private void pictureBoxButtonChangePet_Click(object sender, EventArgs e)
        {
            panelSelectPlayer.Visible = false;
            panelSelectNewPet.Visible = true;
            panelCreatePlayer.Visible = false;
        }

        private void panelSelectNewPet_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBoxResetNewPet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxResetNewPet.Text == "cat")
            {
                pictureBoxPet.Image = Properties.Resources.cat;
            }
            else if (comboBoxResetNewPet.Text == "fish")
            {
                pictureBoxPet.Image = Properties.Resources.fish;
            }
            else
            {
                pictureBoxPet.Image = Properties.Resources.chameleon;
            }
        }



        private void pictureBoxLetsPlayNewPet_Click(object sender, EventArgs e)
        {
            LetsPlay play = new LetsPlay();
            play.Owner = this;
            play.ShowDialog();
        }

        private void pictureBoxChangePetBack_Click(object sender, EventArgs e)
        {
            panelSelectPlayer.Visible = false;
            panelSelectNewPet.Visible = false;
            panelCreatePlayer.Visible = false;
        }

        private void pictureBoxSelectBack_Click(object sender, EventArgs e)
        {
            panelSelectPlayer.Visible = false;
            panelSelectNewPet.Visible = false;
            panelCreatePlayer.Visible = false;
        }

        private void pictureBoxCreatePlayerBack_Click(object sender, EventArgs e)
        {
            panelSelectPlayer.Visible = true;
            panelSelectNewPet.Visible = false;
            panelCreatePlayer.Visible = false;
        }

        private void comboBoxChoosePet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoosePet.Text == "cat")
            {
                pictureBoxCreatePet.Image = Properties.Resources.cat;
            }
            else if (comboBoxChoosePet.Text == "fish")
            {
                pictureBoxCreatePet.Image = Properties.Resources.fish;
            }
            else
            {
                pictureBoxCreatePet.Image = Properties.Resources.chameleon;
            }
        }

        private void pictureBoxCreateLetsPlay_Click(object sender, EventArgs e)
        {
            try
            {
                string player = textBoxNewPlayerName.Text;
                myPlayer = new Player(player);
                string pet = textBoxNewPetName.Text;
                Image image = pictureBoxCreatePet.Image;
                if (comboBoxChoosePet.Text == "cat")
                {
                    string selectedPet = "cat";
                    myPet = new Cat(pet, image, myPlayer, selectedPet);
                }
                else if (comboBoxChoosePet.Text == "chameleon")
                {
                    string selectedPet = "chameleon";
                    myPet = new Chameleon(pet, image, myPlayer, selectedPet);
                }
                else
                {
                    string selectedPet = "fish";
                    myPet = new Fish(pet, image, myPlayer, selectedPet);

                }
                listPets.Add(myPet);
                listPlayers.Add(myPlayer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LetsPlay play = new LetsPlay();
            play.Owner = this;
            play.ShowDialog();

        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream myFile1 = new FileStream("players.gm", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(myFile1, listPlayers);
            myFile1.Close();

            //save data pet
            FileStream myFile2 = new FileStream("pets.gm", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter2 = new BinaryFormatter();
            formatter2.Serialize(myFile2, listPets);
            myFile2.Close();
        }

        

        private void panelSelectPlayer_Paint_1(object sender, PaintEventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = listPlayers;
            comboBoxSelectPlayer.DataSource = listPlayers;
            comboBoxSelectPlayer.DisplayMember = "Name";
        }
    }
}
