using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct1
{
    public struct Coffee
    {
        public Coffee (int strength, string bean, string countyOfOrigin)
        {
            this.Strength = strength;
            this.Bean = bean;
            this.CountryOfOrigin = countyOfOrigin;
            e = null;
            currentStockLevel = 0;
            minimumStockLevel = 0;
            OutOfBeans = null;
        }

        public int Strength;
        public string Bean;
        public string CountryOfOrigin;

        // Задання події та делегата.
        public EventArgs e;
        public delegate void OutOfBeansHandler(Coffee coffee, EventArgs args);
        public event OutOfBeansHandler OutOfBeans;
        int currentStockLevel;
        int minimumStockLevel;

        public void MakeCoffee()
        {
            // Зменшення рівня запасу.
            currentStockLevel--;
            // Якщо рівень запасу опускається нижче мінімума, ми спричиняємо подію.
            if (currentStockLevel < minimumStockLevel)
            {
                // Перевірка події на null.
                if (OutOfBeans != null)
                {
                    // Спричинення події.
                    OutOfBeans(this, e);
                }
            }
        }
    }
}
