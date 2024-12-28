using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Behaviors
{
    public delegate void QuackBehavior();

    public class QuackBehaviors
    {
        public static void Quack() => Console.WriteLine("Quack");
        public static void MuteQuack() => Console.WriteLine("<< Silence >>");
        public static void Squeak() => Console.WriteLine("Squeak");
    }
}
