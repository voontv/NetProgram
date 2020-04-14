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
    public class Exercise02Test
    {

        [TestMethod]
        public void TestSumMax()
        {
            var test = new Exercise02();

            Assert.AreEqual(test.SumMax(new int[] { 4, 5, 19, 20, 3, 11, 18, 21, 9 }), 60);
            Assert.AreEqual(test.SumMax(new int[] { 4, 5 }), 9);
        }
    }
}
