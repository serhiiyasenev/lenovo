using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 7, 9 };
            Console.WriteLine("Ищем -1: {0}", BinarySearch(a, -1));
            Console.WriteLine("Ищем  3: {0}", BinarySearch(a, 3));
            Console.WriteLine("Ищем  6: {0}", BinarySearch(a, 6));
            Console.WriteLine("Ищем  9: {0}", BinarySearch(a, 9));
            Console.WriteLine("Ищем 20: {0}", BinarySearch(a, 20).HasValue);
            Console.ReadLine();
        }

        /// <summary>
        /// Бинарный поиск в отсортированном массиве.
        /// </summary>
        /// <param name="a">Отсортированный по возрастанию массив типа int[]</param>
        /// <param name="x">Искомый элемент.</param>
        /// <returns>Возвращает индекс искомого элемента либо null, если элемент не найден.</returns>
        private static int? BinarySearch(int[] a, int x)
        {
            // Проверить, имеет ли смыл вообще выполнять поиск:
            // - если длина массива равна нулю - искать нечего;
            // - если искомый элемент меньше первого элемента массива, значит, его в массиве нет;
            // - если искомый элемент больше последнего элемента массива, значит, его в массиве нет.
            if ((a.Length == 0) || (x < a[0]) || (x > a[a.Length - 1]))
                return null;

            // Приступить к поиску.
            // Номер первого элемента в массиве.
            int first = 0;
            // Номер элемента массива, СЛЕДУЮЩЕГО за последним
            int last = a.Length;

            // Если просматриваемый участок не пуст, first < last
            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (x <= a[mid])
                    last = mid;
                else
                    first = mid + 1;
            }

            // Теперь last может указывать на искомый элемент массива.
            if (a[last] == x)
                return last;
            else
                return null;
        }
    }
}