using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.BL
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Animal(string speciesName)
        {
            Name = speciesName;
            Description = $"Written on the habitat: I am {Name} the {GetType().Name.ToLower()}.\n";
        }
        public virtual string Move()
        {
            return string.Empty;
        }
        public virtual string Talk()
        {
            return string.Empty;
        }

        public string AnimalToString()
        {
            string animalInfo = $"{Description}\n{Move()}\n{Talk()}\n\n";
            return animalInfo;
        }

        public override string ToString()
        {
            return $"{Name} the {GetType().Name.ToLower()}";
        }
    }
}
