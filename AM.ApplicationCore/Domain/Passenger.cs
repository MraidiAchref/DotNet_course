using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }
        public ICollection<Flight> flights { get; set; }

        public bool CheckProfile(string firstName, string lastName)
        {
            return firstName == this.FirstName && lastName == this.LastName;
        }
        public bool CheckProfile(string firstName, string lastName , string email)
        {
            return email==null ? 
                firstName == this.FirstName && lastName == this.LastName
                :
                firstName == this.FirstName && lastName == this.LastName && email == this.EmailAddress;
                ;
        }
        
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a Passenger");
        }

        public override string? ToString()
        {
            return " name : "+FirstName + " / lastname : "+LastName  ;
        }
    }
}
