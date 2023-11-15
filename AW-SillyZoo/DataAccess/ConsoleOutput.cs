using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_SillyZoo.DataAccess
{
    public class ConsoleOutput : IWrite
    {
        public void WriteString(string text)
        {
            Console.WriteLine(text);
        }
    }
}
