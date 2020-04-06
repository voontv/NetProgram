using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NETPROGRAMTest.BasicExerciseTest
{

    [TestClass]
    public class Exercise05Test
    {

        [TestMethod]
        public void TestCheckNumberRequest()
        {
            var test = new Exercise05();

            Assert.AreEqual(test.CheckNumberRequest(153), true);
        }

        [TestMethod]
        public void TestShowListNumber()
        {
            var test = new Exercise05();

            Assert.AreEqual(test.ShowListNumber(154).Count, 1);
            Assert.AreEqual(test.ShowListNumber(154)[0], 153);
            Assert.AreEqual(test.ShowListNumber(10000).Count, 7);
        }
    }
}
