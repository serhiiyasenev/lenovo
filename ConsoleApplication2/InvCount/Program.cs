using System;

namespace InvCount
{
    public class InvCount
    {
        public static void Main()
        {
            Count();
            Console.ReadKey();
        }

        public static void Count()
        {
            var myArray = new[] {5, 4, 10, 8};
            long inversionsCount = 0;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        inversionsCount++;
                    }
                }
            }
            Console.Write($"{inversionsCount}");
        }

    }
}