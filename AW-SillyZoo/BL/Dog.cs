using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.BL
{
    internal class Dog : Mammal
    {
        public Dog(string speciesName) : base(speciesName)
        {
            Description = Description + $" - I am loyal and fun to play with.";
        }

        public override string Talk()
        {
            return $" - Woof! Ruff ruff, yip yip!";
        }

        public override string Move()
        {
            return $" * {Name} carries a stick around until it finds somewhere to bury it *";
        }
    }
}
