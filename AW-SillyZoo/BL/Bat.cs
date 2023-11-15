using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.BL
{
    internal class Bat : Mammal, IFly
    {
        public Bat(string speciesName) : base(speciesName)
        {
            Description = Description + $" - I have bad eyesight and navigate with echolocation.";
        }

        public override string Talk()
        {
            return $" - Aaaaaaaaaa!";
        }

        public override string Move()
        {
            return $" * {Name} scrabbles along the ground like an adorable nightmare demon *";
        }

        public string Fly()
        {
            return $" * {Name} flaps away on membranous wings *";
        }

        public override string AnimalToString()
        {
            return base.AnimalToString() + Fly() + "\n";
        }
    }
}
