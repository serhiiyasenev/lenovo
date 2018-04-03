using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine
{
    public class DrinksMachine
    {
        // Приватне поле
        private string _location;

        public DrinksMachine()
        {
        }

        // Конструктор
        public DrinksMachine(string model, string make)
        {
            Model = model;
            Make = make;
        }

        // Властивість
        public string Location
        {
            get { return _location; }
            set
            {
                if (value != null)
                    _location = value;
            }
        }

        // Властивості 
        public string Make { get; }
        public string Model { get; }
        // Оголошення методів
        public void MakeCappuccino()
        {
            // Код методу
        }

        public void MakeEspresso()
        {
            // Код методу
        }

        // Оголошення події
       // public event OutOfBeansHandler OutOfBeans;
    }
}
