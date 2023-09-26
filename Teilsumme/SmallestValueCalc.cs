using System;
using System.Linq;

namespace StockPrice
{
    public class SmallestValueCalc
    {
        private decimal[] stockPricesmin;

        public SmallestValueCalc(decimal[] Minprices)
        {
            stockPricesmin = Minprices;
        }

        public decimal FindMinValue()
        {
            decimal minValuemin = stockPricesmin.Min();
            return minValuemin;
        }

        public decimal FindMaxValue()
        {
            decimal minValuemin = FindMinValue();
            decimal minIndexmin = Array.IndexOf(stockPricesmin, minValuemin);

            if (minIndexmin >= 0)
            {
                decimal defMaxValue;
                decimal maxValuemax = stockPricesmin.Skip((int)minIndexmin + 1).Max();
                defMaxValue = maxValuemax - minValuemin;
                return defMaxValue;
            }

            return 0;
        }
    }
}
