using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
     /*   public Staff(DateTime employementDate, string function, int salary)
        {

            EmployementDate = employementDate;
            Function = function;
            Salary = salary;
        }
     */
        public Staff()
        {
        }

        public DateTime EmployementDate { get; set; }
        
        public string  Function { get; set; }
        [DataType(DataType.Currency)]
        public int Salary { get; set; }


        public override void PassengerType()
        {
            Console.WriteLine("Im a traveller");
        }

    }
}
