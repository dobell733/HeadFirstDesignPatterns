using Chapter4.SimpleFactoryPattern.Interfaces;

namespace Chapter4.SimpleFactoryPattern.Pizzas
{
    internal class VeggiePizza : Pizza
    {
        public PizzaIngredientFactory IngredientFactory { get; }

        public VeggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        internal override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = IngredientFactory.CreateDough();
            Console.WriteLine($"Dough: {Dough?.GetType().Name}");

            Sauce = IngredientFactory.CreateSauce();
            Console.WriteLine($"Sauce: {Sauce?.GetType().Name}");

            Cheese = IngredientFactory.CreateCheese();
            Console.WriteLine($"Cheese: {Cheese?.GetType().Name}");

            Veggies = IngredientFactory.CreateVeggies();
            Console.WriteLine($"Veggies:");
            if (Veggies != null)
            {
                foreach (var veggie in Veggies)
                {
                    Console.WriteLine($" - {veggie.GetType().Name}");
                }
            }
        }
    }
}
