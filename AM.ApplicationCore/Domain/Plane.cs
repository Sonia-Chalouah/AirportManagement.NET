using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
       Boing, Airbus
    }
    public class Plane
    {

        [Required(ErrorMessage = "Capacity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Capacity must be a positive integer.")]
        public int Capacity
        { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set;}
        public PlaneType PlaneType{ get; set;}
        public virtual ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return $"plane: PlaneId {PlaneId}, ManufactureDate{ManufactureDate}";
        }
    }

}
