using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            // We reading the information for the Hero
            string nameHero = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            // We printing the name of the Hero
            Console.WriteLine($"Name: {nameHero}");
            // We printing the Health and the Energy of the Hero
            // The Health and the Energy always start and end with '|' therefore |{0}{1}|
            // They contain so much '|' as current Health or Energy
            // They contain so much '.' as theirs maximum of Health or Energy subtract by theirs current Health or Energy
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maximumHealth - currentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maximumEnergy - currentEnergy));
        }
    }
}
