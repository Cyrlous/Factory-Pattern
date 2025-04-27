namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("\nMotorcycle is driving.");
    }
}