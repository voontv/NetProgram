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
    public class Exercise14Test
    {

        [TestMethod]
        public void TestPowInt()
        {
            var test = new Exercise14();

            Assert.AreEqual(test.PowInt(2, 3), 8);
            Assert.AreEqual(test.PowInt(4, 4), 256);
        }

        [TestMethod]
        public void TestCountZeroFactorial()
        {
            var test = new Exercise14();

            Assert.AreEqual(test.CountZeroFactorial(8), 1);
            Assert.AreEqual(test.CountZeroFactorial(15), 3);
            Assert.AreEqual(test.CountZeroFactorial(25), 6);
            Assert.AreEqual(test.CountZeroFactorial(100), 23);
            Assert.AreEqual(test.CountZeroFactorial(400), 92);
            Assert.AreEqual(test.CountZeroFactorial(450), 104);
        }
    }
}
