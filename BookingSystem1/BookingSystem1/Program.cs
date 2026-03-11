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

            List<Room> rooms = new List<Room> { roomA, roomB, roomC };

            List<Booking> bookings = new List<Booking>
            {
                new Booking(roomA, "Kundemøde", DateTime.Now, DateTime.Now.AddHours(1)),
                new Booking(roomB, "Kundemøde", DateTime.Now.AddHours(2), DateTime.Now.AddHours(3)),
                new Booking(roomA, "Kundemøde", DateTime.Now.AddHours(4), DateTime.Now.AddHours(5))
            };

            roomA.AddBooking(bookings[0]);
            roomB.AddBooking(bookings[1]);
            roomA.AddBooking(bookings[2]);

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Book møde");
                Console.WriteLine("2. Se kalender");
                Console.WriteLine("3. Afslut");
                Console.Write("Vælg: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BookMeeting(rooms);
                        break;

                    case "2":
                        ShowCalendar(rooms);
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ugyldigt valg. Tryk Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void BookMeeting(List<Room> rooms)
        {
            Console.Clear();
            Console.WriteLine("===== BOOK MØDE =====");

            Console.Write("Titel: ");
            string title = Console.ReadLine();

            Console.Write("Starttid (fx 11/3-2026 14:00): ");
            DateTime start = DateTime.Parse(Console.ReadLine());

            Console.Write("Sluttid (fx 11/3-2026 15:00): ");
            DateTime end = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nVælg lokale:");
            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {rooms[i].Name}");
            }

            Console.Write("Valg: ");
            int roomChoice = int.Parse(Console.ReadLine()) - 1;

            Room selectedRoom = rooms[roomChoice];

            Booking booking = new Booking(selectedRoom, title, start, end);
            selectedRoom.AddBooking(booking);

            Console.WriteLine("\nMødet er booket!");
            Console.WriteLine("Tryk Enter for at fortsætte...");
            Console.ReadLine();
        }

        static void ShowCalendar(List<Room> rooms)
        {
            Console.Clear();
            Console.WriteLine("===== KALENDER =====");

            foreach (var room in rooms)
            {
                PrintRoomBookings(room);
            }

            Console.WriteLine("Tryk Enter for at fortsætte...");
            Console.ReadLine();
        }

        static void PrintRoomBookings(Room room)
        {
            Console.WriteLine($"\n--- {room.Name} ---");

            var bookings = room.GetBookings();

            if (bookings.Count == 0)
            {
                Console.WriteLine("Ingen bookinger.");
                return;
            }

            foreach (var booking in bookings)
            {
                Console.WriteLine(booking.GetBookingDetails());
            }
        }
    }
}
