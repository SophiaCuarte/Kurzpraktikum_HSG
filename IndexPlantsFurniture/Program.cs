using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexPlantsFurniture
{
    public class Example
    {
        public static void Main()
        {
            List<string> plants = new List<string>() { "Blume", "Blatt", "Stiel", "Bluete", "Gruen" };
            List<string> plants2 = new List<string>() { "Baum", "Stamm", "Ast", "Bluete", "Gruen", "Blatt" };
            List<string> plants3 = new List<string>() { "Pilz", "Hut", "Farbe", "Stiel" };

            Dictionary<string, List<string>> plantsnew = new Dictionary<string, List<string>>();

            if (plants.Count > 0)
            {
                string key = plants[0];
                foreach (string value in plants.Skip(1))
                {
                    if (!plantsnew.ContainsKey(value))
                    {
                        plantsnew[value] = new List<string>();
                    }
                    plantsnew[value].Add(key);
                }
            }

            if (plants2.Count > 0)
            {
                string key = plants2[0];
                foreach (string value in plants2.Skip(1))
                {
                    if (!plantsnew.ContainsKey(value))
                    {
                        plantsnew[value] = new List<string>();
                    }
                    plantsnew[value].Add(key);
                }
            }

            if (plants3.Count > 0)
            {
                string key = plants3[0];
                foreach (string value in plants3.Skip(1))
                {
                    if (!plantsnew.ContainsKey(value))
                    {
                        plantsnew[value] = new List<string>();
                    }
                    plantsnew[value].Add(key);
                }
            }

            foreach (var kvp in plantsnew)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
