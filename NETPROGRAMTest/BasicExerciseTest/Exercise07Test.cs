using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise07Test
    {

        [TestMethod]
        public void TestFactorial()
        {
            var test = new Exercise07();

            Assert.AreEqual(test.Factorial(3), 6);
            Assert.AreEqual(test.Factorial(0), 1);
            Assert.AreEqual(test.Factorial(4), 24);
        }
    }
}
