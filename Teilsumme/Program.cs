using System;

namespace StockPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many days will you input?");
            int length = Convert.ToInt32(Console.ReadLine()); 

            decimal[] priceChanges = new decimal[length];

            Console.WriteLine("Enter the stock price on the first trading day");
            priceChanges[0] = Convert.ToDecimal(Console.ReadLine());

            for (int d = 1; d < length; d++) 
            {
                Console.WriteLine("Please enter the absolute price change from the previous day: ");
                priceChanges[d] = Convert.ToDecimal(Console.ReadLine());
            }

            StockPriceCalc calculator = new StockPriceCalc(priceChanges);
            decimal[] stockPrices = calculator.CalculateStockPrices();

            Console.WriteLine("Stock Prices:");

            for (int d = 0; d < length; d++) 
            {
                Console.WriteLine("Day " + (d + 1) + ": " + stockPrices[d]);
            }

            BiggestValueCalc analyzer = new BiggestValueCalc(stockPrices);

            decimal defminval = analyzer.FindMinValue();

            Console.WriteLine("defminval" + defminval);

            SmallestValueCalc finder = new SmallestValueCalc(stockPrices);

            decimal defmaxval = finder.FindMaxValue();

            Console.WriteLine("defminval" + defmaxval);

        }
    }
}
