using System.Collections.Generic;

namespace FactoryMethod
{
    public class LatamAirline : IAireline
    {
        public List<string> GetFlights()
        {
            return new List<string>
            {
                "Florida - Boeing 777",
                "New York - Boeing 852"
            };
        }
    }
}