//using AM.ApplicationCore.Domain;

//Plane plane = new Plane();
//plane.planeType = PlaneType.Airbus;
//plane.Capacity = 200;
//plane.ManufactureDate = new DateTime(2018, 11, 10);

//Console.WriteLine(plane.ToString());





using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;


//Plane plane2 = new Plane();
//{
//  PlaneType = PlaneType.Airbus;
//  Capacity = 150;
//  ManufacureDate = new DateTime(2015, 02, 03);
//};
//Console.WriteLine(plane2.ToString);


//polymorphisme par signature



//Console.WriteLine("******************** Testing signature polymorphisme");
// Passenger p1 = new Passenger(FirstName="steave",lastName="jobs"); 


//Console.WriteLine("******************** Testing inheritance");
//Staff s1 = new Staff(FirstName="Bill",LastName="GATES",EmailAddress="");
//Traveller t1 = new Traveller(FirstName = "Bill", LastName = "GATES", EmailAddress = "");
//t1.PassengerType();


ServiceFlight sf=new ServiceFlight();

//List<Flight> listFlights=new List<Flight>();    


//lel getflights
Console.WriteLine("**************GetFlights");
    sf.GetFlights("Destination", "Paris");