using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{   
    public enum PlaneType{
        Boing,
        Airbus
    }
    public class Plane
    {
        public Plane()
        {
        }

        public Plane(PlaneType planeType , int capacity, DateTime manufactureDate )
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            this.planeType = planeType;
        }

        public int Capacity { get; set; }

        public DateTime ManufactureDate { get; set; }

        public int Planeid { get; set; }

        public PlaneType planeType { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string? ToString()
        {
            return "Capacity : " +Capacity + "ManufactureDate : " +ManufactureDate + "PlaneType : " + planeType;
        }
        
    }


}
