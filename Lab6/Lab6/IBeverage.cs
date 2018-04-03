using System;

namespace Lab6
{
    public interface IBeverage
    {
        int GetServingTemperature(bool includesMilk);

        bool IsFairTrade { get; set; }

        event EventHandler OnSoldOut;

        string this[int index] { get; set; }

    }
}