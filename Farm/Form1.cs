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
        private List<Dog> NewDog { get; set; }
        public Form1()
        {
            NewFarm = SpawnAnimals();
            InitializeComponent();
        }
        private List<Animal> SpawnAnimals()
        {
            var animals = new List<Animal>();

            var _rex = new Dog("Rex", 10, 4, true, false, true);
            var _lessie = new Dog("Lessie", 8, 4, true, true, false);

            var _inge = new Chicken("Inge", 2, 2, false, true);

            animals.Add(_rex);
            animals.Add(_lessie);
            animals.Add(_inge);

            return animals;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var newFarm = this.NewFarm;
            dataGridView1.DataSource = newFarm;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
