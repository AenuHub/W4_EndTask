using W4_EndTask;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("****** Welcome to Patika+ Week 4 End Task ******");
        Console.WriteLine("------------------------------------------------");
        string userChoice = "";
        do
        {
            MainMenu();
            userChoice = GetChoice();

            // switch case for user choice
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Please enter the following information: ");
                    BaseMachine phone = CreatePhone();
                    Console.WriteLine("Product created successfully.");
                    Console.WriteLine("------------------------------------------------");
                    phone.PrintInfo();
                    Console.WriteLine("------------------------------------------------");
                    break;
                case "2":
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Please enter the following information: ");
                    BaseMachine computer = CreateComputer();
                    Console.WriteLine("Product created successfully.");
                    Console.WriteLine("------------------------------------------------");
                    computer.PrintInfo();
                    Console.WriteLine("------------------------------------------------");
                    break;
                case "3":
                    Console.WriteLine("Thanks for using the program. Goodbye!");
                    return;
                default:
                    break;
            }
        } while (userChoice != "1" || userChoice != "2");
    }

    // method for printing main menu
    public static void MainMenu()
    {
        Console.WriteLine("Please select an option: ");
        Console.WriteLine("-- 1. Create a new telephone product");
        Console.WriteLine("-- 2. Create a new computer product");
        Console.WriteLine("-- 3. Exit");
        Console.Write("-- Your choice: ");
    }

    // method for getting user choice and validate
    public static string GetChoice()
    {
        string choice = Console.ReadLine();
        if (choice == "1" || choice == "2" || choice == "3")
        {
            return choice;
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
            return GetChoice();
        }
    }

    // method for option 1: create a phone
    public static BaseMachine CreatePhone()
    {
        string name = GetName();
        string description = GetDescription();
        string operationSystem = GetOperationSystem();
        int serialNumber = GetSerialNumber();
        bool isTrLicensed = GetIsTrLicensed();
        return new Telephone(serialNumber, name, description, operationSystem, isTrLicensed);
    }

    // method for option 2: create a computer
    public static BaseMachine CreateComputer()
    {
        string name = GetName();
        string description = GetDescription();
        string operationSystem = GetOperationSystem();
        int serialNumber = GetSerialNumber();
        int usbPortNumber = GetUsbPortNumber();
        bool haveBluetooth = GetHaveBluetooth();
        return new Computer(serialNumber, name, description, operationSystem, usbPortNumber, haveBluetooth);
    }

    public static int GetSerialNumber()
    {
        bool isValid = false;
        int serialNumber = 0;
        do
        {
            Console.Write("-- Serial number: ");

            bool result = int.TryParse(Console.ReadLine(), out int userInput);
            if (result && userInput > 0)
            {
                serialNumber = userInput;
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid serial number. Please try again.");
            }
        } while (!isValid);

        return serialNumber;
    }

    public static string GetName()
    {
        bool isValid = false;
        string name = "";
        do
        {
            Console.Write("-- Name of the product: ");

            name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid name. Please try again.");
            }
        } while (!isValid);

        return name;
    }

    public static string GetDescription()
    {
        bool isValid = false;
        string description = "";
        do
        {
            Console.Write("-- Description: ");
            description = Console.ReadLine();
            if (!string.IsNullOrEmpty(description))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid description. Please try again.");
            }
        } while (!isValid);
        return description;
    }

    public static string GetOperationSystem()
    {
        bool isValid = false;
        string operationSystem = "";
        do
        {
            Console.Write("-- Operation system: ");
            operationSystem = Console.ReadLine();
            if (!string.IsNullOrEmpty(operationSystem))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid operation system. Please try again.");
            }
        } while (!isValid);
        return operationSystem;
    }

    public static int GetUsbPortNumber()
    {
        bool isValid = false;
        int usbPortNumber = 0;
        do
        {
            Console.Write("-- Number of USB ports: ");
            bool result = int.TryParse(Console.ReadLine(), out int userInput);
            if (result && userInput > 0)
            {
                usbPortNumber = userInput;
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid number of USB ports. Please try again.");
            }
        } while (!isValid);
        return usbPortNumber;
    }

    public static bool GetHaveBluetooth()
    {
        bool isValid = false;
        bool haveBluetooth = false;
        do
        {
            Console.Write("-- Have bluetooth (Y/N): ");
            string userInput = Console.ReadLine();
            if (userInput == "Y" || userInput == "y")
            {
                haveBluetooth = true;
                isValid = true;
            }
            else if (userInput == "N" || userInput == "n")
            {
                haveBluetooth = false;
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (!isValid);
        return haveBluetooth;
    }

    public static bool GetIsTrLicensed()
    {
        bool isValid = false;
        bool isTrLicensed = false;
        do
        {
            Console.Write("-- Is Tr Licensed (Y/N): ");
            string userInput = Console.ReadLine();
            if (userInput == "Y" || userInput == "y")
            {
                isTrLicensed = true;
                isValid = true;
            }
            else if (userInput == "N" || userInput == "n")
            {
                isTrLicensed = false;
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (!isValid);
        return isTrLicensed;
    }
}