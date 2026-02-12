namespace CarApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // BILENS OPLYSNINGER  
            Console.Write("Navn: ");
            string name = Console.ReadLine();

            Console.Write("Indtast bilmærke: ");
            string brand = Console.ReadLine();

            Console.Write("Indtast bilmodel: ");
            string model = Console.ReadLine();

            Console.Write("Indtast årgang: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast geartype (A = Automatisk, M for manuelt): ");
            char gearType = Console.ReadLine()[0];

            // BRÆNDSTOF OPLYSNINGER
            Console.Write("Hvad er bilens nuværende kilometerafstand?");
            double startkm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hvor langt køre bilen på literen?");
            double kmPerLiter = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hvor lang er køreturen?");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hvad er prisen pr. liter brændstof i DKK?");
            double fuelPrice = Convert.ToDouble(Console.ReadLine());

            double fuelNeeded = distance / kmPerLiter;
            double tripCost = fuelNeeded * fuelPrice;
            double endkm = startkm + distance;

            Console.WriteLine("========================================");
            Console.WriteLine("              KØRSELSRAPPORT             ");
            Console.WriteLine("========================================");

            Console.WriteLine($"Navn: {name}");
            Console.WriteLine();

            Console.WriteLine("----- Biloplysninger -----");
            Console.WriteLine($"Mærke           : {brand}");
            Console.WriteLine($"Model           : {model}");
            Console.WriteLine($"Årgang          : {year}");
            Console.WriteLine($"Gear            : {gearType}");
            Console.WriteLine();

            Console.WriteLine("----- Brændstof & Kørsel -----");
            Console.WriteLine($"Brændstofforbrug: {fuelNeeded.ToString("F2")} liter");
            Console.WriteLine($"Pris            : {tripCost.ToString("F2")} DKK");
            Console.WriteLine();

            Console.WriteLine("----- Kilometerstand -----");
            Console.WriteLine($"Start           : {startkm.ToString("F2")} km");
            Console.WriteLine($"Slut            : {endkm.ToString("F2")} km");

            Console.WriteLine("========================================");

            Console.ReadLine();
            // FULD SÆTNING 
            //Console.WriteLine($"{name} har valgt en {brand} {model} og er fra {year} som har et {gearType} gear");
        }

    }
}