namespace OOP.Patterns.Creational.Prototype;

public class PhoneCloneFactory : IFactory
{
    private readonly ISmartphone prototype;

    public PhoneCloneFactory(ISmartphone prototype)
    {
        this.prototype = prototype;
    }

    public ISmartphone CreateSmartphone()
    {
        return (ISmartphone)prototype.Clone();
    }
}
