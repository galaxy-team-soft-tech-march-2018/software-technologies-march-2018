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
            var distanceInMiles = double.Parse(Console.ReadLine());
            const double kilometersPerMile = 1.60934;
            var distanceInKilometers = distanceInMiles * kilometersPerMile;

            Console.WriteLine("{0:F2}", distanceInKilometers);

        }
    }
}
