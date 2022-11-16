namespace OOP.Patterns.Creational.Prototype;

public class SimplePhone : ISmartphone
{
    public void Call()
    {
        Console.WriteLine("Calling from simple phone");
    }

    public object Clone()
    {
        return new SimplePhone();
    }
}