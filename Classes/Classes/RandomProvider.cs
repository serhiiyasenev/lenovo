using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class RandomProvider
    {
        private static Random rnd = new Random();

        public static Random Random => rnd;
    }
}
