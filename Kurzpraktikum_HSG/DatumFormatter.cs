using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurzpraktikum_HSG
{
    public class DatumFormatter
    {

        public static string FormatDatum(Datum date, string format)
        {
            switch (format)
            {
                case "CH":
                    return $"{date.Tag}.{date.Monat}.{date.Jahr}";
                case "US":
                    return $"{date.Tag}/{date.Monat}/{date.Jahr}";
                case "ISO":
                    return $"{date.Jahr}-{date.Monat:D2}-{date.Tag:D2}";
                default:
                    throw new ArgumentException("Ungültiges Format");
            }
        }
    }
}
