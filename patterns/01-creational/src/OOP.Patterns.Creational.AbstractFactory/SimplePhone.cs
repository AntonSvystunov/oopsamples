namespace OOP.Patterns.Creational.AbstractFactory;

public class SimplePhone : ISmartphone, ILaptop
{
    public void Call()
    {
        Console.WriteLine("Calling from simple phone");
    }

    public void Work()
    {
        Console.WriteLine("How can I work from simple phone???");
    }
}