using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Coffee : IBeverage
    {
        private int servingTempWithoutMilk { get; set; }

        private int servingTempWithMilk { get; set; }

        int IBeverage.GetServingTemperature(bool includesMilk)
        {
            if (includesMilk)
            {
                return servingTempWithMilk;
            }
            else
            {
                return servingTempWithoutMilk;
            }
        }

        bool IBeverage.IsFairTrade { get; set; }
        public event EventHandler OnSoldOut;

        public string this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
