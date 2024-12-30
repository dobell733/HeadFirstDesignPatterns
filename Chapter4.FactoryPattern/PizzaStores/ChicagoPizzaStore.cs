using Chapter4.SimpleFactoryPattern.Interfaces;
using Chapter4.SimpleFactoryPattern.Pizzas;

namespace Chapter4.SimpleFactoryPattern.PizzaStores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        internal override Pizza? CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (type == "clam")
            {
                return new ChicagoStyleClamPizza();
            }
            else if (type == "pepperoni")
            {
                return new ChicagoStylePepperoniPizza();
            }
            else return null;
        }
    }
}
