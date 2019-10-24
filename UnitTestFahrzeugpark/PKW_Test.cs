using System;
using Fahrzeugpark;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFahrzeugpark
{
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_PKW_ueber_MaxGeschwindigkeit()
        {
            PKW pkw1 = new PKW("BMW", 260, 30000, 3);

            pkw1.StarteMotor();

            pkw1.Beschleunige(300);

            Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit);

        }
    }
}
