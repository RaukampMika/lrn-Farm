using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm
{
    class Dog : Animal, IDog
    {
        private string _name;

        public Dog(string name, int age, int numberLegs, bool hasTail, bool canBark, bool canBite) 
            :base(name, age, numberLegs, hasTail)
        {
            Name = name;
            Age = age;
            NumberLegs = numberLegs;
            HasTail = hasTail;
            CanBark = canBark;
            CanBite = canBite;
        }
        public bool CanBark { get; set; }
        public bool CanBite { get; set; }
    }
}
