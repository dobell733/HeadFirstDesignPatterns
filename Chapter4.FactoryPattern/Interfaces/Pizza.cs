using System;

namespace Chapter4.SimpleFactoryPattern.Interfaces
{
    internal abstract class Pizza
    {
        internal string? Name { get; set; }
        internal string? Dough { private get; set; }
        internal string? Sauce { private get; set; }
        internal List<string> Toppings { get; set; } = new List<string>();

        internal void Prepare() { 
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in Toppings)
            {
                Console.WriteLine($" {topping}");
            }
            Console.WriteLine();
        }

        internal void Bake() => Console.WriteLine("Bake for 25 minutes at 350");
        internal virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");
        internal void Box() => Console.WriteLine("Place pizza in official PizzaStore box");

    }
}
