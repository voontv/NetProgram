using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETPROGRAM.String_Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.String_ExerciseTest
{

    [TestClass]
    public class Exercise09Test
    {

        [TestMethod]
        public void TestIsBarcodeEAN13()
        {
            var test = new Exercise09();

            Assert.IsTrue(test.IsBarcodeEAN13("8938505974194"));
            Assert.IsTrue(test.IsBarcodeEAN13("7501031311309"));
            Assert.IsTrue(test.IsBarcodeEAN13("0075678164125"));
            Assert.IsFalse(test.IsBarcodeEAN13("2593675213890"));
            Assert.IsFalse(test.IsBarcodeEAN13("2789031567812"));
        }
    }
}
