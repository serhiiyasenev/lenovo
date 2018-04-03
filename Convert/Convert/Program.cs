using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
            Console.WriteLine("Вхiдна вага у фунтах - 1, у кiлограмах - 2. Введiть i натиснiть Enter:");
            int x = Int32.Parse(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Сепаратор - кома. Введiть вагу в фунтах:");
                double pounds = Double.Parse(Console.ReadLine());
                Console.WriteLine("Вага в кiлограмах: " + Conversions.PoundsToKilos(pounds));
            }
            else if (x == 2)
            {
                Console.WriteLine("Сепаратор - кома. Введiть вагу в кiлограмах:");
                double kilos = Double.Parse(Console.ReadLine());
                Console.WriteLine("Вага в фунтах: " + Conversions.KilosToPounds(kilos));
            }
            else
            {
                Console.WriteLine("Вам слiд обрати одиницi вимiру для вхiдної ваги!");
                goto label;
            }
            Console.ReadKey();
        }
    }
}