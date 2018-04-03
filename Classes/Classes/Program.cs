using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Person p1 = Person.GenerateRandomPerson();
                Console.WriteLine("Name: " + p1.Name);
                Console.WriteLine("Age: " + p1.Age);
                Console.WriteLine("Counter: " + Person.Count);
                p1.Move();
                Console.WriteLine("--------------------");
            }
            Console.Read();
        }
    }
}