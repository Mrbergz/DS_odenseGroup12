class Program
{
    static void Main(string[] args) // PROGRAMMET STARTER
    {
        Console.Write("Skriv et tal for at finde alle primtal op til det: "); // VI ÅBNER MULIGHEDEN FOR IMPUT I CONSOLE
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++) // HER GENNEMGÅR VI ALLE TAL TIL N
        {
            if (ErPrimtal(i)) // KALDER FUNKTIONEN (ErPrimtal) - NEDENFOR
            {
                Console.Write(i + " "); // HER PRINTER VI SVARET, HVIS DER ER PRIMTAL
            }
        }
    }

    static bool ErPrimtal(int tal) // DETTE ER METODEN TIL AT FINDE PRIMTAL
    {
        if (tal <= 1) // TJEKKER FOR LIGEGYLDIGE TAL, ALTSÅ UNDER 1

            return false;

        int grænse = (int)Math.Sqrt(tal); // HER BEREGNER VI KVADRATRODEN

        for (int i = 2; i <= grænse; i++) // HER DIVIDER VI
        {
            if (tal % i == 0)
                return false;
        }

        return true; // HVIS DIVISION VAR OKAY, SÅ SIGER VI OK
    }
}
