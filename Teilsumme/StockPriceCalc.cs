using System;
using System.Linq;

namespace StockPrice
{
    public class StockPriceCalc
    {
        private decimal[] stockPrices;

        public StockPriceCalc(decimal[] prices)
        {
            stockPrices = prices;
        }

        public decimal[] CalculateStockPrices()
        {
            decimal[] stockPrices = new decimal[this.stockPrices.Length];
            stockPrices[0] = this.stockPrices[0];

            for (int d = 1; d < this.stockPrices.Length; d++) 
            {
                stockPrices[d] = stockPrices[d - 1] + this.stockPrices[d];
            }

            return stockPrices;
        }
    }
}
