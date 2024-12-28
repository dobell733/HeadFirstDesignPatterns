using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Behaviors
{
    public delegate void FlyBehavior();

    public class FlyBehaviors
    {
        public static void FlyWithWings() => Console.WriteLine("I'm flying!!");
        public static void FlyNoWay() => Console.WriteLine("I can't fly");
        public static void FlyRocketPowered() => Console.WriteLine("I'm flying with a rocket!");
    }
}
