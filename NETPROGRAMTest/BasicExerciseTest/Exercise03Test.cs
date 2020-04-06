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

            Assert.AreEqual(test.isPrime(1), false);
            Assert.AreEqual(test.isPrime(0), false);
            Assert.AreEqual(test.isPrime(3), true);
            Assert.AreEqual(test.isPrime(5), true);
            Assert.AreEqual(test.isPrime(9), false);
            Assert.AreEqual(test.isPrime(7), true);
        }

        [TestMethod]
        public void testShowMultiPrime()
        {

            var test = new Exercise03();

            Assert.AreEqual(test.showMultiPrime(9), "3 * 3");
            Assert.AreEqual(test.showMultiPrime(12), "2 * 2 * 3");
            Assert.AreEqual(test.showMultiPrime(7), "7");
            Assert.AreEqual(test.showMultiPrime(33), "3 * 11");
            Assert.AreEqual(test.showMultiPrime(1), "1");
            Assert.AreEqual(test.showMultiPrime(0), "0");
        }
    }

}
