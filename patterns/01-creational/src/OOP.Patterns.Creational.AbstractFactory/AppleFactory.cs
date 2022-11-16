namespace OOP.Patterns.Creational.AbstractFactory;

public class AppleFactory : IFactory
{
    public IPhone.DeviceModel CurrentPhoneModel { get; }

    public MacBook.DeviceModel CurrentLaptopModel { get; }

    public AppleFactory(IPhone.DeviceModel currentPhoneModel, MacBook.DeviceModel currentLaptopModel)
    {
        CurrentPhoneModel = currentPhoneModel;
        CurrentLaptopModel = currentLaptopModel;
    }

    public ISmartphone CreateSmartphone()
    {
        return new IPhone(Random.Shared.Next().ToString(), CurrentPhoneModel);
    }

    public ILaptop CreateLaptop()
    {
        return new MacBook(Random.Shared.Next().ToString(), CurrentLaptopModel);
    }
}
