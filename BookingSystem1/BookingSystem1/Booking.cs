using System;

namespace MeetingBooking
{
    internal class Booking
    {
        private Room _room;

        public string Title { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public DateTime BookingDate { get; }
    }
}
