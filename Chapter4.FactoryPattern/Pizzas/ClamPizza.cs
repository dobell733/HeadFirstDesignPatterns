using Chapter4.SimpleFactoryPattern.Interfaces;

namespace Chapter4.SimpleFactoryPattern.Pizzas
{
    internal class ClamPizza : Pizza
    {
        public PizzaIngredientFactory IngredientFactory { get; }

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
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

            Clam = IngredientFactory.CreateClam();
            Console.WriteLine($"Clam: {Clam?.GetType().Name}");
        }
    }
}
