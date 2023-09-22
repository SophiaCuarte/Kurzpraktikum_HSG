using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexPlantsFurniture
{
    public class Example
    {
        public static void Main()
        {
            NewPlants newPlants = new NewPlants();

            Input input = new Input();

            Dictionary<string, List<string>> plantsnew = newPlants.GroupPlants(input.Plants);

            foreach (var kvp in plantsnew)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }
        }
    }
}