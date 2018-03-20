using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            // We reading the distance in miles
            var distanceInMiles = double.Parse(Console.ReadLine());
            // It is a constant for converting miles to kilometers
            const double kilometersPerMile = 1.60934;
            // We multiply the constant with the miles
            var distanceConvertedInKilometers = distanceInMiles * kilometersPerMile;
            // We printing the result to 2th decimal place
            Console.WriteLine("{0:F2}", distanceConvertedInKilometers);
        }
    }
}
