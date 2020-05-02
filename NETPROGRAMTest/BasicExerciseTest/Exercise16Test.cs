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

            Assert.IsFalse(test.IsPrime(4));
            Assert.IsTrue(test.IsPrime(7));
            Assert.IsFalse(test.IsPrime(232243));
            Assert.IsTrue(test.IsPrime(13));
            Assert.IsTrue(test.IsPrime(2));
            Assert.IsTrue(test.IsPrime(113));
        }

        [TestMethod]
        public void TestRangersPrime()
        {
            var test = new Exercise16();

            Assert.AreEqual(test.RangesPrime(20).Count, 8);
            Assert.AreEqual(test.RangesPrime(7).Count, 4);
            Assert.AreEqual(test.RangesPrime(11).Count, 5);
        }

        [TestMethod]
        public void TestFindNumber()
        {
            var test = new Exercise16();

            Assert.IsFalse(test.CheckNumber(1));
            Assert.IsTrue(test.CheckNumber(2));
            Assert.IsTrue(test.CheckNumber(3));
            Assert.IsTrue(test.CheckNumber(5));
            Assert.IsTrue(test.CheckNumber(20));
            Assert.IsTrue(test.CheckNumber(10));
            Assert.IsTrue(test.CheckNumber(30));
            Assert.IsTrue(test.CheckNumber(60));
            Assert.IsTrue(test.CheckNumber(90));
            Assert.IsTrue(test.CheckNumber(100));
            Assert.IsFalse(test.CheckNumber(901));
            Assert.IsFalse(test.CheckNumber(2324));
            Assert.IsTrue(test.CheckNumber(15));
        }
    }
}
