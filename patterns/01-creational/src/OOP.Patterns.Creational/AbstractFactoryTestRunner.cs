using OOP.Patterns.Creational.AbstractFactory;

namespace OOP.Patterns.Creational;

internal static class AbstractFactoryTestRunner
{
    private static void CreateAndCall(IFactory factory)
    {
        var phone = factory.CreateSmartphone();

        phone.Call();

        var laptop = factory.CreateLaptop();

        laptop.Work();
    }

    public static void Run()
    {
        Console.WriteLine("Running tests for factory implementations...\n");

        CreateAndCall(new AppleFactory(IPhone.DeviceModel.Iphone14Pro, MacBook.DeviceModel.Pro));
        CreateAndCall(new SimplePhoneFactory());

        Console.WriteLine();
    }
}
