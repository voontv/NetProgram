using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETPROGRAM.String_Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.String_ExerciseTest
{

    [TestClass]
    public class Exercise06Test
    {

        [TestMethod]
        public void TestOptimizeString()
        {
            var test = new Exercise06();

            Assert.AreEqual(test.OptimizeString("abcccceeeeeefd"), "abc4e6fd");
            Assert.AreEqual(test.OptimizeString("abbbbbbbbbbbbbc"), "ab13c");
            Assert.AreEqual(test.OptimizeString("abbbbbbbbbbbbbcaaa"), "ab13ca3");
        }
    }
}
