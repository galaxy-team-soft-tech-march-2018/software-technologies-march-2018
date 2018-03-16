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
            string nameProdukt = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            int sugarContentPer100ml = int.Parse(Console.ReadLine());

            // With (volume / 100.0) we get 1 ml from the product
            // The energy is 1 ml from the product multiply by energyContentPer100ml
            var energy = (volume / 100.0) * energyContentPer100ml;

            // The sugarContent is 1 ml from the product multiply by sugarContentPer100ml
            var sugarContent = (volume / 100.0) * sugarContentPer100ml;

            // We printing our results
            Console.WriteLine($"{volume}ml {nameProdukt}:");
            Console.WriteLine($"{energy}kcal, {sugarContent}g sugars");
        }
    }
}
