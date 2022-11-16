namespace OOP.Patterns.Creational.Singleton;

public class ThreadSafeSingleton : ISingleton
{
    private static ThreadSafeSingleton? Instance = default;

    private static object SyncRoot = new object();

    public Guid State { get; }

    private ThreadSafeSingleton(Guid state) 
    {
        State = state;
    }

    public static ThreadSafeSingleton GetInstance() 
    {
        if (Instance is null) 
        {
            lock (SyncRoot) 
            {
                if (Instance is null) 
                {
                    Instance = new ThreadSafeSingleton(Guid.NewGuid());
                }
            }
        }

        return Instance;
    }
}
