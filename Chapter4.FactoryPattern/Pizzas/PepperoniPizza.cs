using Chapter4.SimpleFactoryPattern.Interfaces;

namespace Chapter4.SimpleFactoryPattern.Pizzas
{
    internal class PepperoniPizza : Pizza
    {
        public PizzaIngredientFactory IngredientFactory { get; }

        public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
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

            Pepperoni = IngredientFactory.CreatePepperoni();
            Console.WriteLine($"Pepperoni: {Pepperoni?.GetType().Name}");
        }
    }
}
