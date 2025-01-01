using Chapter4.SimpleFactoryPattern.IngredientFactories;
using Chapter4.SimpleFactoryPattern.Interfaces;
using Chapter4.SimpleFactoryPattern.Pizzas;

namespace Chapter4.SimpleFactoryPattern.PizzaStores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        internal override Pizza? CreatePizza(string type)
        {
            Pizza pizza = null;

            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type == "cheese")
            {
                // this could just return "ChicagoStyleCheesePizza : Pizza" type which impelements it's ingredients to be a regular factory pattern.
                // this uses an Abstract Factory to get families of ingredients based on region instead.
                pizza = new CheesePizza(ingredientFactory) { Name = "Chicago Style Cheese Pizza" };
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory) { Name = "Chicago Style Veggie Pizza" };
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory) { Name = "Chicago Style Clam Pizza" };
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory) { Name = "Chicago Style Pepperoni Pizza" };
            }
            return pizza;
        }
    }
}
