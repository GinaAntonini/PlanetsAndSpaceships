using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars", "Jupiter", "Saturn" };

            List<string> remainingPlanetsList = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(remainingPlanetsList);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");


            Console.WriteLine();
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
        }
    }
}


//Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
//Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.