using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }

            
            foreach (int b in a)
            {
                Console.WriteLine(b);
            }
            Console.Read();

            string[,] s1 = new string[5, 5];
            string p = s1[0, 0];
            string[][] s2 = new string[5][];
            s2[0] = new string[2];
            int s2Length = s2[0].Length;
            int s1Length = s1.Length;

            string ff1 = "aaaaaaaaaaaaffff";
            Console.WriteLine(ff1[11]);
            Console.Read();
        }
    }
}
