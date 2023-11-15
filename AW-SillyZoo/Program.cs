

using AW_SillyZoo.BL;
using AW_SillyZoo.DataAccess;

namespace AW_SillyZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FancyConsoleOutput outputWriter = new();
            Zoo sillyZoo = new("Silly Zoo");
            sillyZoo.animals = new()
            {
                new Cat("Jimmy"),
                new Dog("Ricola"),
                new Hawk("Steward"),
                new Bat("Molly"),
                new Penguin("Pingu")
            };

            outputWriter.WriteString(sillyZoo.ZooInfo());
        }
    }
}