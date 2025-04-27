namespace FactoryPattern;

public class BigRig : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("You have created an awesome new big rig!");
    }
}