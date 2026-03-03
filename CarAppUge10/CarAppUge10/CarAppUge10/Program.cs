namespace CarAppUge10
{
    internal class Program
    {
        // ===== FÆLLES VARIABLER =====
        // Gemmer grundlæggende biloplysninger
        static string name;
        static string brand;
        static string model;
        static int year;
        static char gearType;

        // Gemmer bilens aktuelle tilstand
        static double odometer;        // Kilometerstand
        static double kmPerLiter;       // Brændstofforbrug
        static bool isEngineOn = false; // Motorens status

        // Gemmer prisen for den senest beregnede tur
        static double lastTripPrice = 0;

        static void Main(string[] args)
        {
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
                        Drive(distance);
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
                        lastTripPrice = CalculateTripPrice(tripDistance, literPrice, fuelType);
                        Console.WriteLine($"Pris for turen: {lastTripPrice:F2} DKK");
                        break;

                    case "5":
                        // Tjekker om kilometerstanden er et palindrom
                        bool result = IsPalindrome((int)odometer);
                        Console.WriteLine($"Er kilometerstanden et palindrom? {result}");
                        break;

                    case "6":
                        // Udskriver alle biloplysninger
                        PrintCarDetails();
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

        // ===== 1. READ CAR DETAILS =====
        // Indlæser og gemmer bilens oplysninger
        static void ReadCarDetails()
        {
            Console.Clear();
            Console.WriteLine("=== Indtast biloplysninger ===");

            Console.Write("Navn: ");
            name = Console.ReadLine();

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

        // ===== 2. DRIVE =====
        // Simulerer kørsel og opdaterer kilometerstand
        static void Drive(double distance)
        {
            // Tjekker om motoren er tændt
            if (isEngineOn)
            {
                // Opdaterer odometer
                odometer += distance;
                Console.WriteLine($"Bilen kørte {distance} km.");
                Console.WriteLine($"Ny kilometerstand: {odometer} km.");
            }
            else
            {
                // Hvis motoren er slukket
                Console.WriteLine("Motoren er slukket. Start motoren før kørsel.");
            }
        }

        // ===== 3. CALCULATE TRIP PRICE =====
        // Beregner og returnerer prisen for en køretur
        static double CalculateTripPrice(double distance, double literPrice, string fuelType)
        {
            // Undgår division med 0
            if (kmPerLiter == 0)
            {
                Console.WriteLine("Fejl: kmPerLiter må ikke være 0.");
                return 0;
            }

            // Tjekker gyldig brændstoftype
            if (fuelType.ToLower() != "benzin" && fuelType.ToLower() != "diesel")
            {
                Console.WriteLine("Fejl: Brændstoftype skal være benzin eller diesel.");
                return 0;
            }

            // Beregner brændstofforbrug
            double fuelUsed = distance / kmPerLiter;

            // Returnerer den samlede pris
            return fuelUsed * literPrice;
        }

        // ===== 4. IS PALINDROME =====
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

        // ===== 5. PRINT CAR DETAILS =====
        // Udskriver alle gemte biloplysninger
        static void PrintCarDetails()
        {
            Console.Clear();
            Console.WriteLine("===== BILOPLYSNINGER =====");
            Console.WriteLine($"Navn: {name}");
            Console.WriteLine($"Mærke: {brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Årgang: {year}");
            Console.WriteLine($"Gear: {gearType}");
            Console.WriteLine($"Kilometerstand: {odometer} km");
            Console.WriteLine($"Km pr. liter: {kmPerLiter}");
            Console.WriteLine($"Sidste turpris: {lastTripPrice:F2} DKK");
        }

        // ===== 6. PRINT ALL TEAM CARS =====
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