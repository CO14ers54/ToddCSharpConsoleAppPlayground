using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Factory
{
    public class Bicycle : IVehicle
    {
        private readonly int m_numWheels;

        public Bicycle ()
        {
            m_numWheels = 2;
        }
        public string VehicleType()
        {
            return "Bicycle Class";
        }

        public int NumberOfWheels()
        {
            return m_numWheels;
        }
    }
}
