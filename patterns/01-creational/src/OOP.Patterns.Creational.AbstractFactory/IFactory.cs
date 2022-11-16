namespace OOP.Patterns.Creational.AbstractFactory;

public interface IFactory
{
    ISmartphone CreateSmartphone();

    ILaptop CreateLaptop();
}