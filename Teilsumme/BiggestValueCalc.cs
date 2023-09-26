using System;
using System.Linq;

namespace StockPrice
{
    public class BiggestValueCalc
    {
        private decimal[] stockPrices;

        public BiggestValueCalc(decimal[] prices)
        {
            stockPrices = prices;
        }

        public decimal FindMaxValue()
        {
            decimal maxValue = stockPrices.Max();
            return maxValue;
        }

        public decimal FindMinValue()
        {
            decimal maxIndex = Array.IndexOf(stockPrices, FindMaxValue());

            if (maxIndex >= 0)
            {
                decimal defMinValue;
                decimal minValue = stockPrices.Take((int)maxIndex).Min();
                defMinValue = FindMaxValue() - minValue;
                return defMinValue;
            }

            return 0;
        }
    }
}
