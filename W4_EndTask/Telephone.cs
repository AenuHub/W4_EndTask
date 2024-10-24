namespace W4_EndTask
{
    public class Telephone : BaseMachine
    {
        public bool IsTrLicensed { get; set; }

        public Telephone(int serialNumber, string name, string description, string operationSystem, bool isTrLicensed) : base(serialNumber, name, description, operationSystem)
        {
            IsTrLicensed = isTrLicensed;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"TR licensed: {IsTrLicensed}");
        }

        public override void GetProductName()
        {
            Console.WriteLine($"Telephone name: {Name}");
        }
    }
}
