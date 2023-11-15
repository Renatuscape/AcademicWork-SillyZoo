using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.BL
{
    internal abstract class Mammal : Animal
    {
        public Mammal(string speciesName) : base(speciesName)
        {
            Description = Description + $" - I am a mammal, so I feed my young with milk.\n";
        }
    }
}
