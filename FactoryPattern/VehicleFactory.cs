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

    private static void DriveCars()
    {
        foreach (Car car in carList)
        {
            car.Drive();
        }
    }
    
    private static void DriveCycles()
    {
        foreach (Motorcycle cycle in cycleList)
        {
            cycle.Drive();
        }
    }
    
    private static void DriveRigs()
    {
        foreach (BigRig rig in rigList)
        {
            rig.Drive();
        }
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
                //Case 1 will allow the user to select the number of tires which will determine the vehicle type
                case 1:
                {
                    do
                    {
                        Console.WriteLine("Does your desired vehicle have 2, 4, or 18 wheels?");
                        string numTires = Console.ReadLine();
                        
                        switch (numTires)
                        {
                            case "2":
                                cycleList.Add(new Motorcycle());
                                Console.WriteLine("\nYou have created a gorgeous new motorcycle!\n");
                                Console.WriteLine("Please press enter to continue.");
                                Console.ReadLine();
                                
                                _validInput = true;
                                break;
                            case "4":
                                carList.Add(new Car());
                                Console.WriteLine("\nYou have created a beautiful new car!\n");
                                Console.WriteLine("Please press enter to continue.");
                                Console.ReadLine();
                                _validInput = true;
                                break;
                            case "18":
                                rigList.Add(new BigRig());
                                Console.WriteLine("\nYou have created an awesome new big rig!\n");
                                Console.WriteLine("Please press enter to continue.");
                                Console.ReadLine();
                                _validInput = true;
                                break;
                            default:
                                Console.WriteLine("Please enter a valid selection.\n");
                                _validInput = false;
                                break;
                        }
                    } while (_validInput == false);

                    break;
                }
                //Case 2 will display how many of each vehicle type has been created
                case 2:
                {
                    Console.WriteLine("You have created this many vehicles so far:\n");
                    Console.WriteLine($"Cars: \t{carList.Count}");
                    Console.WriteLine($"Motorcycles: {cycleList.Count}");
                    Console.WriteLine($"Big Rigs: \t{rigList.Count}\n");
                    Console.WriteLine("Please press enter to continue\n");

                    Console.ReadLine();
                    break;
                }
                //Case 3 will exit the program
                case 3:
                {
                    Console.WriteLine($"Thank you for using the Vehicle Creator.  Please have a nice day.");
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