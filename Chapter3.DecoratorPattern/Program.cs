using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Chapter3.DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A plain ole House Blend
            Beverage myCoffee = new HouseBlend();
            Console.WriteLine($"{myCoffee.Description}: ${myCoffee.Cost():0.00}");

            // Create an Espresso and decorate it with Milk and Sugar
            Beverage myEspresso = new Espresso();
            myEspresso = new MilkDecorator(myEspresso);
            myEspresso = new SugarDecorator(myEspresso);

            Console.WriteLine($"{myEspresso.Description}: ${myEspresso.Cost():0.00}"); //myEspresso.Cost() = SugarDecorator.Cost() + MilkDecorator.Cost() + Espresso.Cost()

            // Create a Latte and decorate it with Chocolate and Whipped Cream
            Beverage myLatte = new HouseBlend();
            myLatte = new ChocolateDecorator(myLatte);
            myLatte = new MilkDecorator(myLatte);

            Console.WriteLine($"{myLatte.Description}: ${myLatte.Cost():0.00}");
        }
    }

    // Beverage Interface
    public interface Beverage
    {
        string Description { get; }
        double Cost();
    }


    // Concrete Beverages
    public class Espresso : Beverage
    {
        public string Description => "Espresso";

        public double Cost()
        {
            return 1.99; // Base cost of Espresso
        }
    }

    public class HouseBlend : Beverage
    {
        public string Description => "House Blend Coffee";

        public double Cost()
        {
            return 0.89; // Base cost of Latte
        }
    }


    // Base Decorator
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage; // any CondimentDecorator has a reference to a Beverage

        public CondimentDecorator(Beverage beverage) // pass in a Beverage
        {
            this.beverage = beverage;
        }

        // implemented by subclasses
        public abstract string Description { get; }
        public abstract double Cost();
    }


    // Concrete Decorators
    public class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(Beverage beverage) : base(beverage) { } // passes Beverage to superclass CondimentDecorator constructor

        public override string Description => beverage.Description + ", Milk";

        public override double Cost()
        {
            return beverage.Cost() + 0.5; // Add cost of milk
        }
    }

    public class SugarDecorator : CondimentDecorator
    {
        public SugarDecorator(Beverage beverage) : base(beverage) { } // passes Beverage to CondimentDecorator constructor

        public override string Description => beverage.Description + ", Sugar";

        public override double Cost()
        {
            return beverage.Cost() + 0.2; // Add cost of sugar
        }
    }

    public class ChocolateDecorator : CondimentDecorator
    {
        public ChocolateDecorator(Beverage beverage) : base(beverage) { } // passes Beverage to CondimentDecorator constructor

        public override string Description => beverage.Description + ", Chocolate";

        public override double Cost()
        {
            return beverage.Cost() + 0.7; // Add cost of chocolate
        }
    }

}
