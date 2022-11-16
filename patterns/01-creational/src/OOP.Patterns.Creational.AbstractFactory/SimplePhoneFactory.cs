namespace OOP.Patterns.Creational.AbstractFactory;

public class SimplePhoneFactory : IFactory
{
    public ILaptop CreateLaptop()
    {
        return new SimplePhone();
    }

    public ISmartphone CreateSmartphone()
    {
        return new SimplePhone();
    }
}
