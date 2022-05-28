using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm.Classes
{
    class Chicken : IChicken
    {
        private string _name;
        public Chicken(string name, int age, int numberLegs, bool hasTail, bool canLayEgg)
        {
            Name = name;
            Age = age;
            NumberLegs = numberLegs;
            HasTail = hasTail;
            CanLayEgg = canLayEgg;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name.Length > 12)
                {
                    MessageBox.Show("Name des Huhns zu lang!");
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
        public bool CanLayEgg { get; set; }
    }
}
