namespace Chapter4.FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaFactory = new SimplePizzaFactory(); // create the factory
            var pizzaStore = new PizzaStore(pizzaFactory); // pass it to the store
            pizzaStore.orderPizza("cheese"); // now the store can use factory to create different pizza types
        }
    }
}
