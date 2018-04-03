using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] a = { { 1, 2, 3, 4, 5 }, { 5, 4, 3, 2, 1 }, { 10, 11, 12, 13, 14 } };
            int mul = 5;
            PrintArray(a);
            Console.WriteLine("------------------------");
            PrintArray(MulArray(a, mul), '|');
            Console.WriteLine("------------------------");
            int i = 3;
            Console.WriteLine("i = "+i);
            AddInt(ref i);
            Console.WriteLine(value: "------------------------");
            Console.WriteLine("i = "+i);
            Console.ReadKey();
        }

        static void AddInt(ref int i)
        {
            i++;
        }

        static int[,] MulArray(int[,] a, int mul)
        {
            int[,] res = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    res[i, j] = a[i, j] * mul;
                }
            }
            return res;
        }

        static void PrintArray(int[,] a, char separator = ' ')
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}{separator}");
                }
                Console.WriteLine();
            }
        }
    }
}