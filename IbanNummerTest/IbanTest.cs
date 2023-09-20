using IbanNummer;
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace IbanNummerTest
{
    [TestClass]
    public class ModuloCalc
    {
        [TestMethod]
        public void ModuloCalc_Test()
        {

            ModuloCalc moduloCalc = new ModuloCalc();
            string bankleitzahl = "09000000";
            string kontonummer = "156996358";
            string asciiResult = "121700";

            string expectedResult = "45";

            IbanNummer.ModuloCalc moduloCalculator = new IbanNummer.ModuloCalc();
            string moduloResult = moduloCalculator.CalcModulo(bankleitzahl, kontonummer, asciiResult);

            Assert.AreEqual(expectedResult, moduloResult);


        }
    }    
}