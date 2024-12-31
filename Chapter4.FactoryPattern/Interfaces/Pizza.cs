using Chapter4.SimpleFactoryPattern.Ingredients;

namespace Chapter4.SimpleFactoryPattern.Interfaces
{
    internal abstract class Pizza
    {
        internal required string Name { get; set; }
        internal required Dough Dough { private get; set; }
        internal Sauce? Sauce { private get; set; }
        internal Cheese? Cheese { private get; set; }
        internal Veggie[]? Veggies { private get; set; }
        internal Pepperoni? Pepperoni { get; set; }
        internal Clam? Clam { private get; set; }

        internal abstract void Prepare();

        internal void Bake() => Console.WriteLine("Bake for 25 minutes at 350");
        internal virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");
        internal void Box() => Console.WriteLine("Place pizza in official PizzaStore box");

    }
}
