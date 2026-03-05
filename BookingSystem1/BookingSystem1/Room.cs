using System.Collections.Generic;

namespace MeetingBooking
{
    internal class Room
    {
        private string name;
        private List<Booking> _bookings = new List<Booking>();

        public string Name => name;

        public Room(string name)
        {
            this.name = name;
        }

        public void AddBooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        public List<Booking> GetBookings()
        {
            return _bookings;
        }
    }
}
