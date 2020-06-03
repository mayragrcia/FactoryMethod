using System.Collections.Generic;

namespace FactoryMethod
{
    public class AzulAirlines : IAireline
    {
        public List<string> GetFlights()
        {
            return new List<string>
            {
                "Fortaleza - Boeing 725",
                "Gramado - Boeing 852"
            };
        }
    }
}