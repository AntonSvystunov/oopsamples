namespace OOP.Patterns.Creational.AbstractFactory;

public class MacBook : ILaptop
{
    public enum DeviceModel
    {
        Air, Pro
    }

    public string SerialNumber { get; }

    public DeviceModel Model { get; }

    public MacBook(string serialNumber, DeviceModel model)
    {
        SerialNumber = serialNumber;
        Model = model;
    }

    public void Work()
    {
        Console.WriteLine($"Working from MacBook {Model}. SerialNumber {SerialNumber}");
    }
}