using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class InitAnimals
    {
        public List<Animal> NewFarm
        {
            get { return SpawnAnimals(); }
            set { SpawnAnimals(); }
        }
        public List<Animal> SpawnAnimals()
        {
            var animals  = new List<Animal>();

            var _rex = new Dog("Rex", 10, 4, true, false, true);
            var _lessie = new Dog("Lessie", 8, 4, true, true, false);
            animals.Add(_rex);
            animals.Add(_lessie);

            return animals;
        }
    }
}
