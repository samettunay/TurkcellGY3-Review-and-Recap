using ReservationProject.Validator.Abstract;

namespace ReservationProject.Validator.Concrete
{
    public static class Validator<T>
    {
        public static IReservationable ValidatorFactory(DateTime reservationDate, int reservedDay, int? hallNumber = null, int? roomNumber = null)
        {
            if (hallNumber.HasValue)
            {
                return new MeetingReservation() { 
                    ReservationDate = reservationDate,
                    HallNumber = hallNumber.Value,
                    ReservedDay = reservedDay
                };
            }
            else if(roomNumber.HasValue)
            {
                return new HotelReservation()
                {
                    ReservationDate = reservationDate,
                    RoomNumber = roomNumber.Value,
                    ReservedDay = reservedDay
                };
            }
            else
            {
                return new CarReservation()
                {
                    ReservationDate = reservationDate,
                    ReservedDay = reservedDay
                };
            }
        }
    }
}
