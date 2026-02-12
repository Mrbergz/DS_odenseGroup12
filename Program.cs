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
         

        }
    }
}
