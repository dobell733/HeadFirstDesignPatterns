using Chapter1.Behaviors;
using Chapter1.Ducks;

namespace Chapter1
{
    internal class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();

            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.FlyBehavior = new FlyRocketPowered();
            modelDuck.PerformFly();
        }
    }
}
