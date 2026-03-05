using System;
using System.Collections.Generic;
using MeetingBooking;

namespace MeetingBookingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room roomA = new Room("Lokale A");
            Room roomB = new Room("Lokale B");
            Room roomC = new Room("Lokale C");

            List<Booking> bookings = new List<Booking>
            {
                new Booking(roomA, "Lokale A", DateTime.Now, DateTime.Now.AddHours(1)),
                new Booking(roomB, "Lokale B", DateTime.Now.AddHours(2), DateTime.Now.AddHours(3)),
                new Booking(roomA, "Lokale C", DateTime.Now.AddHours(4), DateTime.Now.AddHours(5))
            };

            roomA.AddBooking(bookings[0]);
            roomB.AddBooking(bookings[1]);
            roomA.AddBooking(bookings[2]);
            
        }
    }
}
