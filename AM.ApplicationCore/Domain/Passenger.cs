using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }


        [MinLength(3,ErrorMessage ="Min 3 caractères")]
        [MaxLength(25,ErrorMessage ="Max 25 caractères")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [RegularExpression("^[0-9]{8}$")]
        public int TelNumber { get; set; }

        [DataType(DataType.EmailAddress)]
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
