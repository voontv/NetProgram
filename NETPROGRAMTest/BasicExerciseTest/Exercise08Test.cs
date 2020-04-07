using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise08Test
    {

        [TestMethod]
        public void TestPI()
        {
            var test = new Exercise08();

            Assert.AreEqual(Math.Round(test.PI(),5), 3.14139);
            Assert.AreEqual(Math.Round(test.PI(),6), 3.141393);
            Assert.AreEqual(Math.Round(test.PI(),7), 3.1413927);
        }

    }
}
