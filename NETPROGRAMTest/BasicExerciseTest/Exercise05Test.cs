using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NETPROGRAMTest.BasicExerciseTest
{

    [TestClass]
    public class Exercise05Test
    {

        [TestMethod]
        public void testCheckNumberRequest()
        {
            var test = new Exercise05();

            Assert.AreEqual(test.checkNumberRequest(153), true);
        }

        [TestMethod]
        public void testShowListNumber()
        {
            var test = new Exercise05();
            var listTest = new List<int>() { 153 };

            Assert.AreEqual(test.showListNumber(154).IndexOf(0), listTest.IndexOf(0));
            Assert.AreEqual(test.showListNumber(154).Count, listTest.Count);
            Assert.AreEqual(test.showListNumber(10000).Count, 7);
        }
    }
}
