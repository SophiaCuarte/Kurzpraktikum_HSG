using System;
using System.Numerics;

namespace IbanNummer
{
    public class ModuloCalc
    {
        public string CalcModulo(string bankleitzahl, string kontonummer, string asciiResult)
        {
            string combinedString = bankleitzahl + kontonummer + asciiResult;
            BigInteger value = BigInteger.Parse(combinedString);

            BigInteger remainder = 98 - (value % 97);

            string result = remainder < 10 ? "0" + remainder.ToString() : remainder.ToString("00");

            return result;
        }
    }
}
