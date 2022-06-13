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
        public Dog(string type, string name, int age, int numberLegs, bool hasTail, bool canBark, bool canBite, bool canLayEgg) 
            :base(type, name, age, numberLegs, hasTail, canBark ,canBite, canLayEgg)
        {
            Name = name;
            Age = age;
            NumberLegs = numberLegs;
            HasTail = hasTail;
            CanBark = canBark;
            CanBite = canBite;
            CanLayEgg = false;
        }
    }
}
