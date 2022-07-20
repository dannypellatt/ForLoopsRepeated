using System;
namespace FactoryPatterns
{
    public class Motorcycle : IVehicle
    {
        public void MakeVehicle()
        {
            Console.WriteLine("You want to make a motorcycle!");
        }
    }
}

