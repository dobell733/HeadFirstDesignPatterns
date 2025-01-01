using Chapter4.SimpleFactoryPattern.IngredientFactories;
using Chapter4.SimpleFactoryPattern.Interfaces;
using Chapter4.SimpleFactoryPattern.Pizzas;

namespace Chapter4.SimpleFactoryPattern.PizzaStores
{
    internal class NYPizzaStore : PizzaStore
    {
        internal override Pizza? CreatePizza(string type)
        {
            Pizza pizza = null;

            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" };
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory) { Name = "New York Style Veggie Pizza" };
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory) { Name = "New York Style Clam Pizza" };
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory) { Name = "New York Style Pepperoni Pizza" };
            }
            return pizza;
        }
    }
}
