using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm
{
    class Dog : IDog
    {
        private string _name;
        public Dog(string name, int age, int numberLegs, bool hasTail, bool canBark, bool canBite)
        {
            Name = name;
            Age = age;
            NumberLegs = numberLegs;
            HasTail = hasTail;
            CanBark = canBark;
            CanBite = canBite;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name.Length > 12)
                {
                    MessageBox.Show("Name des Hudes zu lang!");
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
        public bool CanBark { get; set; }
        public bool CanBite { get; set; }
    }
}
