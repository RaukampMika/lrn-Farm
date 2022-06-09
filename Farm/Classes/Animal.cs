using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm
{
    class Animal : IAnimal
    {
        private string _name;

        public Animal(string name, int age, int numberLegs, bool hasTail)
        {
            Name = name;
            Age = age;
            NumberLegs = numberLegs;
            HasTail = hasTail;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (_name.Length > 12)
                {
                    MessageBox.Show("Name des Tieres zu lang!");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int Age { get; set; }
        public int NumberLegs { get; set; }
        public bool HasTail { get; set; }
    }
}
