using Chapter4.SimpleFactoryPattern.Ingredients;
using Chapter4.SimpleFactoryPattern.Interfaces;

namespace Chapter4.SimpleFactoryPattern.IngredientFactories
{
    // concrete subclass to create family of ingredients for chicago pizzas
    internal class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        // these are factory methods in and of themselves, CreateDough can return any Dough, CreateSauce can return any Sauce, etc.
        public Dough CreateDough() => new ThickCrustDough();

        public Sauce CreateSauce() => new PlumTomatoSauce();

        public Cheese CreateCheese() => new MozzarellaCheese();

        public Veggie[] CreateVeggies() => [new Spinach(), new EggPlant(), new BlackOlives()];

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public Clam CreateClam() => new FrozenClams();
    }
}
