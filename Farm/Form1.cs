using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farm
{
    public partial class Form1 : Form
    {
        private List<Animal> NewFarm { get; set; }
        Animal SelectedRow;
        public Form1()
        {
            NewFarm = SpawnAnimals();
            InitializeComponent();
        }
        private List<Animal> SpawnAnimals()
        {
            var animals = new List<Animal>();

            animals.Add(new Dog(AnimalType.Dog, "Rex", 10, 4, true, false, true, false)); //Dog chicken etc ggf auch mit enums
            animals.Add(new Dog(AnimalType.Dog, "Lessie", 8, 4, true, true, false, false));
            animals.Add(new Chicken(AnimalType.Chicken, "Inge", 2, 2, false, false, false, true));
            animals.Add(new Chicken(AnimalType.Chicken, "Bernd", 3, 2, false, false, false, false));
            animals.Add(new Animal(AnimalType.Unknown, "Roland", 4, 6, false, false, false, false));

            return animals;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.NewFarm;
            renameColumns();
        }

        private void renameColumns()
        {
            dataGridView1.Columns[0].HeaderText = "Gattung";   // einbindung mit Enums testen
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Alter";
            dataGridView1.Columns[3].HeaderText = "Anzahl der Beine";
            dataGridView1.Columns[4].HeaderText = "Hat einen Schwanz";
            dataGridView1.Columns[5].HeaderText = "Kann bellen";
            dataGridView1.Columns[6].HeaderText = "Kann beißen";
            dataGridView1.Columns[7].HeaderText = "Kann Eier legen";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Animal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }


        #region Button actions 

        private void buttonBark_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedRow.CanBark && SelectedRow.Type == AnimalType.Dog) //sender oder so nutzen zum vereinfachen der if z.b. mit switch case
                {
                    MessageBox.Show("Der Hund hat gebellt!");
                }
                else if (!SelectedRow.CanBark && SelectedRow.Type == AnimalType.Dog)
                {
                    MessageBox.Show("Der Hund kann nicht bellen!");
                }
                else
                {
                    MessageBox.Show("Dieses Tier ist kein Hund!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }

        private void buttonBite_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedRow.CanBite && SelectedRow.Type == AnimalType.Dog)
                {
                    MessageBox.Show("Der Hund hat gebissen!");
                }
                else if (!SelectedRow.CanBite && SelectedRow.Type == AnimalType.Dog)
                {
                    MessageBox.Show("Dieser Hund beißt nicht!");
                }
                else
                {
                    MessageBox.Show("Diese Tier ist kein Hund!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }

        private void buttonLayEgg_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedRow.CanLayEgg && SelectedRow.Type == AnimalType.Chicken)
                {
                    MessageBox.Show("Das Huhn hat ein Ei gelegt!");
                }
                else if (!SelectedRow.CanLayEgg && SelectedRow.Type == AnimalType.Chicken)
                {
                    MessageBox.Show("Dieses Huhn kann keine Eier legen!");
                }
                else
                {
                    MessageBox.Show("Diese Tier ist kein Huhn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + " - " + ex.Source);
            }
        }
        #endregion
    }
}
