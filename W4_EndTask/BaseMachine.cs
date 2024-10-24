namespace W4_EndTask
{
    public abstract class BaseMachine
    {
        public DateTime DateTime { get; set; }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperationSystem { get; set; }

        public BaseMachine(int serialNumber, string name, string description, string operationSystem)
        {
            DateTime = DateTime.Now;
            SerialNumber = serialNumber;
            Name = name;
            Description = description;
            OperationSystem = operationSystem;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Serial number: {SerialNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Operation system: {OperationSystem}");
            Console.WriteLine($"Production date: {DateTime.ToShortDateString()}");
        }

        public abstract void GetProductName();
    }
}
