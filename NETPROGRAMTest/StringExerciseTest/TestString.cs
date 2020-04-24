using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETPROGRAM.StringExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.StringExerciseTest
{

    [TestClass]
    public class TestString
    {

        [TestMethod]
        public void TestCountLengthString()
        {
            var test = new Test();

            Assert.AreEqual(test.CountLengthString("String Exercise"), 15);
        }
    }
}
