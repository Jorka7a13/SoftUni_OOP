// Problem 1. Galactic GPS

// Create a struct "Location" that holds fields "latitude", "longitude" and "planet".

namespace _01.GalacticGPS
{
    using System;

    public class MainClass
    {
        public static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);

            Location school = new Location(15.833324, 44.035237, Planet.Jupiter);
            Console.WriteLine(school);
        }
    }
}