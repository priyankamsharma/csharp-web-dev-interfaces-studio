using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IElectronics
    {
        public DVD(string name, double storageCapacity, string discType) : base(name, storageCapacity, discType)
        {
        }

        public void SpinDisc()
        {
            Console.WriteLine("This disc spins about 1500 rpm! WoW...");
        }

        public void ReadData()
        {
            Console.WriteLine("There sure is a lot more room than a CD!");
        }



        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
