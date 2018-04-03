using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee1 = new Coffee();
            coffee1.Strength = 1;
            coffee1.Bean = "Ukraine";
            coffee1.CountryOfOrigin = "Brazil";

            Coffee coffee4 = new Coffee(4, "Arabica", "Kenya");

            Coffee1 coffee11 = new Coffee1();
            coffee11.Strengrh1 = 2222; // it's more than 5
            int xx = coffee11.Strengrh1; // it should be 5 according to "set logic"

            Menu menu1 = new Menu("Juice", "Milk");

            Console.WriteLine(coffee1.CountryOfOrigin);
            Console.WriteLine(coffee4.Bean);
            Console.WriteLine(xx);
            Console.WriteLine("---------------------");
            foreach (string coffee in menu1.beverages)
            {
                Console.WriteLine(coffee);
            }
            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}