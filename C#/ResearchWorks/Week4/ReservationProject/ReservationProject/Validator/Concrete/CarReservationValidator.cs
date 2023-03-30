using ReservationProject.Validator.Abstract;

namespace ReservationProject.Validator.Concrete
{
    public class CarReservationValidator : ICarReservationValidator
    {
        public bool Validate(CarReservation carReservation)
        {
            return carReservation.ReservationDate >= DateTime.Now;
        }
    }
}
