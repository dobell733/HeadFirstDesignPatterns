using Chapter4.SimpleFactoryPattern.Ingredients;
using Chapter4.SimpleFactoryPattern.Interfaces;

namespace Chapter4.SimpleFactoryPattern.IngredientFactories
{
    // concrete subclass to create family of ingredients for ny pizzas
    internal class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        // these are factory methods in and of themselves, CreateDough can return any Dough, CreateSauce can return any Sauce, etc.
        public Dough CreateDough() => new ThinCrustDough();

        public Sauce CreateSauce() => new MarinaraSauce();

        public Cheese CreateCheese() => new ReggianoCheese();

        public Veggie[] CreateVeggies() => [new Garlic(), new Onion(), new Mushroom(), new RedPepper()];

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public Clam CreateClam() => new FreshClams();
    }
}
