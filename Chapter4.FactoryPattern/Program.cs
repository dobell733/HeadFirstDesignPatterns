using Chapter4.SimpleFactoryPattern.Interfaces;
using Chapter4.SimpleFactoryPattern.PizzaStores;

namespace Chapter4.FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple Factory
            //var pizzaFactory = new SimplePizzaFactory(); // create the factory
            //var pizzaStore = new PizzaStore(pizzaFactory); // pass it to the store
            //pizzaStore.orderPizza("cheese"); // now the store can use factory to create different pizza types

            PizzaStore nyPizzaStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}" + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}");

        }
    }
}
