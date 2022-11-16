using Microsoft.Extensions.DependencyInjection;

using OOP.Patterns.Creational.Singleton;

namespace OOP.Patterns.Creational;

internal static class SingletonTestRunner
{
    private const int DefaultTestCount = 1000;

    private static void RunTest<TSingleton>(Func<TSingleton> factoryMethod, int testCount = DefaultTestCount)
        where TSingleton : ISingleton
    {
        Console.WriteLine($"Testing singleton with a type: {typeof(TSingleton).Name}");

        var results = new Guid[testCount];

        Parallel.For(0, testCount, i =>
        {
            var instance = factoryMethod();
            results[i] = instance.State;
        });

        var groupedResult = results
            .GroupBy(state => state)
            .Select(group => new { State = group.Key, Count = group.Count() });

        Console.WriteLine(string.Join("\n", groupedResult.Select(group => $"{group.State} - {group.Count}")));
    }

    public static void Run()
    {
        Console.WriteLine("Running tests for singleton implementations...\n");
        RunTest(() => SimpleSingleton.GetInstance());
        RunTest(() => ThreadSafeSingleton.GetInstance());

        var serviceProvider = new ServiceCollection()
            .AddSingleton<SRPSingleton>()
            .BuildServiceProvider();

        RunTest(() => serviceProvider.GetRequiredService<SRPSingleton>());
        Console.WriteLine();
    }
}
