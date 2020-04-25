using Microsoft.VisualStudio.TestTools.UnitTesting;
using NETPROGRAM.ArrayExercise;

namespace NETPROGRAMTest.ArrayExerciseTest
{

    [TestClass]
    public class Exercise06Test
    {

        [TestMethod]
        public void TestPositionInArray()
        {
            var test = new Exercise06();

            Assert.AreEqual(test.PositionInArray(new int[] { 1, 3, 5, 7, 9 }, 8), -1);
            Assert.AreEqual(test.PositionInArray(new int[] { 1, 3, 5, 7, 9 }, 7), 3);
            Assert.AreEqual(test.PositionInArray(new int[] { 1, 9, 15, 32, 35, 37, 41, 49, 82, 100}, 37), 5);
        }
    }
}
