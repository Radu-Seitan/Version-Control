using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            SolarSystem solarSystem = new(Galaxy.Andromeda);

            solarSystem.CentralStar = new Supernova("xa12", 123.4f, 5687990.9f, 98499839);
            solarSystem.Planets.Add(new TerrestrialPlanet("Earth", 123123.2312f));
            solarSystem.Planets.Add(new TerrestrialPlanet("Earth2", 123.12f));
            solarSystem.Planets.Add(new TerrestrialPlanet("Earth3", 113.2312f));
            solarSystem.Planets.Add(new TerrestrialPlanet("Earth4", 1.2312f));

            solarSystem.Go();

            Dictionary<Planet, float> myDictionary = new();

            foreach(Planet planet in solarSystem.Planets)
            {
                myDictionary.Add(planet, planet.Mass);
            }

            foreach(KeyValuePair<Planet,float> entry in myDictionary)
            {
                Console.WriteLine($"{entry.Key}  {entry.Value}");
            }
            
        }
    }
}
