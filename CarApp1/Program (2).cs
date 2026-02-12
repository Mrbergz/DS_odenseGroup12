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
            Console.WriteLine("Mærke".PadRight(18) + ": " + brand.PadRight(15));
            Console.WriteLine("Model".PadRight(18) + ": " + model.PadRight(15));
            Console.WriteLine("Årgang".PadRight(18) + ": " + year.ToString().PadRight(15));
            Console.WriteLine("Gear".PadRight(18) + ": " + gearType.ToString().PadRight(15));
            Console.WriteLine();

            Console.WriteLine("----- Brændstof & Kørsel -----");
            Console.WriteLine("Brændstofforbrug".PadRight(18) + ": " + fuelNeeded.ToString("F2").PadLeft(10) + " liter");
            Console.WriteLine("Pris".PadRight(18) + ": " + tripCost.ToString("F2").PadLeft(10) + " DKK");
            Console.WriteLine();

            Console.WriteLine("----- Kilometerstand -----");
            Console.WriteLine("Start".PadRight(18) + ": " + startkm.ToString("F2").PadLeft(10) + " km");
            Console.WriteLine("Slut".PadRight(18) + ": " + endkm.ToString("F2").PadLeft(10) + " km");

            Console.WriteLine("========================================");
            Console.ReadLine();
            
            // FULD SÆTNING 
            //Console.WriteLine($"{name} har valgt en {brand} {model} og er fra {year} som har et {gearType} gear");
        }

    }
}
