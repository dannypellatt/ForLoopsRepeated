using System;
namespace FactoryPatterns
{
    public class Unicycle : IVehicle
    {
        public void MakeVehicle()
        {
            Console.WriteLine("You want to make a unicycle!");
        }
    }
}

