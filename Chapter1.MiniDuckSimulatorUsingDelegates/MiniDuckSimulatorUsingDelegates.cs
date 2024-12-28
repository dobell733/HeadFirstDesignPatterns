using Chapter1.Behaviors;
using Chapter1.Ducks;

namespace Chapter1
{
    internal class MiniDuckSimulatorUsingDelegates
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = FlyBehaviors.FlyRocketPowered;
            model.PerformFly();
        }
    }
}
