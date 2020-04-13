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
    public class Exercise16Test
    {

        [TestMethod]
        public void TestIsPrime()
        {
            var test = new Exercise16();

            Assert.AreEqual(test.IsPrime(4), false);
            Assert.AreEqual(test.IsPrime(7), true);
            Assert.AreEqual(test.IsPrime(232243), false);
            Assert.AreEqual(test.IsPrime(13), true);
            Assert.AreEqual(test.IsPrime(2), true);
            Assert.AreEqual(test.IsPrime(113), true);
        }

        [TestMethod]
        public void TestRangersPrime()
        {
            var test = new Exercise16();

            Assert.AreEqual(test.RangesPrime(20).Count, 8);
            Assert.AreEqual(test.RangesPrime(7).Count, 4);
            Assert.AreEqual(test.RangesPrime(11).Count, 5);
            Assert.AreEqual(test.RangesPrime(11,9).Count, 1);
            Assert.AreEqual(test.RangesPrime(11,5).Count, 2);
        }

        [TestMethod]
        public void TestFindNumber()
        {
            var test = new Exercise16();

            Assert.AreEqual(test.CheckNumber(30), true);
            Assert.AreEqual(test.CheckNumber(60), true);
            Assert.AreEqual(test.CheckNumber(90), true);
            Assert.AreEqual(test.CheckNumber(901), false);
            Assert.AreEqual(test.CheckNumber(2324), false);
            Assert.AreEqual(test.CheckNumber(15), true);
        }
    }
}
