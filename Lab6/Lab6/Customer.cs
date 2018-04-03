using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Customer : ILoyaltyCardHolder
    {
        private int totalPoints;

        public int TotalPoints
        {
            get { return totalPoints; }
        }

        public int AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            return totalPoints += points;
           // return totalPoints;
        }

        public void ResetPoints()
        {
            totalPoints = 0;
        }
    }
}