using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD cd1 = new CD("Sony", 300, "CD-RW");
            DVD dvd1 = new DVD("Philips", 600, "DVD-R");

            // TODO: Call each CD and DVD method to verify that they work as expected.
            //Console.WriteLine("CD details");

            //cd1.ReadData();
            //cd1.WriteToDisc(22.01);
            //cd1.ReadData();
            //cd1.DisplayInfo();

            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("DVD details");
            
            dvd1.SpinDisc();
            dvd1.WriteToDisc(2221.01);
            dvd1.DisplayInfo();
            Console.Write(dvd1.CheckRemainingSpace());
        }
    }
}
