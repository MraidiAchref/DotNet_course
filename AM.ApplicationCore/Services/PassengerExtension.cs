using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static void UpperFullName(this Passenger passenger)
        {
            if (passenger == null)
                return;
            passenger.FirstName = char.ToUpper(passenger.FirstName[0]) + passenger.FirstName.Substring(1).ToLower();
            passenger.LastName = char.ToUpper(passenger.LastName[0]) + passenger.LastName.Substring(1).ToLower();
        }
    }
}
