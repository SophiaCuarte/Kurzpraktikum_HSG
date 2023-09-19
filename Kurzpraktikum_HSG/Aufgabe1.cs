using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Kurzpraktikum_HSG
{
    class Aufgabe1
    {
        static void Main(string[] args)
        {
            int Tag, Monat, Jahr;

            do
            {
                Console.Write("Geben Sie Ihren Tag ein: ");
            }
            while (!int.TryParse(Console.ReadLine(), out Tag) || Tag < 1 || Tag > 31);

            do
            {
                Console.Write("Geben Sie Ihren Monat ein: ");
            }
            while (!int.TryParse(Console.ReadLine(), out Monat) || Monat < 1 || Monat > 12);


            do
            {
                Console.Write("Geben Sie Ihre Jahreszahl ein: ");
            }
            while (!int.TryParse(Console.ReadLine(), out Jahr) && Jahr >= 1900 && Jahr <= 2100);

            Datum date = new Datum(Tag, Monat, Jahr);

            bool isValidFormat = false;

            while (!isValidFormat)
            {
                Console.Write("Geben Sie Ihr gewünschtes Format (CH, US, ISO) ein: ");
                string format = Console.ReadLine();

                if (format == DatumFormatter.CH)
                {
                    Console.WriteLine("CH Format: " + DatumFormatter.FormatDatum(date, DatumFormatter.CH));
                    isValidFormat = true;
                }
                else if (format == DatumFormatter.US)
                {
                    Console.WriteLine("US Format: " + DatumFormatter.FormatDatum(date, DatumFormatter.US));
                    isValidFormat = true;
                }
                else if (format == DatumFormatter.ISO)
                {
                    Console.WriteLine("ISO Format: " + DatumFormatter.FormatDatum(date, DatumFormatter.ISO));
                    isValidFormat = true;
                }
                else
                {
                    Console.WriteLine("Ungültiges Format, bitte achten Sie darauf, dass Sie in Großbuchstaben schreiben: " + format);
                }
            }
        }
    }
}
