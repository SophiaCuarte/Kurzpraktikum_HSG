

var dicPlant = new Dictionary<string, List<string>>() {
    {"Blume", new List<string> { "Blatt", "Stiel", "Blüte", "Grün" } },
    {"Baum", new List<string> { "Blatt", "Ast", "Blüte", "Grün", "Stamm" } },
    {"Pilz", new List<string> { "Hut", "Farbe", "Stiel" } }
};

var dicFurniture = new Dictionary<string, List<string>>() {
    {"Tisch", new List<string> { "Holz", "Beine" } },
    {"Schrank", new List<string> { "Holz", "Tür" } },
    {"Stuhl", new List<string> { "Lehne", "Beine", "Sitzfläche" } },
    {"Bett", new List<string> { "Holz", "Beine", "Laken" } }
};

Dictionary<string, List<string>> Index(Dictionary<string, List<string>> defLst) =>
    defLst.SelectMany(features => features.Value).GroupBy(features => features).Select(features => features.Key)
    .Select(u => new {
        unique = u,
        lst = defLst.Where(d => d.Value.Contains(u))
    .Select(features => features.Key).ToList()
    }).ToDictionary(features => features.unique, features => features.lst);

void Print(Dictionary<string, List<string>> dic) => Index(dic).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {string.Join(", ", x.Value)}"));

Print(dicPlant);
Print(dicFurniture);