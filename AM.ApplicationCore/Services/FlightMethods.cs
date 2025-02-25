using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public IEnumerable<DateTime> GetFlightDates(string destination)
        {
            IEnumerable<DateTime> result = new List<DateTime>();

            //for (int i = 0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination.Equals(destination))
            //    {
            //        result.Add(Flights[i].FlightDate);
            //    }
            //}

            /* for each */ 
            //foreach (var flight in Flights)
            //{
            //    if (flight.Destination.Equals(destination))
            //    {
            //        ((List<DateTime>)result).Add(flight.FlightDate);
            //    }
            //}

            /* en utilisant LINQ */
            //result= from f in Flights 
            //        where f.Destination.Equals(destination) 
            //        select f.FlightDate;

            /* en utilisant les fonctions lambda  */ 
            result = Flights.Where(f => f.Destination.Equals(destination))
                            .Select(f => f.FlightDate);
            return result;
        }
        
        public void GetFlights(string filterType , string filterValue)
        {
            IEnumerable<Flight> filtredFlights = Flights;

            switch (filterType.ToLower() ) {
                case "destination" :
                    filtredFlights = Flights.Where(f => f.Destination.ToLower().Equals(filterValue.ToLower()));
                    break;
                case "flightdate":
                    if (DateTime.TryParse(filterValue, out DateTime flightDate))
                    {
                        filtredFlights = Flights.Where(f => f.FlightDate == flightDate.Date);
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format.");
                        return;
                    }
                    break;
                case "effectivearrival":
                    if (DateTime.TryParse(filterValue, out DateTime arrival))
                    {
                      
                        filtredFlights = Flights.Where(f => f.EffectiveArrival.Date == arrival.Date);
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format.");
                    }
                    break;
            }
            foreach (var flight in filtredFlights) 
            {
                Console.WriteLine(flight); 
            }
            
        }
        public void ShowFlightDetails(Plane plane)
        {
            /* language LINQ */
            var req = from f in Flights
                      where f.plane == plane
                      select new { f.Destination, f.FlightDate };
            foreach (var f in req) {
                Console.WriteLine(f); 
            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            /* language LINQ */
            var req = from f in Flights
                      where DateTime.Compare(f.FlightDate, startDate) < 0 && (f.FlightDate-startDate).TotalDays <8 
                      select f;
            foreach(var f in  req.ToList()) Console.WriteLine(f);
            return req.Count();
        }

        public double DurationAverage(string destination)
        {
            /* language LINQ */
            var req = from f in Flights
                      where f.Destination == destination 
                      select f.EstimatedDuration;
            return req.Average() ;
        }

        public IEnumerable<Flight> OrderedDurationFlights() {
            /* language LINQ */
            var req = from f in Flights
                      orderby f.EstimatedDuration descending 
                      select f; 
            return req;

            //return Flights.OrderByDescending(f => f.EstimatedDuration); 
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            /* language LINQ */
            var req = from t in flight.Passengers.OfType<Traveller>()
                      orderby t.BirthDate
                      select t;

            return req.Take(3) ;

        }

        public IEnumerable<IGrouping<string, Flight> > DestinationGroupedFlights()
        {
            /* Fonction LAMBDA */
            //var groupFlights = Flights.GroupBy(f => f.Destination);
            //foreach (var group in groupFlights)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach( var f in group)
            //    {
            //        Console.WriteLine(f);
            //    }
            //}

            /* language LINQ */
            var req = from f in Flights
                      group f by f.Destination;
            foreach (var g in req)
            {
                Console.WriteLine("destination " + g.Key);
                foreach ( var f in g) Console.WriteLine(f);
            }
            return req;
                      
        }

        public Action<Plane> FlightDetailsDel; 
       

    }
}
