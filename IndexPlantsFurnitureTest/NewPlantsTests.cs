using IndexPlantsFurniture;

namespace IndexPlantsFurnitureTests
{
    [TestClass]
    public class NewPlantsTests
    {
        [TestMethod]
        public void NewPlantsTest()
        {
            var newPlant = new NewPlants();
            Input input = new Input();

            var result = newPlant.GroupPlants(input.Plants);
            var outputToCompare = GetOutput();
            
            foreach(var item in result)
            {
                foreach(var entry in outputToCompare)
                {
                    if(entry.Key == item.Key)
                    {
                        foreach (var text  in entry.Value) 
                        {
                            Assert.IsTrue(item.Value.Contains(text));
                        }
                    }
                }
            }

        }

        private Dictionary<string, List<string>> GetOutput()
        {
            return new Dictionary<string, List<string>>()
            {


                { "Blatt", new List<string>(){ "Blume", "Baum" } },
                { "Stiel", new List<string>(){ "Blume", "Pilz"} },
                { "Blüte", new List<string>(){ "Blume", "Baum"} },
                { "Grün", new List<string>(){ "Blume", "Baum"} },
                { "Stamm", new List<string>(){ "Baum"} },
                { "Ast", new List<string>(){ "Baum"} },
                { "Hut", new List<string>(){ "Pilz"} },
                { "Farbe", new List<string>(){ "Pilz"} }
            };

        }
    }
}
