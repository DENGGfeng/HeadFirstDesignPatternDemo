using System;
using System.Collections.Generic;

namespace FatoryPattern
{
    public abstract class Pizza
    {
        protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Clam clam;

        //public virtual void Prepare()
        //{
        //    Console.WriteLine($"Preparing {name}");
        //    Console.WriteLine("tossing dough...");
        //    Console.WriteLine("Adding sauce...");
        //    Console.WriteLine("Adding toppings...");
        //}

        public abstract void Prepare();

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza inteo digonal slices.");
        }

        public string GetName() => name;

        public void SetName(string name) => this.name = name;
    }
}
