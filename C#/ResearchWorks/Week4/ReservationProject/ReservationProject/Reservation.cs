using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationProject
{
    public class Reservation
    {
        public Customer Customer { get; set; }
        public DateTime ReservationDate { get; set; }
        public int ReservedDay { get; set; }
    }
}
