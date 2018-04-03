using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab5
{
    public class Cat
    {
        public Cat(string name1, Cat._gender gender)
        {

        }
        private  enum _gender { Male, Female };

        public string Gender { get; }

        private string name = "Ivan";
        private double _energy;
        private static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyGain = 0.5;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public double Energy
        {
            get { return _energy; }
            set
            {
                if (value < MinEnergy)
                {
                    throw new Exception("Not enough energy to jump");
                }
                else if (value > MaxEnergy)
                {
                    _energy = MaxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }
    }



    public class Program
    {
        public static void Main(string[] args)
        {
            var faradayTheCat = new Cat("Faraday", Cat.Gender.Male);
            var adaTheCat = new Cat("Ada", Cat.Gender.Female);

            PrintCatInfo(faradayTheCat);
            PrintCatInfo(adaTheCat);

            faradayTheCat.Jump();
            PrintCatInfo(faradayTheCat);
            for (var i = 0; i < 40; i++)
            {
                try
                {
                    faradayTheCat.Jump();
                    PrintCatInfo(faradayTheCat);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(i);
                    break;
                }
            }
            PrintCatInfo(adaTheCat);
            PrintCatInfo(faradayTheCat);
            for (var i = 0; i < 4; i++)
            {
                faradayTheCat.Sleep();
                PrintCatInfo(faradayTheCat);
            }
            PrintCatInfo(adaTheCat);
            adaTheCat.Sleep();
            PrintCatInfo(adaTheCat);
            PrintCatClassInfo();
        }

        private static void PrintCatInfo(Cat cat)
        {
            Console.WriteLine($"{cat.Name}, {cat.Gender}, {cat.Energy}");
            Console.WriteLine($"{typeof(Cat).GetField("_energy", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(cat)}");
        }

        private static void PrintCatClassInfo()
        {
            var catType = typeof(Cat);
            var props = catType.GetProperties();
            var fields = catType.GetFields().Concat(catType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)).ToArray();
            var constructors = catType.GetConstructors();
            var methods = catType.GetMethods();

            var sortLambda =
                new Func<MemberInfo, MemberInfo, int>(
                    (first, second) =>
                            String.Compare(first.Name, second.Name, StringComparison.Ordinal));
            Array.Sort(props, sortLambda.Invoke);
            Array.Sort(fields, sortLambda.Invoke);
            Array.Sort(constructors, sortLambda.Invoke);
            Array.Sort(methods, sortLambda.Invoke);
            foreach (var propertyInfo in props)
            {
                Console.WriteLine(
                    $"{propertyInfo.Name}, {propertyInfo.PropertyType}, {propertyInfo.CanRead}, {propertyInfo.CanWrite}");
            }
            foreach (var fieldInfo in fields)
            {
                Console.WriteLine(
                    $"{fieldInfo.Name}, {fieldInfo.FieldType}, {fieldInfo.IsPrivate}, {fieldInfo.IsPublic}, {fieldInfo.IsStatic}, {fieldInfo.IsInitOnly}, {fieldInfo.IsLiteral}");
            }
            foreach (var constructorInfo in constructors)
            {
                Console.WriteLine(
                    $"{constructorInfo.Name}, {constructorInfo.DeclaringType}, {constructorInfo.IsPublic}, {string.Join(", ", constructorInfo.GetParameters().ToArray<object>())}");
            }
            foreach (var methodInfo in methods)
            {
                Console.WriteLine(
                    $"{methodInfo.Name}, {methodInfo.DeclaringType}, {methodInfo.IsPublic}, {string.Join(", ", methodInfo.GetParameters().ToArray<object>())}");
            }
        }
    }
}