using Kurzpraktikum_HSG;

namespace Aufgabe1Test
{
    [TestClass]
    public class DatumFormatterTest
    {
        [TestMethod]
        public void Test_DatumKonstruktor_Sucess()
        {
            int tag = 18;
            int monat = 9;
            int jahr = 2023;
                  
            Datum date = new Datum(tag, monat, jahr);

            Assert.AreEqual(tag, date.Tag);
            Assert.AreEqual(monat, date.Monat);
            Assert.AreEqual(jahr, date.Jahr);
        }


        [TestMethod]
        public void Format_Date_US_Success()
        {
            Datum date = new Datum(18, 09, 2023);

            
            string formattedDate = DatumFormatter.FormatDatum(date, "US");

            
            Assert.AreEqual("9/18/2023", formattedDate);

        }


        [TestMethod]
        public void Format_Date_ISO_Sucess()
        {
            Datum date = new Datum(18, 09, 2023);

            string formattedDate = DatumFormatter.FormatDatum(date, "ISO");

            Assert.AreEqual("2023-09-18", formattedDate);
        }

        [TestMethod]
        public void Format_Date_CH_Success()
        {
            Datum date = new Datum(18, 09, 2023);

            string formattedDate = DatumFormatter.FormatDatum(date, "CH");

            Assert.AreEqual("18.9.2023", formattedDate);
        }


    }

}