using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.BL
{
    internal class Hawk : Bird, IFly
    {
        public Hawk(string speciesName) : base(speciesName)
        {
            Description = Description + $" - I am a fast hunter, an expert swooper!";
        }

        public string Fly()
        {
            return $" * {this} takes off with an impressive wingspan and circles its pen * ";
        }

        public override string Talk()
        {
            return $" - Screee!";
        }

        public override string AnimalToString()
        {
            return base.AnimalToString()+Fly()+"\n";
        }
    }
}
