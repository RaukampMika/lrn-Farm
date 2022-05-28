using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    interface IDog : IAnimal
    {
        bool CanBark { get; set; }
        bool CanBite { get; set; }
    }
}
