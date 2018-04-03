using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testList = new List<string>();
            testList.Add("line1");
            testList.RemoveAt(0);
            testList.Remove("line1");
        }
    }
}
