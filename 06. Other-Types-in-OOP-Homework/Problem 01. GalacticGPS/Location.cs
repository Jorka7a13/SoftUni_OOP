namespace _01.GalacticGPS
{
    public struct Location
    {
        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public Planet Planet { get; private set; }

        public override string ToString()
        {
            return this.Latitude + ", " + this.Longitude + " - " + this.Planet;
        }
    }
}