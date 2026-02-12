namespace CarApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* definerer bilen
            string Brand1 = "Nissan";
            string Brand1Model = "Qashqai";
            int Brand1ModelYear = 2014;
            string GearType1 = "A";
            Console.WriteLine("Bilmærke" + Brand1);
            Console.WriteLine("Bilmodel" + Brand1Model);
            Console.WriteLine("Modelår" + Brand1ModelYear);
            Console.WriteLine("Gear type" + GearType1);


            // Enter for at komme videre

            Console.WriteLine("Indtast bilmærke");
            string model = Console.ReadLine();
            Console.WriteLine("Hvilken årgang");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvilken Geartype?");
            char GearType = Console.ReadLine()[0];

            Console.WriteLine("Bilmærke er "+ Brand1);
            Console.WriteLine("Bilmodel er " + Brand1Model);
            Console.WriteLine("Modelår er" + Brand1ModelYear);
            Console.WriteLine("Geartype er" + GearType1);
            Console.WriteLine($"Bilen er en {Brand1} {Brand1Model} fra {Brand1ModelYear}");

            // Console
            Console.Write("Navn: ");
            string name = Console.ReadLine();

            Console.Write("Indtast bilmærke: ");
            string brand = Console.ReadLine();

            Console.Write("Indtast bilmodel: ");
            string model = Console.ReadLine();

            Console.Write("Indtast årgang: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("indtast geartype (A= Automatisk, M for manuelt): ");
            char gearType = Console.ReadLine()[0];


        //Udskriver oplysninger

        Console.WriteLine("Navn: " + name);
        Console.WriteLine("NavnBilmærke: " + brand);
        Console.WriteLine("Bilmodel: " + model);
        Console.WriteLine("Årgang: " + year);
        Console.WriteLine("Gear: " + gearType);

        // Opsummeret
        Console.WriteLine($"{name} har valgt en {brand} {model} fra {year} der har et {gearType} gear.");
        Console.ReadLine();

            // operators
            int sum = 10 + 5; // sum=15
            int total = sum+ 3; // total=18

            //kombiner med ConsoleWriteLine
            Console.WriteLine($"Summen er {sum}")
                int difference = 10-3: // difference=7
                int rest = 100-75; // rest=25

                Console.WriteLine($"Differencen er" {difference});

                int produkt = 4 * 5;// produkt=20
                int areal = 10x10; // areal=100

                Console.WriteLine($"Arealet er {areal}");

                int kvotient = 20 / 4;  //kvotient=5
                int halv = 10 /; // halv=5


            Console.WriteLine($"Kvotienten er {kvotient}")

            // Beregn totalpris med moms og rabat
            Console.WriteLine("=== PRISBEREGNER ===");

                int produktPris = 200;
                int antal = 3;

                int subtotal = produktPris * antal;     // 600
                int rabat = subtotal / 10;              // 10% rabat = 60

                int prisEfterRabat = subtotal - rabat;  // 540
                int moms = prisEfterRabat / 4;          // 25% moms = 135

                int totalPris = prisEfterRabat + moms;  // 675

                Console.WriteLine($"Subtotal: {subtotal} kr");
                Console.WriteLine($"Rabat (10%): -{rabat} kr");
                Console.WriteLine($"Moms (25%): +{moms} kr");
                Console.WriteLine($"Total: {totalPris} kr");
            */
            {

                int a = 5;

                int b = 10;

                int sum = Adder(a, b);

                Console.WriteLine($"Sum: {sum}");

            }

            static int Adder(int x, int y)

            {

                int resultat = x + y;

                return resultat;

            }
        }
    }
}
