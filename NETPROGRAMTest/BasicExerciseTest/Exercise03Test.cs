using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{

    [TestClass]
    public class Exercise03Test
    {

        [TestMethod]
        public void TestIsPrime()
        {
            var test = new Exercise03();

            Assert.AreEqual(test.IsPrime(1), false);
            Assert.AreEqual(test.IsPrime(0), false);
            Assert.AreEqual(test.IsPrime(3), true);
            Assert.AreEqual(test.IsPrime(5), true);
            Assert.AreEqual(test.IsPrime(9), false);
            Assert.AreEqual(test.IsPrime(7), true);
        }

        [TestMethod]
        public void TestShowMultiPrime()
        {

            var test = new Exercise03();

            Assert.AreEqual(test.ShowMultiPrime(9), "3 * 3");
            Assert.AreEqual(test.ShowMultiPrime(12), "2 * 2 * 3");
            Assert.AreEqual(test.ShowMultiPrime(7), "7");
            Assert.AreEqual(test.ShowMultiPrime(33), "3 * 11");
            Assert.AreEqual(test.ShowMultiPrime(1), "1");
            Assert.AreEqual(test.ShowMultiPrime(0), "0");
        }
    }

}
