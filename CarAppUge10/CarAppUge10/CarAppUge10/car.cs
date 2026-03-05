namespace CarAppUge10
{
    internal class Car
    {
        //1. PRIVATE ATTRIBUTTER //
        private string brand;
        private string model;
        private int year;
        private char gear;
        private double odometer;
        private string fuelType;
        private bool isEngineOn;
        private double kmPerLiter;
        private double lastTripPrice;
        private double Distance;
        private DateTime TripDate;
        private DateTime StartTime;
        private DateTime EndTime;
        private Car Car;


        //2. PROPERTIES GET/SET) //
        public string Brand 
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        { 
            get { return year; } 
            set { year = value; } 
        }

        public char Gear
        { 
            get { return gear; }
            set { gear = value; }
        }

        public double Odometer
        {
            get { return odometer; }
            set { odometer = value; }
        }

        public FuelType FuelType { get; private set; }



        public Car(string brand, string model, int year, string licensePlate,

                   FuelType fuelType, double kmPerLiter)

        {

            // ... 

            FuelType = fuelType;

            KmPerLiter = kmPerLiter;

        }

        public double kmPerliter
        {
            get { return kmPerLiter; }
            set { kmPerLiter = value; }
        }

        public bool IsEngineOn
        { 
            get { return isEngineOn; } 
            set { isEngineOn = value; } 
        }

        //3. KONSTRUKTØR //
        public Car(string brand, string model, int year, char gear, string fuelType, double kmPerLiter)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.gear = gear;
            this.fuelType = fuelType;
            this.kmPerLiter = kmPerLiter;
            this.odometer = 0;
            this.IsEngineOn = false;

        }

        public Trip(Car car, double distance, DateTime startTime, DateTime endTime)
        {
            Car = car;
            Distance = distance;
            TripDate = startTime.Date;
            StartTime = startTime;
            EndTime = endTime;
        }

        //4. METODER //

        // SKAL KALDES FOR AT STARTE MOTOREN
        public void StartEngine()
        {
            IsEngineOn = true;
        }

        // SKAL KALDES FOR AT STOPPE MOTORTEN
        public void StopEngine()
        {
            IsEngineOn = false;
        }

        public void Drive(double distance)
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

        // Beregner og returnerer prisen for en køretur
        public double CalculateTripPrice(double distance, double literPrice, string fuelType)
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
        // Udskriver alle gemte biloplysninger
        public string GetCarDetails()
        {
            return "===== BILOPLYSNINGER =====\n" +
                $"Mærke: {brand}\n" +
                $"Model: {model}\n" +
                $"Årgang: {year}\n" +
                $"Gear: {gear}\n" +
                $"Kilometerstand: {odometer} km\n" +
                $"Km pr. liter: {kmPerLiter}\n" +
                $"Sidste turpris: {lastTripPrice:F2} DKK";
        }
        //Turens varighed
        //Beregn brændstofforbrug for turen
        //Beregn turens pris
        //Udskriv turens detaljer (distance, varighed, brændstofforbrug, pris)


    }
}
