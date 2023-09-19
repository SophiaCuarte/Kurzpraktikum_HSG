using System;

namespace IbanNummer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("IBAN-Berechnung");

            Console.Write("Geben Sie eine Zeichenkette ein (z.B., DE): ");
            string input = Console.ReadLine();

            AsciiConverter converter = new AsciiConverter();
            string asciiValues = converter.GetAsciiValue(input);

            Console.Write("Bankleitzahl: ");
            string bankleitzahl = Console.ReadLine();

            Console.Write("Kontonummer: ");
            string kontonummer = Console.ReadLine();

            ModuloCalc moduloCalculator = new ModuloCalc();
            string moduloResult = moduloCalculator.CalcModulo(bankleitzahl, kontonummer, asciiValues);

            string iban = $"{input}{moduloResult}{bankleitzahl}{kontonummer}";

            Console.WriteLine($"Die IBAN lautet: {iban}");
        }
    }
}
