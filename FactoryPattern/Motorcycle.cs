namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("You have created a gorgeous new motorcycle!");
    }
}