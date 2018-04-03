using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    public class Conversions
    {
        public static double PoundsToKilos(double pounds)
        {
            // фунти в кілограми 
            double kilos = pounds * 0.4536;
            return kilos;
        }

        public static double KilosToPounds(double kilos)
        {
            // кілограми в фунти 
            double pounds = kilos * 2.205;
            return pounds;
        }
    }
}
