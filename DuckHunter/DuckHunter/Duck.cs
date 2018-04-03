using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunter
{
    class Duck
    {
        public Duck()
        {

        }

        public string Color;
        public string Name;
        public int Life;

        public Duck(string color, string name, int life)
        {
            this.Color = color;
            this.Name = name;
            this.Life = life;
        }

        public void Fly (string place)
        {
            Console.WriteLine("I'm flying to " + place + ". My name is " + Name + ". The number of life is " + Life);
        }
    }
}