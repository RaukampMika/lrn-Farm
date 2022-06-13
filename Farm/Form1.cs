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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
