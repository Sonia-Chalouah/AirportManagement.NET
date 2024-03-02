using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();


        /*    public List<DateTime> GetFlightDates(string destination)
            {
                List<DateTime> ls = new List<DateTime>();
                for (int j = 0; j < Flights.Count; j++)
                {
                    if (Flights[j].Destination.Equals(destination))
                        ls.Add(Flights[j].FlightDate);
                }
                return ls;
            }  */

        public List<DateTime> GetFlightDates(string destination)
        {
            var query1 = from F in Flights
                         where F.Destination.Equals(destination)
                         select F.FlightDate;
            //ABDA BSOURCE DE DONN2ES ELI HUWA FLIGHTS
           // var query2 = Flights.Where(Flight => F.Destination.Equals(Destination)).select(Flight=>F.FlightDate);

            return query1.ToList();    

        }
        public void GetFlightDates(Plane plane)
        {
            var Query1 = from F in Flights
                         where F.Plane == plane
                         select new { F.FlightDate, F.Destination };
            var Query2 =Flights.Where(F=>F.Plane == plane).Select(F=>new { F.FlightDate, F.Destination });
            foreach (var F in Query1)
            {
                Console.WriteLine("date de vol" + F.FlightDate + "destination" + F.Destination);
            }
        }


       public int ProgrammedFlightNumber(DateTime startDate) 
         {
            var query2 = from F in Flights
                         where DateTime.Compare(F.FlightDate, startDate) > 0 && (F.FlightDate - startDate).TotalDays <= 7
                         select F;
         //   var query3 = Flights.Where(F=> DateTime.Compare(F.FlightDate, startDate)) > 0 && (F.FlightDate, startDate).TotalDays <= 7;
            return query2.Count();                    
        }
          public double DurationAverage(string destination)
        {
            var query =( from Flight in Flights
                        where Flight.Destination == destination
                        select Flight.EstimatedDuration).Average();
            return query;
        }


        public List<Flight> OrderedDurationFlights()
        {
            var query4 = from Flight in Flights
                         orderby Flight.EstimatedDuration descending
                         select Flight;
            var query44 = Flights.OrderBy(F => F.EstimatedDuration);
            return query44.ToList();
        }


       public List<Traveller> SeniorTravellers(Flight flight) {

            var query42 = from p in flight.Passengers.OfType<Traveller>()
                          orderby p.BirthDate select p;
            return query42.Take(3).ToList();
                          
        }

       public IEnumerable<IGrouping<string,Flight>> DestinationGroupedFlights()
        {
            var query2 = from Flight in Flights
                         group Flight by Flight.Destination;
            var query22=Flights.GroupBy(f=>f.Destination);
            foreach(var grouping in query22)
            {
                Console.WriteLine("destination" + grouping.Key);

            foreach(var f in grouping){
                    Console.WriteLine("decollage" + f.FlightDate);
                    
                }
               
            }
            return query22;
        }
        public void GetFlights(string filterType,string filterValue)
        {
            switch(filterType)
            {
                case "Destination":
                    foreach(Flight f in Flights)
                    {
                        if (f.Destination.Equals(filterValue))
                            Console.WriteLine(f) ;
                    }
                    break;
                    
                case "FlightDate":
                    foreach (Flight f in Flights)
                    {
                        if (DateTime.Equals(f.FlightDate,DateTime.Parse(filterValue)))
                            Console.WriteLine(f);
                    }
                    break;

            }
           
        }
      
    }
    
}