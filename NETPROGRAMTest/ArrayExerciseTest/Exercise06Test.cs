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
            Assert.AreEqual(test.PositionInArray(new int[] { 9, 8, 5, 4, 3, 1, 0 }, 5), 2);
            Assert.AreEqual(test.PositionInArray(new int[] { 29, 17, 15, 8, 7, 6, 5, 4, 3, 2}, 5), 6);
        }
    }
}
