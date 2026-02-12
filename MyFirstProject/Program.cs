namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mit første rigtige C#-program
            // En simpel lommeregner

            Console.WriteLine("=== Simpel Lommeregner ===");
            Console.WriteLine();

            // Få første tal fra brugeren
            Console.Write("Indtast første tal: ");
            string input1 = Console.ReadLine();
            double tal1 = double.Parse(input1);

            // Få andet tal fra brugeren
            Console.Write("Indtast andet tal: ");
            string input2 = Console.ReadLine();
            double tal2 = double.Parse(input2);

            // Beregn resultater
            double sum = tal1 + tal2;
            double differens = tal1 - tal2;
            double produkt = tal1 * tal2;
            double kvotient = tal1 / tal2;

            // Vis resultater
            Console.WriteLine();
            Console.WriteLine("=== Resultater ===");
            Console.WriteLine(tal1 + " + " + tal2 + " = " + sum);
            Console.WriteLine(tal1 + " - " + tal2 + " = " + differens);
            Console.WriteLine(tal1 + " * " + tal2 + " = " + produkt);
            Console.WriteLine(tal1 + " / " + tal2 + " = " + kvotient);

            Console.WriteLine();
            Console.WriteLine("Tak fordi du brugte lommeregneren!");
            Console.ReadLine();
        }
    }
}