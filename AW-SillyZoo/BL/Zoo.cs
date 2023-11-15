namespace AW_SillyZoo.BL
{
    internal class Zoo
    {
        public string ZooName { get; set; }
        public List<Animal> animals = new();

        public Zoo(string zooName)
        {
            ZooName = zooName;
        }

        public string ZooInfo()
        {
            var zooString =  $"Welcome to {ZooName}! Here are our animals:" +
                           $"\n___________________________________________\n";
            foreach (Animal animal in animals)
            {
                zooString += animal.AnimalToString()+"\n";
            }

            return zooString;
        }
    }
}
