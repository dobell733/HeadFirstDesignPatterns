using Chapter1.Behaviors;

namespace Chapter1.Ducks
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
           Console.WriteLine("I'm a model duck");
        }

    }
}
