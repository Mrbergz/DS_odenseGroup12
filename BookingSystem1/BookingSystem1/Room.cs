using System.Collections.Generic;

namespace MeetingBooking
{
    internal class Room
    {
        private string name;
        private List<Booking> _bookings = new List<Booking>();

        public string Name => name;
    }
}
