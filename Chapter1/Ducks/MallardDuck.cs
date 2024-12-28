using Chapter1.Behaviors;

namespace Chapter1.Ducks
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new NormalQuack();
        }

        public override void Display()
        {
           Console.WriteLine("I'm a real Mallard duck");
        }

    }
}
