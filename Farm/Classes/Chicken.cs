using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm
{
    class Chicken : Animal, IChicken
    {
        private string _name;
        public Chicken(string name, int age, int numberLegs, bool hasTail, bool canLayEgg) 
            : base(name, age, numberLegs, hasTail)
        {
            Name = name;
            Age = age;
            NumberLegs = numberLegs;
            HasTail = hasTail;
            CanLayEgg = canLayEgg;
        }
        public bool CanLayEgg { get; set; }
    }
}
