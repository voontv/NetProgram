using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETPROGRAM.ArrayExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.ArrayExerciseTest
{

    [TestClass]
    public class Exercise04Test
    {

        [TestMethod]
        public void TestIsPrime()
        {
            var test = new Exercise04();

            Assert.IsTrue(test.IsPrime(2));
            Assert.IsTrue(test.IsPrime(7));
            Assert.IsTrue(test.IsPrime(101));
            Assert.IsTrue(test.IsPrime(103));
            Assert.IsFalse(test.IsPrime(4));
            Assert.IsFalse(test.IsPrime(0));
            Assert.IsFalse(test.IsPrime(120));
        }

        [TestMethod]
        public void TestSumIPrime()
        {
            var test = new Exercise04();

            Assert.AreEqual(test.SumIPrime(new int[] { 1, 3, 3, 4, 10, 12, 11 }), 17);
            Assert.AreEqual(test.SumIPrime(new int[] { 121, 42, 78, 4, 10, 120, 119 }), 0);
            Assert.AreEqual(test.SumIPrime(new int[] { 1221, 420, 78, 34, 18, 120, 1190 }), 0);
        }
    }
}
