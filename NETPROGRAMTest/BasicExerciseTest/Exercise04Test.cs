using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise04Test
    {

        [TestMethod]
        
        public void TestFiboInPositionN()
        {

            var test = new Exercise04();

            Assert.AreEqual(test.FiboInRangeN(6).Count, 5);
            Assert.AreEqual(test.FiboInRangeN(6)[4], 5);
            Assert.AreEqual(test.FiboInRangeN(2).Count, 3);
            Assert.AreEqual(test.FiboInRangeN(2)[2], 2);
            Assert.AreEqual(test.FiboInRangeN(1).Count, 2);
            Assert.AreEqual(test.FiboInRangeN(1)[1], 1);
        }
    }
}
