using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise02Test
    {
        
        [TestMethod]
        public void sumNumberIntTest()
        {

            var test = new Exercise02();

            Assert.AreEqual(test.sumNumberInt(129), 12);
            Assert.AreEqual(test.sumNumberInt(500), 5);
            Assert.AreEqual(test.sumNumberInt(9), 9);
            Assert.AreNotEqual(test.sumNumberInt(91), 9);
            
        }
    }
}
