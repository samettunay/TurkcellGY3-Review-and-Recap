using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationProject
{
    public static class ReservationLibrary
    {
        public static IReservationable ReservationFactory(DateTime reservationDate, int reservedDay, Customer customer, int? hallNumber = null, int? roomNumber = null)
        {
            if (hallNumber.HasValue)
            {
                return new MeetingReservation()
                {
                    ReservationDate = reservationDate,
                    HallNumber = hallNumber.Value,
                    ReservedDay = reservedDay,
                    Customer = customer
                };
            }
            else if (roomNumber.HasValue)
            {
                return new HotelReservation()
                {
                    ReservationDate = reservationDate,
                    RoomNumber = roomNumber.Value,
                    ReservedDay = reservedDay,
                    Customer = customer
                };
            }
            else
            {
                return new CarReservation()
                {
                    ReservationDate = reservationDate,
                    ReservedDay = reservedDay,
                    Customer = customer
                };
            }
        }
    }
}
