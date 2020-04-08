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

            Assert.AreEqual(test.PI(), 3.14146, 0.0001);
            Assert.AreEqual(test.PI(), 3.14139, 0.0001);
            Assert.AreEqual(test.PI(), 3.1413, 0.0001);
        }

    }
}
