using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Factory
{
    public class Rickshaw : IVehicle
    {
        private readonly int m_numWheels;

        public Rickshaw() 
        {
            m_numWheels = 3;
        }

        public string VehicleType()
        {
            return "Car Class";
        }

        public int NumberOfWheels ()
        {
            return m_numWheels;
        }
    }
}
