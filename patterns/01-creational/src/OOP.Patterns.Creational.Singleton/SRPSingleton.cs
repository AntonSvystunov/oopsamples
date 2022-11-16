namespace OOP.Patterns.Creational.Singleton;

public class SRPSingleton : ISingleton
{
    public Guid State { get; }

    public SRPSingleton() 
    {
        State = Guid.NewGuid();
    }
}