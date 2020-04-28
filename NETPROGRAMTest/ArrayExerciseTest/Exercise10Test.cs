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
    public class Exercise10Test
    {

        [TestMethod]
        public void TestIsSquareNumber()
        {
            var test = new Exercise10();

            Assert.IsTrue(test.IsSquareNumber(4));
            Assert.IsTrue(test.IsSquareNumber(1));
            Assert.IsTrue(test.IsSquareNumber(121));
            Assert.IsTrue(test.IsSquareNumber(625));
            Assert.IsFalse(test.IsSquareNumber(123));
            Assert.IsFalse(test.IsSquareNumber(4354));
            Assert.IsFalse(test.IsSquareNumber(23));
            Assert.IsFalse(test.IsSquareNumber(21));
        }

        [TestMethod]
        public void TestSumSquare()
        {
            var test = new Exercise10();

            Assert.AreEqual(test.SumSquare(new int[] { 1, 13, 16, 121, 9, 10 }), 147);
            Assert.AreEqual(test.SumSquare(new int[] { 0, 13, 116, 1621, 93, 10 }), 0);
        }
    }
}
