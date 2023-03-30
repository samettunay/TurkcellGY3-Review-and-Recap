namespace ReservationProject
{
    public class HotelReservation : Reservation, IReservationable
    {
        public int RoomNumber { get; set; }
        public void Reserve()
        {
            Console.WriteLine($"{ReservationDate} tarihinde {Customer.FirstName} tarafından {RoomNumber} numaralı oda rezerve edildi. ");
        }
    }
}
