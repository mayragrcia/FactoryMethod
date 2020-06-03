using System;

namespace FactoryMethod
{
    public class AirlineFactory : IAirlineFactory
    {
        public IAireline Create()
        {
            return new AzulAirlines();
        }

        public IAireline Create(string airLine)
        {
            if (airLine == "Azul")
            {
                return new AzulAirlines();
            }

            if (airLine == "Latam")
            {
                return new LatamAirline();
            }

            throw new NotSupportedException("the airLine doesn't support");
        }
    }
}