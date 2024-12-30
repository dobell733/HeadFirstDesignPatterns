namespace Chapter4.SimpleFactoryPattern.Interfaces
{
    internal abstract class PizzaStore
    {
        internal Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        internal abstract Pizza CreatePizza(string type); // concrete pizza stores implement this, this is the factory method for creating pizzas.

    }
}
