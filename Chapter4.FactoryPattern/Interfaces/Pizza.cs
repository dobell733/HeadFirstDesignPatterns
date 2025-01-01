using Chapter4.SimpleFactoryPattern.Ingredients;

namespace Chapter4.SimpleFactoryPattern.Interfaces
{
    internal abstract class Pizza
    {
        internal required string Name { get; set; }
        internal Dough? Dough { get; set; }
        internal Sauce? Sauce { get; set; }
        internal Cheese? Cheese { get; set; }
        internal Veggie[]? Veggies { get; set; }
        internal Pepperoni? Pepperoni { get; set; }
        internal Clam? Clam { get; set; }

        internal abstract void Prepare();
        internal void Bake() => Console.WriteLine("Bake for 25 minutes at 350");
        internal virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");
        internal void Box() => Console.WriteLine("Placing pizza in official PizzaStore box");

    }
}
