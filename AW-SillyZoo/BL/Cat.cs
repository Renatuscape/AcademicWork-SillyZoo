using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.BL
{
    internal class Cat : Mammal
    {
        public Cat(string speciesName) : base(speciesName)
        {
            Description = Description + $" - I am a cute and fluffy murder-machine!";
        }

        public override string Talk()
        {
            return $" - Meow! Meow, mrrow, mwa!";
        }

        public override string Move()
        {
            return $" * {Name} pounces around, chasing a ball of yarn *";
        }
    }
}
