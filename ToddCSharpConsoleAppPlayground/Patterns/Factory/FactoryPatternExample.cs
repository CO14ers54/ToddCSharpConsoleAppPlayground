using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Factory
{
    public class FactoryPatternExample
    {
        public static void Run()
        {
            IVehicle vehicle = null;
            Console.WriteLine("Factory Pattern Example");
            Console.WriteLine("");

            Console.WriteLine("Create a Bicycle");
            vehicle = VehicleFactory.GetVehicle("bicycle");
            Console.WriteLine($"Bicycle Created!  VehicleType: {vehicle.VehicleType()}, NumberOfWheels: {vehicle.NumberOfWheels()}");
            Console.WriteLine("");

            Console.WriteLine("Create a Car");
            vehicle = VehicleFactory.GetVehicle("car");
            Console.WriteLine($"Bicycle Created!  VehicleType: {vehicle.VehicleType()}, NumberOfWheels: {vehicle.NumberOfWheels()}");
            Console.WriteLine("");

            Console.WriteLine("Create a Rickshaw");
            vehicle = VehicleFactory.GetVehicle("rickshaw");
            Console.WriteLine($"Bicycle Created!  VehicleType: {vehicle.VehicleType()}, NumberOfWheels: {vehicle.NumberOfWheels()}");
            Console.WriteLine("");
        }
    }
}
