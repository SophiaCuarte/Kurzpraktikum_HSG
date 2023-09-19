using System;

namespace IbanNummer
{
    public class AsciiConverter
    {
        public string GetAsciiValue(string input)
        {
            string result = "";

            foreach (char c in input)
            {
                int asciiValue = (int)c;
                int adjustedValue = asciiValue - 55;
                result += adjustedValue.ToString();
            }

            result += "00"; 

            return result;
        }
    }
}

