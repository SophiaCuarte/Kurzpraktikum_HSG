namespace IndexTryout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Plants = new Dictionary<string, string>();

            Plants.Add("Blatt", "Blume, Baum");
            Plants.Add("Stiel", "Blume, Pilz");

            foreach (KeyValuePair<string, string> feature in Plants)
            {
                Console.WriteLine( feature.Key + ": " + feature.Value);
            }

        }
    }
}