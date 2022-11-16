﻿namespace OOP.Patterns.Creational.AbstractFactory;

public class IPhone : ISmartphone
{
    public enum DeviceModel
    {
        Iphone11, Iphone11Pro, Iphone14Pro
    }

    public string SerialNumber { get; }

    public DeviceModel Model { get; }

    public IPhone(string serialNumber, DeviceModel model)
    {
        SerialNumber = serialNumber;
        Model = model;
    }

    public void Call()
    {
        Console.WriteLine($"Calling from {Model}. SerialNumber {SerialNumber}");
    }
}
