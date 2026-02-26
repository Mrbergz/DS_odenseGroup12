namespace StenSaksPapir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Vælg: 1=Sten, 2=Saks, 3=Papir");
            int spillervalg = int.Parse(Console.ReadLine());

            int computervalg = random.Next(1, 3);
            //Konverter tal til tekst

            string tekstspiller = TalTilTekst(spillervalg);
            string tekstcomputer = TalTilTekst(computervalg);

            Console.WriteLine($"Computeren valgte {tekstcomputer}");
            Console.WriteLine($"Du valgte {tekstspiller}");

            //Bestem vinder

            string vinder = BestemVinder(spillervalg, computervalg);
            Console.WriteLine($"Vinderen er {vinder}");
        }
        static string TalTilTekst(int tal)
        {
            switch (tal)
            {
                case 1: return "Sten";
                case 2: return "Saks";
                case 3: return "Papir";
                default: return "Ukendt";
            }
        }
        static string BestemVinder(int spiller, int computer)
        {
            if (spiller == computer)
                return "Uafgjort";
            if ((spiller == 1 && computer == 2) ||
                (spiller == 2 && computer == 3) ||
                (spiller == 3 && computer == 1))
                return "spilleren";

            return "computeren";
        }
    }
}
