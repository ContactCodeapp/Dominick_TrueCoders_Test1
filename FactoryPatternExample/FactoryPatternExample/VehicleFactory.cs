using System;
namespace FactoryPatternExample
{
    static class VehicleFactory
    {
        static VehicleFactory()
        {
        }

        public static IVehicle VehicleType(int tires)
        {

            switch (tires)
                {
                    case 2:
                        return new Motorcycle();
                    case 4:
                        return new Car();
                    default:
                        return new Car();
                }
            
            
        }
    }
}