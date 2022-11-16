namespace OOP.Patterns.Creational.Singleton;

public class SimpleSingleton : ISingleton
{
    private static SimpleSingleton? Instance = default;

    public Guid State { get; }

    private SimpleSingleton(Guid state) 
    {
        State = state;
    }

    public static SimpleSingleton GetInstance() 
    {
        if (Instance is null) 
        {
            Instance = new SimpleSingleton(Guid.NewGuid());
        }

        return Instance;
    }
}
