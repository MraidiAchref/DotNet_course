// See https://aka.ms/new-console-template for more information

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;



//Plane plane = new Plane();
//plane.planeType = PlaneType.Airbus;
//plane.Capacity = 200 ;
//plane.ManufactureDate = new DateTime(2008, 11, 10);

//Plane plane2= new Plane(PlaneType.Boing , 300 , DateTime.Now );

//Plane plane3= new Plane { Capacity=400 , ManufactureDate=new DateTime(2020,01,02) , planeType=PlaneType.Airbus };

//Passenger passenger1 = new Traveller { FirstName = "Steave", LastName = "Job", EmailAddress = "steave@mail.com" };
// Console.WriteLine(passenger1.CheckProfile("Steave","Job") ) ;

//((Passenger)passenger1).PassengerType(); 

FlightMethods fm = new FlightMethods();
fm.Flights = TestData.listFlights;
//Console.WriteLine("********* Service *********");
////foreach(var flight in fm.GetFlightDates("Paris"))
////{
////    Console.WriteLine(flight);
////}

//Console.WriteLine(" destination filter");
//fm.GetFlights("destination", "paris");
//Console.WriteLine("effective arrival filter");
//fm.GetFlights("effectivearrival", "2022/02/01");

//Console.WriteLine("Programmed flight in next 7 days ");
//Console.WriteLine(fm.ProgrammedFlightNumber(new DateTime(2022,01,07) )   );

//Console.WriteLine("ordred flights by estimated duration");
//foreach (var fl in fm.OrderedDurationFlights() ) Console.WriteLine(fl);


//Console.WriteLine("most 3 aged travellers in flight 1");
//foreach(var t in fm.SeniorTravellers(TestData.flight1) ) Console.WriteLine(t);
////fm.ShowFlightDetails(TestData.BoingPlane);

//Console.WriteLine("flights grouped by destination");
//fm.DestinationGroupedFlights();

Traveller traveler1 = new Traveller { FirstName = "traveller1", LastName = "traveller1", EmailAddress = "traveller1.traveller1@gmail.com", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "no troubles", Nationality = "American" };
Console.WriteLine(traveler1);
traveler1.UpperFullName();
Console.WriteLine(traveler1);


