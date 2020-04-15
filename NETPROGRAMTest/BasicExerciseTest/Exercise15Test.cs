using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise15Test
    {

        [TestMethod]
        public void TestCountFactorial()
        {
            var test = new Exercise15();

            Assert.AreEqual(test.CountFactorial(10), 7);
            Assert.AreEqual(test.CountFactorial(11), 8);
            Assert.AreEqual(test.CountFactorial(13), 10);
            Assert.AreEqual(test.CountFactorial(5), 3);
            Assert.AreEqual(test.CountFactorial(20), 19);
            Assert.AreEqual(test.CountFactorial(21), 20);
            Assert.AreEqual(test.CountFactorial(22), 22);
            Assert.AreEqual(test.CountFactorial(23), 23);
        }
    }
}
