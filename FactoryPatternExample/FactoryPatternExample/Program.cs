using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does the vehicle you are currently driving have?");
            int tires = int.Parse(Console.ReadLine());

            var whip = VehicleFactory.VehicleType(tires);
            whip.Drive();
        }
    }
}
