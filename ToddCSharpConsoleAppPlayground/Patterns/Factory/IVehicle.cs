using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Factory
{
    /// <summary>
    /// This pattern comes under the creational patterns which are widely used in programming constructs. In other words,  “This Pattern provides the best way to create the Objects. 
    /// In Factory patterns we create the object of the Class without Exposing the Creation/Instantiation Logic to the User who wants to create the Object and then return the 
    /// newly Created object using the Common Interface which is inherited  by the Class”.
    /// </summary>

    public interface IVehicle
    {
        public string VehicleType();
        public int NumberOfWheels();
    }
}
