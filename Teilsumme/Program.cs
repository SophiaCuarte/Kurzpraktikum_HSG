using System;

namespace StockAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Geben Sie die Anfangszahl ein:");

            //Console.WriteLine("Wie viele Änderungen möchten Sie eingeben?");
            //int length = Convert.ToInt32(Console.ReadLine());

            var rates = new  double [] { 127.5, -0.5, 2, - 1, 1, 3.5, -13, 7, -2, -6, -9, -21, -17, -5, 0.5, 4, -7, -12, 2.5, -3, 2};

            double maxReturn = double.MinValue;
            double minRate = double.MinValue;
            int buyDay;
            int sellDay;


            for(var i = 0; i < rates.Length; i++)
            {

                if (i < rates.Length-1)
                {
                    minRate = rates[i] + rates[i + 1];
                    maxReturn = rates[i] - minRate;
                        }
                Console.WriteLine($"day: {i} - minRate {minRate} - maxReturn: {maxReturn}");

            }

            Console.ReadLine();

        }
    }
}
