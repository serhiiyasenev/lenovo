using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Add("Ahmatova", 172);
            library.Add("Idiot", 875);
            library.Show();
            Console.WriteLine("Count: " + library.Count);
            library.Remove("Idiot");
            library.Remove(10);
            library.Sort();
            library.Show();
            Console.WriteLine("Count: " + library.Count);
            Console.Read();
        }
    }
}
