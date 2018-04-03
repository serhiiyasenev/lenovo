using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var anAnnonymousObject = new {Name = "Tom", Age = 65};
            var secondAnnonymousObject = new {Name = "Helen", Age = 46};
            Console.WriteLine("Name: {0} Age: {1}", anAnnonymousObject.Name, anAnnonymousObject.Age);
            Console.WriteLine("-----------------");
            Console.WriteLine("Name: {0}; Age: {1}", secondAnnonymousObject.Name, secondAnnonymousObject.Age);

            Manager IdealManager = new Manager();
            IdealManager.EmpNumber = "Ivan";
            IdealManager.Address = anAnnonymousObject.Age.ToString();
            IdealManager.FirstName = secondAnnonymousObject.Name;
            IdealManager.LastName = anAnnonymousObject.Name;

            Coffee coffee1 = new Coffee();
            IBeverage coffee2 = new Coffee();
            IBeverage beverage = coffee1;
            Coffee coffee3 = beverage as Coffee;
            Coffee coffee4 = (Coffee) beverage;

            Console.ReadKey();
        }
    }
}