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
            //Add() Jupiter and Saturn at the end of the list.
            List<string> planetList = new List<string>() { "Mercury", "Mars", "Jupiter", "Saturn" };

            //Create another List that contains that last two planet of our solar system.
            List<string> remainingPlanetsList = new List<string>() { "Uranus", "Neptune" };

            //Combine the two lists by using AddRange().
            planetList.AddRange(remainingPlanetsList);

            //Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
            string[] rockyPlanets = planetList.GetRange(0, 3).ToArray();

            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");

            Console.WriteLine();
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine();
            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            var spacecraftDictionary = new Dictionary<string, Spacecraft>
            {
                { "firstKey", new Spacecraft { Name = "Maven"} },
                { "secondKey", new Spacecraft { Name = "Pioneer"} },
                { "thirdKey", new Spacecraft { Name = "Helios"} },
                { "fourthKey", new Spacecraft { Name = "Ulysses"} },
                { "fifthKey", new Spacecraft { Name = "Genesis"} },
                { "sixthKey", new Spacecraft { Name = "Mariner"} },
                { "seventhKey", new Spacecraft { Name = "Messenger"} },
                { "eighthKey", new Spacecraft { Name = "Venera"} },
                { "ninthKey", new Spacecraft { Name = "Galileo"} },
                { "tenthKey", new Spacecraft { Name = "Magellan"} },
            };
        }
    }
}

//Create another dictionary that will hold the name of a spacecraft that we have launched, and a list of names of the planets that it has visited.
//Remember that List is a Type just like native types (such as string, int, & bool) and your custom types(such as Movie, Dog, and Food). 
//They can be passed to anything, like a dictionary, as a Type.
//Iterate over your list of planets from above, and inside that loop, iterate over the dictionary. 
//Write to the console, for each planet, which satellites have visited which planet.






