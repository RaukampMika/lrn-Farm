using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        int NumberLegs { get; set; }
        bool HasTail { get; set; }
    }
}
