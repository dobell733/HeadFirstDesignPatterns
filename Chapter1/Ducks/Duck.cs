using Chapter1.Behaviors;

public abstract class Duck
{
    // Properties
    public IFlyBehavior FlyBehavior { get; set; } // type is interface, meaning any IFlyBehavior can be assigned
    public IQuackBehavior QuackBehavior { get; set; } // type is interface, meaning any IQuackBehavior can be assigned

    // Methods
    public abstract void Display();

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public static void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}
