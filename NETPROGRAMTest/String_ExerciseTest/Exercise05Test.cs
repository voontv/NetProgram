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
    public class Exercise05Test
    {

        [TestMethod]
        public void TestIsSymmetry()
        {
            var test = new Exercise05();

            Assert.IsTrue(test.IsSymmetry("aaaaaaaaaa"));
            Assert.IsTrue(test.IsSymmetry("abcdcba"));
            Assert.IsFalse(test.IsSymmetry("abcdgfdfdcba"));
        }
    }
}
