using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using static System.String;

namespace ConsoleApplication2
{
    public class CompareMethod
    {
        public static string CompareVersions(string string1, string string2)
        {
            string relation;
            var result = Compare(string1, string2, new CultureInfo("en-US"), CompareOptions.None);

            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            var order = string1 + " " + relation + " " + string2;
            return order;
        }
    }
}