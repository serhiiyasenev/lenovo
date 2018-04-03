using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class SortNew
    {
        public static List<string> CompareVersionsFromList(List<string> versions)
        {
            versions.Sort();
            versions = versions.Distinct().ToList();
            return versions;
        }
    }
}