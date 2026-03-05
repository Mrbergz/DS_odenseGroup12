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

        public Booking(Room room, string title, DateTime startTime, DateTime endTime)
        {
            _room = room;
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
            BookingDate = startTime.Date;
        }

        public string GetBookingDetails()
        {
            return "===== BOOKING =====\n" +
            $"Titel: {Title}\n" +
            $"Lokale: {_room.Name}\n" +
            $"Dato: {BookingDate:dd-MM-yyyy}\n" +
            $"Start: {StartTime}\n" +
            $"Slut: {EndTime}\n";
        }
    }
}
