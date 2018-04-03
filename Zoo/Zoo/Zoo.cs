using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public delegate void AnimalAdded(Animal animal);

    public class Zoo
    {
        private List<Animal> list;

        public AnimalAdded OnAnimalAdded;

        public Zoo()
        {
            list = new List<Animal>();
        }

        public void Add(Animal animal)
        {
            list.Add(animal);
            OnAnimalAdded?.Invoke(animal);
        }

        public void Show()
        {
            foreach (var animal in list)
            {
                Console.WriteLine(animal.Name + " " + animal.GetType());
            }
        }

        public Animal this [string Name]
        {
            get
            {
                return list.FirstOrDefault(el => el.Name == Name);
            }
        }

        //public List<Animal> GetAll(Type type)
        //{
        //    return list.Where(el => el.GetType() == type).ToList();
        //}

        public List<Animal> GetAll(Type type) => list.Where(el => el.GetType() == type).ToList();

        public void Sort()
        {
           list = list.OrderBy(el => el.Weight).ToList();
            Console.WriteLine("Sorted!");
        }
    }
}
