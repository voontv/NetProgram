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

            Assert.AreEqual(test.SplitArray(new int[] { 4, 5, 7, 9, 12, 18, 20, 4, 9 }, 2).Length, 5);
            Assert.AreEqual(test.SplitArray(new int[] { 4, 5, 7, 9, 12, 18, 20, 4, 9 }, 2).ElementAt(4).ElementAt(0), 9);
            Assert.AreEqual(test.SplitArray(new int[] { 16, 5, 17, 9, 762, 18, 20, 4, 9, 20 }, 3).Length, 4);
            Array.Equals(test.SplitArray(new int[] { 16, 5, 17, 9, 762, 18, 20, 4, 9, 20 }, 3),
                new[] {
                    new []{16, 5, 17},
                    new []{9, 762, 18},
                    new []{20, 4, 9},
                    new []{20},
                });

        }
    }
}
