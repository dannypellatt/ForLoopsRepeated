using System;
namespace FactoryPatterns
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int vehicleType)
        {
            switch (vehicleType)
            {
                case 1: return new Unicycle();
                case 2: return new Motorcycle();
                case 3: return new Tricycle();
                case 4: return new Car();
                default: return new Car();
            }
        }
    }
}

