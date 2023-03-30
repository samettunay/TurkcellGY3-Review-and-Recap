namespace ReservationProject
{
    public class MeetingReservation : Reservation, IReservationable
    {
        public int HallNumber { get; set; }

        public void Reserve()
        {
            Console.WriteLine($"{ReservationDate} tarihinde {Customer.FirstName} tarafından {HallNumber} numaralı seminer alanı rezerve edildi. ");

        }
    }
}
