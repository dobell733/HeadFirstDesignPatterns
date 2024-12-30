using Chapter4.SimpleFactoryPattern.Interfaces;
using Chapter4.SimpleFactoryPattern.Pizzas;

namespace Chapter4.SimpleFactoryPattern.PizzaStores
{
    internal class NYPizzaStore : PizzaStore
    {
        internal override Pizza? CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                return new NYStyleVeggiePizza();
            }
            else if (type == "clam")
            {
                return new NYStyleClamPizza();
            }
            else if (type == "pepperoni")
            {
                return new NYStylePepperoniPizza();
            }
            else return null;
        }
    }
}
