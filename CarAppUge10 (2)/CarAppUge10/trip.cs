using System;

namespace CarAppUge10
{
    internal class Trip
    {
        private Car _car;

        public double Distance { get; private set; }
        public DateTime TripDate { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public Trip(Car car, double distance, DateTime startTime, DateTime endTime)
        {
            _car = car;
            Distance = distance;
            StartTime = startTime;
            EndTime = endTime;
            TripDate = startTime.Date;
        }

        public TimeSpan CalculateDuration()
        {
            return EndTime - StartTime;
        }

        public double CalculateFuelUsed()
        {
            return Distance / _car.KmPerLiter;
        }

        public double CalculateTripPrice(double literPrice)
        {
            return CalculateFuelUsed() * literPrice;
        }

        public string GetTripDetails()
        {
            return
                "===== TUR DETALJER =====\n" +
                $"Dato: {TripDate:dd-MM-yyyy}\n" +
                $"Distance: {Distance} km\n" +
                $"Starttid: {StartTime}\n" +
                $"Sluttid: {EndTime}\n" +
                $"Varighed: {CalculateDuration()}\n" +
                $"Brændstofforbrug: {CalculateFuelUsed():F2} liter\n" +
                $"Km/l: {_car.KmPerLiter}\n";
        }
    }
}
