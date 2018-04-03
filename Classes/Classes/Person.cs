using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class PersonDictionary
    {
        public static List<string> GetArray()
        {
            return new List<string>(
                new string[] 
                {
                    "Max", "Dima", "Alex", "Petro", "Stepan"
                });
        }
    }

    public class Person
    {
        private string _name = "Ivan";

        private int _age = 25;

        public static int Count;

        public Person()
        {
            //Count++;
            Count+=2; 
        }

        public Person(string Name, int Age)
        {
            _name = Name;
            _age = Age;
            Count += 2;
        }

        public string Name => _name;

        public int Age
        {
            get
            {
                return _age;
            }
           set
            {
                if (value<0 || value > 200)
                {
                    throw new ArgumentException();
                }
                _age = value;
            }
        }

        public static Person GenerateRandomPerson()
        {
            Person randomPerson = new Person();
            Random rnd = RandomProvider.Random;
            randomPerson.Age = rnd.Next(1, 199);
            var List = PersonDictionary.GetArray();
            randomPerson._name = List[rnd.Next(List.Count)];
            return randomPerson;
        }

        public void Move()
        {
            Console.WriteLine(this._name + " is moving to ...");
        }
    }
}
