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
    public class Exercise05Test
    {

        [TestMethod]
        public void TestArrayUpMax()
        {
            var test = new Exercise05();

            Assert.AreEqual(test.ArrayUpMax(new int[] { 2, 3, 1, 5, 6}).Count, 1);
            Assert.IsTrue(test.ArrayUpMax(new int[] { 2, 3, 1, 5, 6}).ElementAt(0).Contains(5));
            Assert.AreEqual(test.ArrayUpMax(new int[] { 2, 3, 1, 5, 4, 6, 1}).Count, 3);
            Assert.IsTrue(test.ArrayUpMax(new int[] { 2, 3, 1, 5, 4, 6}).ElementAt(0).Contains(2));
            Assert.IsFalse(test.ArrayUpMax(new int[] { 2, 3, 1, 5, 4, 6}).ElementAt(0).Contains(1));
            Assert.IsFalse(test.ArrayUpMax(new int[] { 2, 3, 1, 5, 4, 6}).ElementAt(2).Contains(1));

        }
    }
}
