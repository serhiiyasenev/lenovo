using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine
{
    class Class1
    {
        public static void Main (string[] args)
        {
            DrinksMachine machine = new DrinksMachine("cs50", "Japan")
            {
                Location = "Tokyo"
            };

            string x1 = machine.Location;
            machine.Location = "Tokyo+1";

            string x2 = machine.Make;
            string x3 = machine.Model;

            Console.WriteLine("Location: " + x1 + " | made: " + x2 + " | model:" + x3 + " | ");

            Console.ReadKey();

        }
    }
}
