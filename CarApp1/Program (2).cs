namespace CarProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvad hedder du?");
            string navn = Console.ReadLine();
            Console.WriteLine("Skriv bilmærke");
            string brand = Console.ReadLine();
            Console.WriteLine("Skriv model");
            string model = Console.ReadLine();
            Console.WriteLine("Hvilken årgang?");
            int år = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvilken geartype?");
            char geartype = Console.ReadLine()[0];
            Console.WriteLine($"{navn} har en {brand} {model} fra {år} som har geartype {geartype}!");
            
            Console.Write("Hvor langt køre bilen på literen?");​
            double kmPerLiter = Convert.ToDouble(Console.ReadLine());​​

            Console.Write("Hvor lang er køreturen?");​
            double distance = Convert.ToDouble(Console.ReadLine());​

            Console.Write("Hvad er prisen pr. liter brændstof i DKK?");​
            double fuelPrice = Convert.ToDouble(Console.ReadLine());​


            double fuelNeeded = distance / kmPerLiter;​
            double tripCost = fuelNeeded * fuelPrice;​

​
            Console.WriteLine($"Brændstofforbrug: {fuelNeeded.ToString("F2")} liter");​
            Console.WriteLine($"Pris for køreturen: {tripCost.ToString("F2")} DKK");​
            Console.WriteLine($"Køreturen på {distance} km koster {tripCost.ToString("F2")} DKK og bruger {fuelNeeded.ToString("F2")} liter brændstof.");​

            Console.Write("Hvad er bilens nuværende kilometerafstand?");​

            double startkm = Convert.ToDouble(Console.ReadLine());​​

            Console.Write("Hvor langt køre bilen på literen?");​

            double kmPerLiter = Convert.ToDouble(Console.ReadLine());​​

            Console.Write("Hvor lang er køreturen?");​

            double distance = Convert.ToDouble(Console.ReadLine());​​

            Console.Write("Hvad er prisen pr. liter brændstof i DKK?");​

            double fuelPrice = Convert.ToDouble(Console.ReadLine());​​

            double fuelNeeded = distance / kmPerLiter;​

            double tripCost = fuelNeeded * fuelPrice;​

            double endkm = startkm + distance;​

            Console.ReadLine();

            Console.WriteLine($"Brændstofforbrug: {fuelNeeded.ToString("F2")} liter");​

            Console.WriteLine($"Pris for køreturen: {tripCost.ToString("F2")} DKK");​

            Console.WriteLine($"Start Kilometerstand: {startkm.ToString("F2")}");​

            Console.WriteLine($"Slut kilometerstand: {endkm.ToString("F2")}");​

            Console.WriteLine($"Køreturen på {distance} km koster {tripCost.ToString("F2")} DKK og bruger {fuelNeeded.ToString("F2")} liter brændstof.");​

            Console.ReadLine();

        }
    }
}
