using System;
namespace FactoryPatternExample
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Driving a new motorcycle");
        }
    }
}
