namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Motorcycle is driving.");
    }
}