using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise12Test
    {
      
        [TestMethod]
        public void TestSymmetryNumber()
        {
            var test = new Exercise12();

            Assert.AreEqual(test.SymmetryNumber(0), true);
            Assert.AreEqual(test.SymmetryNumber(8), true);
            Assert.AreEqual(test.SymmetryNumber(828), true);
            Assert.AreEqual(test.SymmetryNumber(129), false);
            Assert.AreEqual(test.SymmetryNumber(1234321), true);
        }
    }
}
