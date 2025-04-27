namespace FactoryPattern;

public static class VehicleFactory
{
    private static bool _validInput = false;
    private static int _answer = 0;
    private static List<Car> carList = new List<Car>();
    private static List<Motorcycle> cycleList = new List<Motorcycle>();
    private static List<BigRig> rigList = new List<BigRig>();

    public static IVehicle GetVehicle(string numTires)
    {
        do
        {
            switch (numTires)
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                case "18":
                    return new BigRig();
                default:
                    return new Car();
            }
        } while (_validInput == false);
    }

    public static void VehicleTracker()
    {
        //Main loop.  Will continue to allow user to make selections
        //until 3 is selected at which point the program will exit
        do
        {
            Console.WriteLine("Vehicle Creator\n");
            Console.WriteLine("1. Create Vehicle");
            Console.WriteLine("2. Check Vehicle Count");
            Console.WriteLine("3. Exit\n");
            Console.WriteLine("Please Enter Your Selection:");

            //Filter user input to ensure it is an integer
            if (int.TryParse(Console.ReadLine(), out _answer))
            {
                _validInput = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid selection.\n");
                _validInput = false;
                continue;
            }
            

            //Switch case to execute the various menu options
            switch (_answer)
            {
                //Case 1 will allow the user to convert Fahrenheit to Celsius
                case 1:
                {
                    Console.WriteLine("Does your desired vehicle have 2, 4, or 18 wheels?\n");
                    string numTires = Console.ReadLine();
                    do
                    {
                        switch (numTires)
                        {
                            case "2":
                                cycleList.Add(new Motorcycle());
                                break;
                            case "4":
                                carList.Add(new Car());
                                break;
                            case "18":
                                rigList.Add(new BigRig());
                                break;
                            default:
                                Console.WriteLine("Please enter a valid selection.\n");
                                _validInput = false;
                                break;
                        }
                    } while (_validInput == false);

                    break;
                }
                //Case 2 will allow the user to convert Celsius to Fahrenheit
                case 2:
                {
                    
                }
                //Case 3 will exit the program
                case 3:
                {
                    Console.WriteLine($"Thank you for using the Temperature Converter.  Please have a nice day.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Please enter a valid selection.");
                    break;
                }
            }
        } while (_answer != 3);
    }
}