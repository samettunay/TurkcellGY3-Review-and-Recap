using ReservationProject;
using ReservationProject.Validator.Concrete;

Customer customer = new() {
    Id = 523,
    FirstName = "Samet",
    LastName = "TUNAY",
    Email = "hacisamettunay@gmail.com",
    PhoneNumber = 55555555
};

var reservation = ReservationLibrary.ReservationFactory(DateTime.Now, 1, customer);
reservation.Reserve();