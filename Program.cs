using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IAirlineFactory airlineFactory = new AirlineFactory();

            var defaultAirline = airlineFactory.Create();

            var latamAirline = airlineFactory.Create("Latam");

            var flights = defaultAirline.GetFlights();

            flights.AddRange(latamAirline.GetFlights());

            Console.WriteLine($"Airline flights:");

            foreach (var flight in flights)
            {
                Console.WriteLine(flight);
            }

            Console.ReadKey();
        }
    }
}
