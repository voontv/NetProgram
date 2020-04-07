using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    
    [TestClass]
    public class Exercise11Test
    {
        [TestMethod]
        public void TestLengthBinaryNumber()
        {
            var test = new Exercise11();

            Assert.AreEqual(test.LengthBinaryNumber(0), 1);
            Assert.AreEqual(test.LengthBinaryNumber(23), 5);
            Assert.AreEqual(test.LengthBinaryNumber(78), 7);
        }

        [TestMethod]
        public void TestBinaryNumber()
        {
            var test = new Exercise11();

            Assert.AreEqual(test.BinaryNumberReverse(8), 1);
            Assert.AreEqual(test.BinaryNumberReverse(0), 0);
            Assert.AreEqual(test.BinaryNumberReverse(7), 7);
        }
    }
}
