using Chapter1.Behaviors;

namespace Chapter1.Ducks
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = FlyBehaviors.FlyNoWay;
            QuackBehavior = QuackBehaviors.MuteQuack;
        }

        public override void Display()
        {
           Console.WriteLine("I'm a model duck");
        }

    }
}
