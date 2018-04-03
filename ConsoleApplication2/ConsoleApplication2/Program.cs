using System;
using System.Globalization;

namespace ConsoleApplication2
{
    public class Program 
    {
        public static void Main()
        {
        string string1 = "1.1.2";
        string string2 = "1.1.3";
        string relation;
        int result;


            // V1: Cultural (linguistic) comparison.
            result = String.Compare(string1, string2, new CultureInfo("en-US"), CompareOptions.None);

            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.", string1, relation, string2);
            Console.ReadLine();


            // V2: Cultural (linguistic) case-insensitive comparison.
            result = String.Compare(string1, string2, new CultureInfo("en-US"), CompareOptions.IgnoreCase);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.", string1, relation, string2);
            Console.ReadLine();


            // V3: Culture-insensitive ordinal comparison.
            result = String.CompareOrdinal(string1, string2);
            if (result > 0)
                relation = "comes after";
            else if (result == 0)
                relation = "is the same as";
            else
                relation = "comes before";

            Console.WriteLine("'{0}' {1} '{2}'.", string1, relation, string2);
            Console.ReadLine();

            // V4: ....
            Console.WriteLine("V4:");
            Console.WriteLine(CompareMethod.CompareVersions(string1, string2));
            Console.ReadLine();
        }
    }
}