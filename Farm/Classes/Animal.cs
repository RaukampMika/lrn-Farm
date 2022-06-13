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
        private bool _canBark;
        private bool _canBite;

        public Animal(string type, string name, int age, int numberLegs, bool hasTail, bool canBark, bool canBite, bool canLayEgg)
        {
            Type = type;
            Name = name;
            Age = age;
            NumberLegs = numberLegs;
            HasTail = hasTail;
            CanBark = canBark;
            CanBite = canBite;
            CanLayEgg = canLayEgg;
        }
        public string Type { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                string _nameCheck = value;
                if (_nameCheck.Length > 12)
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
        public bool CanBark
        {
            get { return _canBark; }
            set { _canBark = value; }
        }
        public bool CanBite
        {
            get { return _canBite; }
            set
            {
                bool _canBiteCheck = value;
                if (_canBark == true && _canBiteCheck == true)
                {
                    MessageBox.Show("bellende Hunde beißen nicht!");
                }
                else
                {
                    _canBite = value;
                }

            }
        }
        public bool CanLayEgg { get; set; }
    }
}
