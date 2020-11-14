using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Object();
            var b = a;

            bool aa = a.Equals(b);
            bool bb = b.Equals(a);
            bool ab = Object.Equals(a, b);
            bool ba = Object.Equals(b, a);
            bool cc = object.ReferenceEquals(a, b);
            bool dd = object.ReferenceEquals(b, a);

            var list = new List<bool> { aa, bb, ab, ba, cc, dd};

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());

            }


            Console.Read();
        }
    }
}
