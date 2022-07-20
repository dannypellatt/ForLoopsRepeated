using System;
namespace FactoryPatterns
{
    public class Tricycle : IVehicle
    {
        public void MakeVehicle()
        {
            Console.WriteLine("You want to make a tricycle!");
        }
    }
}

