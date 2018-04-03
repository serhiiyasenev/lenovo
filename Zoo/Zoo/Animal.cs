using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
           // Console.WriteLine($"Create a new Animal with name {Name}");
        }

        public void Move()
        {
            Console.WriteLine($"Animal with name: {Name} is moving");
        }

        public virtual void Jump()
        {
            Console.WriteLine($"Animal with name: {Name} is jumping");
        }

        public abstract void Swimming();
    }

    public class Tiger : Animal
    {
        public Tiger(string name = "Tiger")
            : base(name)
        {
            // Console.WriteLine($"Create a new Tiger with name {Name}");
            Weight = 120;
        }
        public new void Move()
        {
            Console.WriteLine($"Tiger with name: {Name} is moving very fast");
        }

        public override void Jump()
        {
            Console.WriteLine($"Tiger with name: {Name} is jumping very hight");
        }

        public override void Swimming()
        {
            Console.WriteLine($"Tiger with name: {Name} is swimming well");
        }
    }

    public enum ColorTigerType
    {
        White,
        Gold,
        Other
    }

    public class ColorTiger : Tiger
    {
        public ColorTigerType ColorTigerType { get; set; }

        public ColorTiger(ColorTigerType colorTigerType, string Name = "ColorTiger1")
            :base(Name)
        {
            ColorTigerType = colorTigerType;
            Weight = 70;
           // Console.WriteLine($"Create a new ColorTiger with Name: {Name} and Color: {ColorTigerType}");
        }

    }
}