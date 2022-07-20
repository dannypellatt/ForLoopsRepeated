using System;
namespace FactoryPatterns
{
    public class Car : IVehicle
    {
        public void MakeVehicle()
        {
            Console.WriteLine("You want to make a car!");
        }
    }
}

