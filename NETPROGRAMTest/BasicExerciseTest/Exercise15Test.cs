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
        public void TestFactorial()
        {
            var test = new Exercise15();

            Assert.AreEqual(test.Factorial(4), 24);
            Assert.AreEqual(test.Factorial(5), 120);
            Assert.AreEqual(test.Factorial(6), 720);
        }

        [TestMethod]
        public void TestPowInt()
        {
            var test = new Exercise15();

            Assert.AreEqual(test.PowInt(2, 3), 8);
            Assert.AreEqual(test.PowInt(4, 4), 256);
        }
        [TestMethod]
        public void TestCountZeroFactorial()
        {
            var test = new Exercise15();

            Assert.AreEqual(test.CountZeroFactorial(8), 1);
            Assert.AreEqual(test.CountZeroFactorial(15), 3);
            Assert.AreEqual(test.CountZeroFactorial(25), 6);
            Assert.AreEqual(test.CountZeroFactorial(100), 23);
            Assert.AreEqual(test.CountZeroFactorial(400), 92);
            Assert.AreEqual(test.CountZeroFactorial(450), 104);
        }

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
