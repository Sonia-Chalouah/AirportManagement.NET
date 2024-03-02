using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
      /*  public Flight(string destination, string departure, DateTime flightDate, int flightId, DateTime effectiveArrival, DateTime estimatedDuration)
        {
            Destination = destination;
            Departure = departure;
            FlightDate = flightDate;
            FlightId = flightId;
            EffectiveArrival = effectiveArrival;
            EstimatedDuration = estimatedDuration;
        }*/
      public Flight() { }   

        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set;}
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set;}
        public int EstimatedDuration { get; set; }
        public string Airline {  get; set; }
       
        public int PlaneId { get; set; }
        [ForeignKey("PlaneId")]
        public  virtual Plane Plane { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

}
