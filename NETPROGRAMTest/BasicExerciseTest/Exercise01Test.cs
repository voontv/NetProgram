using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise01Test
    {
       
        [TestMethod]
        public void UCLNTest()
        {
            var test = new Exercise01();

            Assert.AreEqual(test.UCLN(12, 8), 4);
            Assert.AreEqual(test.UCLN(9, 5), 1);
            Assert.AreNotEqual(test.UCLN(3, 5), 5);
            Assert.AreEqual(test.UCLN(14, 8), 2);
        }

        [TestMethod]
        public void BCNNTest()
        {
            var test = new Exercise01();

            Assert.AreEqual(test.BCNN(14, 8), 56);
            Assert.AreEqual(test.BCNN(1, 8), 8);
            Assert.AreEqual(test.BCNN(1, 0), 0);
            Assert.AreNotEqual(test.BCNN(1, 0), 8);
        }
    }
}
