namespace W4_EndTask
{
    public class Computer : BaseMachine
    {
        public int _usbPortNumber;

        public int UsbPortNumber
        {
            get
            {
                return _usbPortNumber;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbPortNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid number of USB ports, '-1' will be assigned instead.");
                    _usbPortNumber = -1;
                }
            }
        }

        public bool HaveBluetooth { get; set; }

        public Computer(int serialNumber, string name, string description, string operationSystem, int usbPortNumber, bool haveBluetooth) : base(serialNumber, name, description, operationSystem)
        {
            UsbPortNumber = usbPortNumber;
            HaveBluetooth = haveBluetooth;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Number of USB ports: {UsbPortNumber}");
            Console.WriteLine($"Have bluetooth: {HaveBluetooth}");
        }

        public override void GetProductName()
        {
            Console.WriteLine($"Computer name: {Name}");
        }
    }
}
