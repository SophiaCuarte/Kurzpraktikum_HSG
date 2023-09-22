using System.Collections.Generic;
using System.Linq;

namespace IndexPlantsFurniture
{
    public class NewPlants
    {
        public Dictionary<string, List<string>> GroupPlants(Dictionary<string, List<String>> plants)
        {
            Dictionary<string, List<string>> plantsnew = new Dictionary<string, List<string>>();
          
            if (plants.Count > 0)
            {
                foreach (KeyValuePair<string, List<string>> item in plants)
                {
                    foreach(string str in item.Value)
                    {
                        if (!plantsnew.ContainsKey(str))
                        {
                            plantsnew[str] = new List<string>();
                        }
                        plantsnew[str].Add(item.Key);
                    }
                   
                }
            }
            return plantsnew;
        }
    }
}
