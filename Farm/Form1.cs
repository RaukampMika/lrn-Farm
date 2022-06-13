using Farm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm
{
    public partial class Form1 : Form
    {
        private List<Animal> NewFarm { get; set; }
        public Form1()
        {
            NewFarm = SpawnAnimals();
            InitializeComponent();
        }
        private List<Animal> SpawnAnimals()
        {
            var animals = new List<Animal>();

            var _rex = new Dog("Dog", "Rex", 10, 4, true, false, true, false);
            var _lessie = new Dog("Dog", "Lessie", 8, 4, true, true, false, false);

            var _inge = new Chicken("Chicken", "Inge", 2, 2, false, false, false, true);
            var _bernd = new Chicken("Chicken", "Bernd", 3, 2, false, false, false, false);

            var _roland = new Animal("Unknown", "Roland", 4, 6, false, false, false, false);

            animals.Add(_rex);
            animals.Add(_lessie);
            animals.Add(_inge);
            animals.Add(_bernd);
            animals.Add(_roland);

            return animals;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var newFarm = this.NewFarm;
            dataGridView1.DataSource = newFarm;
            renameColumns();
        }

        private void renameColumns()
        {
            dataGridView1.Columns[0].HeaderText = "Gattung";
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
                var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Animal;
                //sMessageBox.Show("Selected Row " + selectedRow);
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
                var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Animal;
                if (selectedRow.CanBark && selectedRow.Type == "Dog")
                {
                    MessageBox.Show("Der Hund hat gebellt!");
                }
                else if (!selectedRow.CanBark && selectedRow.Type == "Dog")
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
                var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Animal;
                if (selectedRow.CanBite && selectedRow.Type == "Dog")
                {
                    MessageBox.Show("Der Hund hat gebissen!");
                }
                else if (!selectedRow.CanBite && selectedRow.Type == "Dog")
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
                var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Animal;
                if (selectedRow.CanLayEgg && selectedRow.Type == "Chicken")
                {
                    MessageBox.Show("Das Huhn hat ein Ei gelegt!");
                }
                else if (!selectedRow.CanLayEgg && selectedRow.Type == "Chicken")
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
