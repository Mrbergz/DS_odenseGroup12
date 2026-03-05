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
                new Booking(roomA, "Kundemøde", DateTime.Now, DateTime.Now.AddHours(1)),
                new Booking(roomB, "Kundemøde", DateTime.Now.AddHours(2), DateTime.Now.AddHours(3)),
                new Booking(roomA, "Kundemøde", DateTime.Now.AddHours(4), DateTime.Now.AddHours(5))
            };

            roomA.AddBooking(bookings[0]);
            roomB.AddBooking(bookings[1]);
            roomA.AddBooking(bookings[2]);

            Console.WriteLine("===== ALLE BOOKINGER =====");

            PrintRoomBookings(roomA);
            PrintRoomBookings(roomB);
            PrintRoomBookings(roomC);

            Console.WriteLine("\nTryk Enter for at afslutte...");
            Console.ReadLine();
        }

        static void PrintRoomBookings(Room room)
        {
            Console.WriteLine($"\n--- {room.Name} ---");

            foreach (var booking in room.GetBookings())
            {
                Console.WriteLine(booking.GetBookingDetails());
            }
        }
    }
}
