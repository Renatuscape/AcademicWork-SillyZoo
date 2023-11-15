using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.BL
{
    internal abstract class Bird : Animal
    {
        public Bird(string speciesName) : base(speciesName)
        {
            Description = Description + $" - I am a bird. I have a beak and lay eggs!\n";
        }

        public override string Move()
        {
            return $" * {this} waddles around on its two legs * ";
        }

        public override string Talk()
        {
            return $" - Noot noot!";
        }
    }
}
