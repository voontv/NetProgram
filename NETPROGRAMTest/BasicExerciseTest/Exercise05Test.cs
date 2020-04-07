using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NETPROGRAMTest.BasicExerciseTest
{

    [TestClass]
    public class Exercise05Test
    {

        [TestMethod]
        public void TestPowInt()
        {
            var test = new Exercise05();

            Assert.AreEqual(test.PowInt(2, 3), 8);
            Assert.AreEqual(test.PowInt(3, 3), 27);
            Assert.AreEqual(test.PowInt(10, 4), 10000);
        }

        [TestMethod]
        public void TestCheckNumberRequest()
        {
            var test = new Exercise05();

            Assert.AreEqual(test.CheckNumberRequest(153), true);
            Assert.AreEqual(test.CheckNumberRequest(152), false);
        }

        [TestMethod]
        public void TestFindNumbers()
        {
            var test = new Exercise05();

            Assert.AreEqual(test.FindNumbers(154).Count, 1);
            Assert.AreEqual(test.FindNumbers(154)[0], 153);
            Assert.AreEqual(test.FindNumbers(10000).Count, 7);
        }
    }
}
