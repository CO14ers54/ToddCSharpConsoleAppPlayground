using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Factory
{
    public class Car : IVehicle
    {
        private readonly int m_numWheels;

        public Car()
        {
            m_numWheels = 2;
        }

        public string VehicleType()
        {
            return "Car Class";
        }

        public int NumberOfWheels()
        {
            return m_numWheels;
        }
    }
}
