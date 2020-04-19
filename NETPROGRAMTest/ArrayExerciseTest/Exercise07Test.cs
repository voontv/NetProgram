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
    public class Exercise07Test
    {

        [TestMethod]
        public void TestSplitArray()
        {
            var test = new Exercise07();

            Assert.AreEqual(test.SplitArray(new int[] { 4, 5, 7, 9, 12, 18, 20, 4, 9 }, 2).Count, 5);
            Assert.AreEqual(test.SplitArray(new int[] { 4, 5, 7, 9, 12, 18, 20, 4, 9 }, 2).ElementAt(4).ElementAt(0), 9);
            Assert.AreEqual(test.SplitArray(new int[] { 16, 5, 17, 9, 762, 18, 20, 4, 9, 20 }, 3).Count, 4);
            Assert.IsTrue(test.SplitArray(new int[] { 16, 5, 17, 9, 762, 18, 20, 4, 9, 20 }, 3).ElementAt(1).Contains(762));
        }
    }
}
