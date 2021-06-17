using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Chapter._8_TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tea myTea = new Tea();
            //myTea.PrepareRecipe();

            List<Duck> Ducks = new List<Duck>
            {
                new Duck("Daffy",8),
                new Duck("Dewey",2),
                new Duck("Howard",7),
                new Duck("Louie",2),
                new Duck("Donald",10),
                new Duck("Huey",2)
            };
            DisplayDuck(Ducks);
            Ducks.Sort();
            Console.WriteLine("-------------------------------------");
            DisplayDuck(Ducks);
            Console.ReadKey();
        }

        public static void DisplayDuck(IEnumerable<Duck> Ducks)
        {
            foreach (var item in Ducks)
            {
                Console.WriteLine($"{item}");
            }
        }
    }

    public class Duck : IComparable<Duck>
    {
        private readonly string name;
        private readonly int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(Duck Duck)
        {
            if (this.weight > Duck.weight)
            {
                return 1;
            }
            else if (this.weight == Duck.weight)
            {
                return 0;
            }
            else 
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"{name} {weight}";
        }
    }
}
