using System;

namespace Teilsumme
{
    class Program
    {
        static void Main(string[] args)
        {
            var rates = new double[] { 127.5, -0.5, 2, -1, 1, 3.5, -13, 7, -2, -6, -9, -21, -17, -5, 0.5, 4, -7, -12, 2.5, -3, 2 };
            double[] results = new double[rates.Length];
            
            results[0] = rates[0];

            for (int i = 1; i < rates.Length; i++)
            {
                results[i] = results[i - 1] + rates[i];
            }

            double maxPercentProfit = double.MinValue;
            int buyDay = 0;
            int sellDay = 0;
            double percentProfit = double.MinValue;
            

            for (int buy = 1; buy < results.Length; buy++)
            {
                for (int sell = buy + 1; sell < results.Length; sell++)
                {
                    double diff = results[sell - 1] - results[buy - 1];
                    percentProfit = (diff / results[buy]) * 100;

                    if (percentProfit > maxPercentProfit)
                    {
                        maxPercentProfit = percentProfit;
                        buyDay = buy;
                        sellDay = sell;
                    }
                }
            }

            Console.WriteLine($"Ein bester Einkaufstag wäre der {buyDay}. Börsentag gewesen, ein dazugehöriger Verkaufstag der {sellDay}. \nDer so realisierbare Gewinn wäre {maxPercentProfit} % vom eingesetzten Betrag gewesen.");
            Console.WriteLine($"Tag {buyDay} = {results[buyDay - 1]}");
            Console.WriteLine($"Tag {sellDay} = {results[sellDay - 1]}");
        }
    }
}
