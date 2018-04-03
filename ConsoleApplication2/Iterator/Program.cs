using System;
using System.Collections.Generic;

namespace Iterator
{
    public class RemoveElement
    {
        public static void Main(string[] args)
        {
            var col = new List<string> {"1s", "2asa", "3aaa", "4aaa", "5", "6", "7"};
            foreach (var entry in col)
            {
                Console.Write(entry + ", ");
            }
            Console.WriteLine("\n" + "------------------");

            var iter = col.GetEnumerator();
            while (iter.MoveNext())
            {
                var s = iter.Current;
                if (s != null && s.Contains("s"))
                {
                    col.Remove(s);
                    iter = col.GetEnumerator();

                }
            }
                var iterNew = col.GetEnumerator();
                while (iterNew.MoveNext())
                {
                    Console.WriteLine(iterNew.Current);
                }
            Console.WriteLine("------------------");
            foreach (var entry in col)
                {
                    Console.Write(entry + ", ");
                }

            Console.ReadKey();
        }
    }
}