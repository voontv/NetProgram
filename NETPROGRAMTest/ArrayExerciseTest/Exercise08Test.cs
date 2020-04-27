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
    public class Exercise08Test
    {

        [TestMethod]
        public void TestCountNumbers()
        {
            var test = new Exercise08();

            Assert.AreEqual(test.CountNumbers(new int[] { 0, 3, 8, 9, 12, 15 }), 3);
            Assert.AreEqual(test.CountNumbers(new int[] { 120, 39, 5, 21, 7, 15 }), 2);
            Assert.AreEqual(test.CountNumbers(new int[] { 0, 13, 83, 92, 30, 15 }), 0);
        }
    }
}
