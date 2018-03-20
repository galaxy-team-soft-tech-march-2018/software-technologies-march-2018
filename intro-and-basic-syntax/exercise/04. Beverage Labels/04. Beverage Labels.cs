using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            // We reading the information for the product
            string productName = Console.ReadLine();
            int volumeOfTheProduct = int.Parse(Console.ReadLine());
            int energyPer100ml = int.Parse(Console.ReadLine());
            int sugarPer100ml = int.Parse(Console.ReadLine());

            // With (volume / 100.0) we get 1 ml from the product
            // The energy is 1 ml from the product multiply by energyContentPer100ml
            var totalEnergy = (volumeOfTheProduct / 100.0) * energyPer100ml;

            // The sugarContent is 1 ml from the product multiply by sugarContentPer100ml
            var totalSugar = (volumeOfTheProduct / 100.0) * sugarPer100ml;

            // We printing our results
            Console.WriteLine($"{volumeOfTheProduct}ml {productName}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}
