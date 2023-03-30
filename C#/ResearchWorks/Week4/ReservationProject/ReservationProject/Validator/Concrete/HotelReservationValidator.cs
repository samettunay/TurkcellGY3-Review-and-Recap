using ReservationProject.Validator.Abstract;

namespace ReservationProject.Validator.Concrete
{
    public class HotelReservationValidator : IHotelReservationValidator
    {
        public bool Validate(HotelReservation hotelReservation)
        {
            return hotelReservation.RoomNumber == 5;
        }
    }
}
