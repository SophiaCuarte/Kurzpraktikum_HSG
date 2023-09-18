using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurzpraktikum_HSG
{
    public class Datum
    {
        public int Tag { get; }
        public int Monat { get; }
        public int Jahr { get; }

     
        public Datum(int tag, int monat, int jahr)
        {
            Tag = tag;
            Monat = monat;
            Jahr = jahr;
        }
    }
}
