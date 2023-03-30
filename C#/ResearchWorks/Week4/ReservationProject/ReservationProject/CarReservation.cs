using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationProject
{
    public class CarReservation : Reservation, IReservationable
    {
        public string CarPlate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public void Reserve()
        {
            Console.WriteLine($"{ReservationDate} tarihinde {Customer.FirstName} tarafından {CarPlate} plakalı araç rezerve edildi. ");
        }
    }
}
