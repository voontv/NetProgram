using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{

    [TestClass]
    public class Exercise03Test
    {

        [TestMethod]
        public void TestShowMultiPrime()
        {
            var test = new Exercise03();

            Assert.AreEqual(test.ShowMultiPrime(9), "3 * 3");
            Assert.AreEqual(test.ShowMultiPrime(12), "2 * 2 * 3");
            Assert.AreEqual(test.ShowMultiPrime(7), "7");
            Assert.AreEqual(test.ShowMultiPrime(33), "3 * 11");
        }
    }

}
