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
                // this could just return ChicagoStyleCheesePizza type to be a regular factory pattern.
                // this usese an Abstract Factory to get families of ingredients for a cheese Pizza based on region
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
