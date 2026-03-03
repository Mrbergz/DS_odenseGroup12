using CarAppUge10;

namespace CarApp
{
    internal class Program
    {

        private static object lastTripPrice;
        private static bool isEngineOn;
        private static string? brand;
        private static string? model;
        private static int year;
        private static char gearType;
        private static double odometer;
        private static double kmPerLiter;

        static void Main(string[] args)
        {

            // myCar = new Car("Mærke", "Model", Årgang, Gear, Brændstoftype, Kmprliter);
            Car myCar1 = new Car("VW", "UP", 2017, 'A', "Benzin", 15);

            // Styrer om programmet skal køre videre
            bool running = true;

            // Menuen kører i en while-løkke
            while (running)
            {
                Console.Clear();

                // Viser menuen for brugeren
                Console.WriteLine("===== CAR APP MENU =====");
                Console.WriteLine("1. Read Car Details");
                Console.WriteLine("2. Start Engine");
                Console.WriteLine("3. Drive");
                Console.WriteLine("4. Calculate Trip Price");
                Console.WriteLine("5. Is Palindrome (odometer)");
                Console.WriteLine("6. Print Car Details");
                Console.WriteLine("7. Print All Team Cars");
                Console.WriteLine("0. Exit");
                Console.Write("Vælg en funktion: ");

                // Læser brugerens valg
                string choice = Console.ReadLine();

                // switch bruges til at vælge handling
                switch (choice)
                {
                    case "1":
                        // Indlæser bilens oplysninger
                        ReadCarDetails();
                        break;

                    case "2":
                        // Tænder motoren
                        isEngineOn = true;
                        Console.WriteLine("Motoren er nu tændt.");
                        break;

                    case "3":
                        // Simulerer en køretur
                        Console.Write("Indtast distance i km: ");
                        double distance = Convert.ToDouble(Console.ReadLine());
                        myCar1.Drive(distance);
                        break;

                    case "4":
                        // Beregner prisen for en tur
                        Console.Write("Indtast distance i km: ");
                        double tripDistance = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Indtast literpris: ");
                        double literPrice = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Indtast brændstoftype (benzin/diesel): ");
                        string fuelType = Console.ReadLine();

                        // Gemmer returværdien
                        lastTripPrice = myCar1.CalculateTripPrice(tripDistance, literPrice, fuelType);
                        Console.WriteLine($"Pris for turen: {lastTripPrice:F2} DKK");
                        break;

                    case "5":
                        // Tjekker om kilometerstanden er et palindrom
                        bool result = IsPalindrome((int)odometer);
                        Console.WriteLine($"Er kilometerstanden et palindrom? {result}");
                        break;

                    case "6":
                        // Udskriver alle biloplysninger
                        myCar1.GetCarDetails();
                        break;

                    case "7":
                        // Udskriver alle teammedlemmer/biler
                        PrintAllTeamCars();
                        break;

                    case "0":
                        // Afslutter programmet
                        running = false;
                        break;

                    default:
                        // Håndterer ugyldigt input
                        Console.WriteLine("Ugyldigt valg.");
                        break;
                }

                // Pause så brugeren kan se output
                Console.WriteLine("\nTryk Enter for at fortsætte...");
                Console.ReadLine();
            }
        }

        // Indlæser og gemmer bilens oplysninger
        static void ReadCarDetails()
        {
            Console.Clear();
            Console.WriteLine("=== Indtast biloplysninger ===");

            Console.Write("Bilmærke: ");
            brand = Console.ReadLine();

            Console.Write("Bilmodel: ");
            model = Console.ReadLine();

            Console.Write("Årgang: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geartype (A/M): ");
            gearType = Console.ReadLine()[0];

            Console.Write("Kilometerstand: ");
            odometer = Convert.ToDouble(Console.ReadLine());

            Console.Write("Km pr. liter: ");
            kmPerLiter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Biloplysninger gemt.");
        }

        // Tjekker om et tal er et palindrom
        static bool IsPalindrome(int km)
        {
            // Konverterer tal til tekst
            string value = km.ToString();
            int left = 0;
            int right = value.Length - 1;

            // Sammenligner tegn forfra og bagfra
            while (left < right)
            {
                if (value[left] != value[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }


        // Udskriver alle teammedlemmer/biler vha. for-loop
        static void PrintAllTeamCars()
        {
            string[] teamCars = { "Audi", "BMW", "Citroen'", "Dacia" };

            Console.Clear();
            Console.WriteLine("===== TEAMETS BILER =====");

            // for-loop gennem arrayet
            for (int i = 0; i < teamCars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {teamCars[i]}");
            }
        }
    }
}
