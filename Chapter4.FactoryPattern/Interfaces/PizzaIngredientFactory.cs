using Chapter4.SimpleFactoryPattern.Ingredients;

namespace Chapter4.SimpleFactoryPattern.Interfaces
{
    // abstract interface for creating family of products
    internal interface PizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggie[] CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clam CreateClam();
    }
}
