using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IElectronics
        {
        public CD(string name, double storageCapacity, string discType) : base(name, storageCapacity, discType)
        {
        }

        public void SpinDisc()
        {
            Console.WriteLine("CD spins about 500 rpm!");
        }

        public void ReadData()
        {
            if (CapacityUsed > 0)
            {
                Console.WriteLine("This CD has good stuff. Watch it!");
            }
            else
            {
                Console.WriteLine("Try writing something on this CD!");
            }

        }
    }
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }


