using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise08Test
    {

        [TestMethod]
        public void TestPI()
        {
            var test = new Exercise08();

            Assert.AreEqual(test.PI(), 3.14139);
        }

    }
}
