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

        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }

        public double KmPerliter
        {
            get { return kmPerLiter; }
            set { kmPerLiter = value; }
        }

        public bool IsEngineOn
        { 
            get { return isEngineOn; } 
            set { isEngineOn = value; } 
        }

    }
}
