using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray1 = { 11, 12, 15, 22, 55, 9, 5, 6, 7};
            Sort(intArray1);
            Console.ReadKey();
        }

        public static void Sort(int [] intArray)
        {
            int i = 0, j = 0;
            for (j=0; j< intArray.Length; j++)
            {
                for (i = 0; i< intArray.Length-1; i++)
                {

                    if (intArray[i] > intArray[i+1])
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[i+1];
                        intArray[i+1] = temp;
                    }
                }
            }
            foreach (int element in intArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
