using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck JohnDuck = new Duck();

            JohnDuck.Name = "John";
            JohnDuck.Color = "Black";
            JohnDuck.Life = 2;

            Duck GeorgeDuck = new Duck("George", "Blue", 1);

            JohnDuck.Fly("Kiev");
            GeorgeDuck.Fly("Lviv");
            Console.ReadKey();
        }
    }
}
