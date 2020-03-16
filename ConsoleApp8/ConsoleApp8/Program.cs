using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            string space = " ";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    result = i*j;
                    if (result.ToString().Length < 2)
                        space = "  ";
                    else
                    space = " ";
                    Console.Write(result + space);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
