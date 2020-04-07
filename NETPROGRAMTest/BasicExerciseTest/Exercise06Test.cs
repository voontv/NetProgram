using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise06Test
    {

        [TestMethod]
        public void TestSumWithN()
        {
            var test = new Exercise06();

            Assert.AreEqual(test.SumWithN(3), 20);
            Assert.AreEqual(test.SumWithN(2), 8);
            Assert.AreEqual(test.SumWithN(1), 2);
        }
    }
}
