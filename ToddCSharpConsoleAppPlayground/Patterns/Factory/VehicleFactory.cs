using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddCSharpConsoleAppPlayground.Patterns.Factory
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string type) 
        {
            IVehicle objectType = null;

            switch(type.ToUpper())
            {
                case "BICYCLE":
                    objectType = new Bicycle();
                    break;
                case "CAR":
                    objectType = new Car();
                    break;
                case "RICKSHAW":
                    objectType = new Rickshaw();
                    break;
                default:
                    break;
            }

            return objectType;
        }
    }
}
