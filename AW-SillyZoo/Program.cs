

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
                new Dog("Ricola")
            };

            outputWriter.WriteString(sillyZoo.ZooInfo());
        }
    }
}