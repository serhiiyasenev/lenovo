using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Lab6;
using static System.String;

namespace Lab7
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> versions = new List<string>()
            {
                "8.0.1", "6.6.0", "2.5.4", "4.6.0", "3.5.3", "5.7.2",
                "0.4.7", "6.7.1", "7.9.6", "9.9.9", "3.1.2", "2.7.0",
                "1.8.2", "4.4.1", "8.1.3", "5.0.2", "2.0.4", "1.4.0",
                "6.2.2", "9.8.7", "3.2.6", "4.0.4", "8.0.7", "3.4.9",
                "9.6.0", "5.7.6", "8.2.9", "3.6.8", "5.2.7", "1.6.5",
                "7.1.9", "5.1.1", "5.4.0", "8.7.9", "5.8.6", "5.1.8",
                "0.0.5", "6.0.6", "7.9.6", "8.9.8", "7.7.4", "2.6.2",
                "9.4.4", "8.0.3", "5.0.4", "0.8.8", "1.9.0", "9.0.6",
                "9.0.1", "3.7.1", "5.7.4", "2.1.0", "5.3.2", "4.6.7",
                "3.1.0", "2.1.0", "1.7.1", "7.6.9", "7.7.6", "7.2.5",
                "0.6.6", "3.3.2", "8.2.8", "4.4.4", "5.6.3", "3.5.9",
                "6.7.9", "1.1.0", "9.7.0", "4.4.3", "3.7.0", "6.4.9",
                "0.9.7", "7.3.8", "1.6.3", "6.2.0", "6.4.1", "7.1.5",
                "6.9.5", "6.3.6", "2.3.7", "4.1.6", "3.9.2", "3.3.6",
                "1.8.3", "0.9.4", "7.2.5", "0.8.0", "1.5.6", "5.9.4",
                "4.3.6", "0.5.0", "0.7.5", "6.2.2", "8.2.1", "5.6.2",
                "1.6.0", "0.9.1", "1.2.4", "7.2.5", "0.8.0", "7.9.9",
                "0.0.3", "2.9.1", "8.0.9", "2.2.6", "9.6.9", "3.3.2",
                "4.3.3", "5.9.3", "5.3.4", "0.5.4", "1.0.3", "1.5.5",
                "9.9.7", "8.2.8", "1.8.9", "8.8.6", "6.6.4", "7.3.5",
                "5.4.1", "0.7.5", "7.8.5", "5.0.1", "3.7.0", "3.4.4",
                "5.5.1", "4.3.0", "3.7.5", "8.3.8", "0.4.6", "7.5.0",
                "4.8.2", "1.1.3", "3.6.8", "8.5.0", "6.2.2", "0.1.8",
                "3.0.1", "0.7.9", "0.9.4", "6.4.6", "5.5.1", "9.8.6",
                "2.4.4", "8.1.7", "2.4.1", "5.2.1", "6.0.2", "8.3.5",
                "9.4.1", "2.0.2", "8.7.1", "1.3.9", "8.6.3", "6.7.7",
                "4.5.9", "3.8.2", "8.5.7", "3.9.4", "3.6.1", "6.0.4",
                "4.9.3", "2.9.3", "6.0.1", "1.6.5", "7.0.2", "4.4.8",
                "5.6.5", "8.4.5", "4.5.7", "6.8.6", "8.2.5", "9.1.7",
                "4.1.5", "6.7.7", "0.6.8", "1.5.8", "2.8.2", "3.1.4",
                "8.6.5", "7.7.4", "6.9.2", "5.3.4", "9.8.9", "4.0.2",
                "2.9.8", "8.7.7", "6.3.0", "8.4.9", "4.4.1", "1.1.4",
                "1.6.4", "1.0.7", "5.5.3", "4.1.6", "9.7.7", "9.1.2", "5.0.8", "8.0.3" };

            List<string> CompareVersionsFromList(List<string> verList)
            {
                var tempArray = verList.ToArray();
                for (int j = 0; j < tempArray.Length; j++)
                {
                    for (int i = 0; i < tempArray.Length - 1; i++)
                    {
                        var result = Compare(tempArray[i], tempArray[i + 1], new CultureInfo("en-US"),
                            CompareOptions.None);

                        if (result > 0)
                        {
                            var temp = tempArray[i];
                            tempArray[i] = tempArray[i + 1];
                            tempArray[i + 1] = temp;
                        }

                        else if (result == 0)
                        {
//                            tempArray[i] = tempArray[i]+ " - DUPLICATE";
                          var tempList = tempArray.ToList();
                            tempList.RemoveAt(i);
                            tempArray = tempList.ToArray();
                        }
                    }
                }
                return tempArray.ToList(); 
            }

            Console.WriteLine("MIN: " + versions.Min());
            Console.WriteLine("MAX:" + versions.Max());
            Console.WriteLine("COUNT: " + versions.Count);
            Console.WriteLine("--------------------------");

            versions = CompareVersionsFromList(versions);

            foreach (var version in versions)
            {
                Console.WriteLine(version);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("MIN: " + versions.Min());
            Console.WriteLine("MAX:" + versions.Max());
            Console.WriteLine("COUNT: " + versions.Count);
            Console.WriteLine("--------------------------");

            List<string> list1 = SortNew.CompareVersionsFromList(versions);

            foreach (var version in list1)
            {
                Console.WriteLine(version);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("MIN: " + list1.Min());
            Console.WriteLine("MAX:" + list1.Max());
            Console.WriteLine("COUNT: " + list1.Count);

            Console.ReadKey();
        }
    }
}