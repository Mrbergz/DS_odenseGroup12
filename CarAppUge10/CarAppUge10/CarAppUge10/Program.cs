using CarAppUge10;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opret bil
            Car myCar = new Car("Toyota", "Corolla", 2020, 'A', "Benzin", 22.5);

            // Tænd motoren
            myCar.StartEngine();

            // Opret liste af ture (Øvelse 3)
            List<Trip> trips = new List<Trip>
            {
                new Trip(myCar, 50,  DateTime.Now, DateTime.Now.AddHours(1)),
                new Trip(myCar, 30,  DateTime.Now, DateTime.Now.AddMinutes(30)),
                new Trip(myCar, 100, DateTime.Now, DateTime.Now.AddHours(2))
            };

            // Registrér turene i bilen
            foreach (Trip trip in trips)
            {
                myCar.Drive(trip);
            }

            // Menu loop
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("===== CAR APP MENU =====");
                Console.WriteLine("1. Vis bilens detaljer");
                Console.WriteLine("2. Start motor");
                Console.WriteLine("3. Kør en distance (simpel Drive)");
                Console.WriteLine("4. Opret og registrér en Trip");
                Console.WriteLine("5. Vis alle registrerede Trips");
                Console.WriteLine("0. Afslut");
                Console.Write("Vælg en funktion: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(myCar.GetCarDetails());
                        break;

                    case "2":
                        myCar.StartEngine();
                        Console.WriteLine("Motoren er nu tændt.");
                        break;

                    case "3":
                        Console.Write("Indtast distance i km: ");
                        double distance = Convert.ToDouble(Console.ReadLine());
                        myCar.Drive(distance);
                        break;

                    case "4":
                        Console.Write("Indtast distance for turen: ");
                        double tripDistance = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Indtast starttid (fx 2024-12-01 14:00): ");
                        DateTime start = DateTime.Parse(Console.ReadLine());

                        Console.Write("Indtast sluttid (fx 2024-12-01 15:00): ");
                        DateTime end = DateTime.Parse(Console.ReadLine());

                        Trip newTrip = new Trip(myCar, tripDistance, start, end);
                        myCar.Drive(newTrip);

                        Console.WriteLine("Turen er registreret.");
                        break;

                    case "5":
                        Console.WriteLine("===== REGISTREREDE TURE =====");

                        foreach (Trip t in myCar.GetTrips())
                        {
                            Console.WriteLine(t.GetTripDetails());
                        }
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        break;
                }

                Console.WriteLine("\nTryk Enter for at fortsætte...");
                Console.ReadLine();
            }
        }
    }
}
