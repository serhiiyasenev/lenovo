using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tiger smallTiger = new Tiger("smallTiger");

            //Console.WriteLine("--------------------");

            //ColorTiger colorTiger = new ColorTiger(ColorTigerType.Gold);

            //Console.WriteLine("--------------------");

            //Tiger newTiger = new ColorTiger(ColorTigerType.White);
            //Console.WriteLine("--------------------");
            //Tiger newTiger2 = new Tiger("usual Tiger");
            //Console.WriteLine("--------------------");
            //Console.WriteLine((newTiger as ColorTiger).ColorTigerType);
            //// Console.WriteLine((newTiger2 as ColorTiger).ColorTigerType); error

            // Tiger bbbb = colorTiger;

            // Animal aaaaAnimal = colorTiger;

            // Console.WriteLine("--------------------");
            // //ColorTiger colorTiger3 = (ColorTiger)smallTiger;  if smallTiger is not ColorTiger --> System.InvalidCastException

            // ColorTiger colorTiger3 = null as ColorTiger; // if smallTiger is not ColorTiger --> return null

            // Console.WriteLine(smallTiger is Animal);
            // Console.WriteLine(smallTiger is Tiger);
            // Console.WriteLine(smallTiger is ColorTiger);
            // Console.WriteLine(colorTiger3 is ColorTiger);
            //Console.WriteLine("--------------------");

            //smallTiger.Move();
            //(smallTiger as Animal).Move();


            //smallTiger.Jump();
            //(smallTiger as Animal).Jump();

            //smallTiger.Swimming();
            //(smallTiger as Animal).Swimming();


            Zoo BeautifulZoo = new Zoo();
            BeautifulZoo.OnAnimalAdded = Test;

            BeautifulZoo.Add(new Tiger("Tiger1"));
            BeautifulZoo.Add(new ColorTiger(ColorTigerType.Gold, "ColorTiget1"));
            BeautifulZoo.Add(new Tiger("Tiger2"));
            Console.WriteLine("-----------------------");
            BeautifulZoo.Sort();
            Console.WriteLine("-----------------------");
            BeautifulZoo.Show();
            Console.WriteLine("-----------------------");
            Console.WriteLine(BeautifulZoo["Tiger1"].Name);
            Console.WriteLine("-----------------------");
            Console.WriteLine(BeautifulZoo.GetAll(typeof(Tiger)).Count);
            Console.WriteLine(BeautifulZoo.GetAll(typeof(ColorTiger)).Count);
            Console.WriteLine(BeautifulZoo.GetAll(typeof(Animal)).Count);
            Console.WriteLine("-----------------------");

            Console.ReadKey();

        }

        public static void Test(Animal animal)
        {
            Console.WriteLine($"Delegate Test Message: it was added Animal with type {animal.GetType()}");
        }
    }
}
