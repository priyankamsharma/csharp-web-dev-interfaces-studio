using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public double StorageCapacity { get; set; }
        public double CapacityUsed { get; set; } = 0;  
        public string DiscType { get; }
        public List<string> DiscContents { get; }

        public BaseDisc(string name, double storageCapacity, string discType)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            DiscType = discType;
        }

        public void WriteToDisc(double data)
        {
            if (data + CapacityUsed > StorageCapacity)
            {
                Console.WriteLine("Not much space!");
                return;
            }
            CapacityUsed += data;
            StorageCapacity -= data;

        }

        public double CheckRemainingSpace()
        {
            return StorageCapacity - CapacityUsed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Disc Name : {Name}\nTotal Space : {StorageCapacity}\nSpace Used : {CapacityUsed}\nSpace Remaining : {CheckRemainingSpace()}");
        }


    }
}
