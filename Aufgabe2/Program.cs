namespace Aufgabe2
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            
            string country = "";

            int bankCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bitte geben Sie ihren Bank Code ein: ", bankCode);

            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie ihre Accountnummer ein: ", accountNumber);

            Console.WriteLine("Geben sie ihre Land Erkennung ein (z.B. DE): ", country);
            country = Console.ReadLine();

            Console.WriteLine("ihre Iban: {0} {1} {2} ", bankCode, accountNumber, country);
        }
    }
}