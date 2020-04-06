using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise04Test
    {

        [TestMethod]
        public void testFiboInPositionN()
        {

            var test = new Exercise04();

            Assert.AreEqual(test.FiboInPositionN(1), 1);
            Assert.AreEqual(test.FiboInPositionN(2), 1);
            Assert.AreEqual(test.FiboInPositionN(5), 5);
            Assert.AreEqual(test.FiboInPositionN(6), 8);
        }

        [TestMethod]
        public void testshowRangeFibo()
        {

            var test = new Exercise04();

            Assert.AreEqual(test.showRangeFibo(0), "Can not find Fibo number same request");
            Assert.AreEqual(test.showRangeFibo(2), "1 1 2");
            Assert.AreEqual(test.showRangeFibo(4), "1 1 2 3");
            Assert.AreEqual(test.showRangeFibo(5), "1 1 2 3 5");
            Assert.AreEqual(test.showRangeFibo(6), "1 1 2 3 5");
        }
    }
}
