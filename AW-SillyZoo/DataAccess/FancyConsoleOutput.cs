using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.DataAccess
{
    public class FancyConsoleOutput : IWrite
    {
        public void WriteString(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t" + text.Replace("\n", "\n\t"));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
