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
    public class Exercise03Test
    {

        [TestMethod]
        public void TestSubtractArray()
        {
            var test = new Exercise03();

            Assert.AreEqual(test.SubtractArray(new int[] { 2, 4, 7, 9, 12, 0 }), 2);
            Assert.AreEqual(test.SubtractArray(new int[] { 11, 4, 27, 31, 12, 0 }), -53);
        }
    }
}
