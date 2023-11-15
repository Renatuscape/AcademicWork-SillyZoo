using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.BL
{
    internal class Penguin : Bird
    {
        public Penguin(string speciesName) : base(speciesName)
        {
            Description = Description + $" - I can't fly, but I am a good swimmer!";
        }
    }
}
