using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int Flightid { get; set; }

        public string Destination { get; set; }

        public DateTime Departure { get; set; }

        public DateTime FlightDate { get; set; }

        public DateTime EffectiveArrival { get; set; }

        public int EstimatedDuration { get; set; }
        [ForeignKey("planeFK")]
        public Plane plane  { get; set; }

        // public int planeFK { get; set; }
        public  ICollection<Passenger> Passengers { get; set; }

        public string Airline { get; set; }

        public override string? ToString()
        {
            return  "destination : "+ this.Destination + "  flightDate : " + this.FlightDate.ToString("dd/MM/yyyy") +"  estimated duration :"+EstimatedDuration;
        }
    }
}
