using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kurzpraktikum_HSG
{
    public class DatumFormatter
    {
        public const string CH = "CH";
        public const string US = "US";
        public const string ISO = "ISO";

        public static string FormatDatum(Datum date, string format)
        {
            switch (format)
            {
                case CH:
                    return $"{date.Tag}.{date.Monat}.{date.Jahr}";
                case US:
                    return $"{date.Monat}/{date.Tag}/{date.Jahr}";
                case ISO:
                    return $"{date.Jahr}-{date.Monat:D2}-{date.Tag:D2}";
                default:
                    throw new ArgumentException("Ungültiges Format");
            }
        }
    }
}
