using OOP.Patterns.Creational.Prototype;

namespace OOP.Patterns.Creational;

internal static class PrototypeTestRunner
{
    public static void Run()
    {
        Console.WriteLine("Running tests for prototype implementations...\n");

        var iPhone = new IPhone(Random.Shared.Next(1_000_000, 9_999_999).ToString()
            , IPhone.DeviceModel.Iphone14Pro);

        var cloneFactory = new PhoneCloneFactory(iPhone);
        var fakeIPhone = cloneFactory.CreateSmartphone();

        iPhone.Call();
        fakeIPhone.Call();
        Console.WriteLine();
    }
}
