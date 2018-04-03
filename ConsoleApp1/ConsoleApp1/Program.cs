using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            int a = NewMethod1();
            int b = NewMethod();
            Sum(a, b);

        }

        private static int NewMethod1()
        {
            return 22;
        }

        private static int NewMethod() => 33;

        public static void Sum(int i0, int i1)
        {
            Console.WriteLine(i0 + i1);
            Console.ReadKey();
        }
    }

}