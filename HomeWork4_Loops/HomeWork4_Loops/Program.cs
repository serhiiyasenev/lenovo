using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            i = i++;
            Console.WriteLine(i + ++i);
            //11
            i = 2;
            i = (++i + ++i) * (i++);
            Console.WriteLine(i);
            //28
            i = 10;
            i = ++i + (i--) + (i++) + (--i) - (i++);
            Console.WriteLine(i);
            //32
            i = 12;
            i = (i++ + (--i) - (i++)) / (--i);
            Console.WriteLine(i);
            //1
            i = 4;
            i = i++ + (--i) - (i--) * (i++);
            Console.WriteLine(i);
            //-4
            Console.ReadKey();
        }
    }
}
