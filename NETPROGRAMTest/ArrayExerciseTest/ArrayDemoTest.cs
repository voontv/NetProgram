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
    public class ArrayDemoTest

    {

        [TestMethod]
        public void TestSumArray()
        {
            var test = new ArrayDemo();

            Assert.AreEqual(test.SumArray(10), 0);
            Assert.AreEqual(test.SumArray(9), 16);
        }
    }
}
