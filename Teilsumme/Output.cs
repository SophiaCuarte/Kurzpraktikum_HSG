using StockPrice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teilsumme
{
    internal class Output
    {
        BiggestValueCalc analyzer = new BiggestValueCalc(Program.stockPrices);

        decimal defminval = analyzer.FindMinValue();

        SmallestValueCalc finder = new SmallestValueCalc(stockPrices);

        decimal defmaxval = finder.FindMaxValue();
    }
}
