using Chapter1.Behaviors;

public abstract class Duck
{
    // Properties
    public FlyBehavior FlyBehavior { private get; set; } // type is delegate
    public QuackBehavior QuackBehavior { private get; set; } // type is delegate

    // Methods
    public abstract void Display();

    public void PerformFly()
    {
        FlyBehavior.Invoke();
    }

    public void PerformQuack()
    {
        QuackBehavior.Invoke();
    }

    public static void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}
