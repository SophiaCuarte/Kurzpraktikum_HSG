using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexPlantsFurniture
{
    public class Input
    {
        public Dictionary<string, List<string>> Plants { get; set; }
       
        public Input()
        {
            Plants = new Dictionary<string, List<string>>();
            Plants["Blume"] = new List<string>(new string[] { "Blatt", "Stiel", "Blüte", "Grün" });
            Plants["Baum"] = new List<string>(new string[] { "Stamm", "Ast", "Blüte", "Grün", "Blatt" });
            Plants["Pilz"] = new List<string>(new string[] { "Hut", "Farbe", "Stiel" });
        }
    }
}
