using Chapter4.SimpleFactoryPattern.Ingredients;

namespace Chapter4.SimpleFactoryPattern.IngredientFactories
{
    internal class ChicagoPizzaIngredientFactory
    {
        public Dough CreateDough() => new ThickCrustDough();

        public Sauce CreateSauce() => new PlumTomatoSauce();

        public Cheese CreateCheese() => new MozzarellaCheese();

        public Veggie[] CreateVeggies() => [new Spinach(), new EggPlant(), new BlackOlives()];

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public Clam CreateClam() => new FrozenClams();
    }
}
