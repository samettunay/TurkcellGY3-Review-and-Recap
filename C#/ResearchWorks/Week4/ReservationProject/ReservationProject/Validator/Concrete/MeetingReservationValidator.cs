using ReservationProject.Validator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationProject.Validator.Concrete
{
    public class MeetingReservationValidator : IMeetingReservationValidator
    {
        public bool Validate(MeetingReservation meetingReservation)
        {
            return meetingReservation.HallNumber == 2;
        }
    }
}
