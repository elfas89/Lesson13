using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson12;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            FridgeModes c = FridgeModes.north;
            Console.WriteLine(c);
            Fridge z = new Fridge(true, FridgeModes.south);
        }
    }
}
