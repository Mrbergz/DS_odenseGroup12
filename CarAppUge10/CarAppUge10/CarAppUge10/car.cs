using System;
using System.Collections.Generic;

namespace CarAppUge10
{
    internal class Car
    {
        // PRIVATE ATTRIBUTTER
        private string brand;
        private string model;
        private int year;
        private char gear;
        private double odometer;
        private bool isEngineOn;
        private double kmPerLiter;
        private double lastTripPrice;

        private List<Trip> _trips = new List<Trip>();

        // PROPERTIES
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public char Gear { get => gear; set => gear = value; }
        public double Odometer { get => odometer; set => odometer = value; }
        public FuelType FuelType { get; private set; }
        public double KmPerLiter { get => kmPerLiter; set => kmPerLiter = value; }
        public bool IsEngineOn { get => isEngineOn; set => isEngineOn = value; }

        // KONSTRUKTØR
        public Car(string brand, string model, int year, char gear, string fuelType, double kmPerLiter)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.gear = gear;
            this.kmPerLiter = kmPerLiter;
            this.odometer = 0;
            this.isEngineOn = false;

            FuelType = Enum.Parse<FuelType>(fuelType, true);
        }

        // METODER
        public void StartEngine() => isEngineOn = true;
        public void StopEngine() => isEngineOn = false;

        public void Drive(double distance)
        {
            if (!isEngineOn)
            {
                Console.WriteLine("Motoren er slukket. Start motoren før kørsel.");
                return;
            }

            odometer += distance;
            Console.WriteLine($"Bilen kørte {distance} km.");
            Console.WriteLine($"Ny kilometerstand: {odometer} km.");
        }

        public void Drive(Trip newTrip)
        {
            if (!isEngineOn)
            {
                Console.WriteLine("Motoren er slukket. Start motoren før kørsel.");
                return;
            }

            // Opdater odometer
            odometer += newTrip.Distance;

            // Gem turen
            _trips.Add(newTrip);

            Console.WriteLine($"Turen på {newTrip.Distance} km er registreret.");
            Console.WriteLine($"Ny kilometerstand: {odometer} km.");
        }

        public double CalculateTripPrice(double distance, double literPrice, string fuelType)
        {
            if (kmPerLiter == 0)
            {
                Console.WriteLine("Fejl: kmPerLiter må ikke være 0.");
                return 0;
            }

            if (fuelType.ToLower() != "benzin" && fuelType.ToLower() != "diesel")
            {
                Console.WriteLine("Fejl: Brændstoftype skal være benzin eller diesel.");
                return 0;
            }

            double fuelUsed = distance / kmPerLiter;
            lastTripPrice = fuelUsed * literPrice;

            return lastTripPrice;
        }

        public string GetCarDetails()
        {
            return
                "===== BILOPLYSNINGER =====\n" +
                $"Mærke: {brand}\n" +
                $"Model: {model}\n" +
                $"Årgang: {year}\n" +
                $"Gear: {gear}\n" +
                $"Kilometerstand: {odometer} km\n" +
                $"Km pr. liter: {kmPerLiter}\n" +
                $"Sidste turpris: {lastTripPrice:F2} DKK";
        }

        public List<Trip> GetTrips()
        {
            return _trips;
        }
    }
}
