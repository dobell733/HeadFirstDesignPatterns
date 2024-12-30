using Chapter4.SimpleFactoryPattern.Interfaces;
using Chapter4.SimpleFactoryPattern.Pizzas;

namespace Chapter4.SimpleFactoryPattern.PizzaStores
{
    internal class CaliforniaPizzaStore : PizzaStore
    {
        internal override Pizza? CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new CaliforniaStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                return new CaliforniaStyleVeggiePizza();
            }
            else if (type == "clam")
            {
                return new CaliforniaStyleClamPizza();
            }
            else if (type == "pepperoni")
            {
                return new CaliforniaStylePepperoniPizza();
            }
            else return null;
        }
    }
}
