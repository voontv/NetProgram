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
    public class Exercise08Test
    {

        [TestMethod]
        public void TestRemoveCharRedundancy()
        {
            var test = new Exercise08();

            Assert.AreEqual(test.RemoveCharRedundancy("abbbbbbccccd eeffffddbc"), "abcd efdbc");
            Assert.AreEqual(test.RemoveCharRedundancy("abcdee ghhhheeeeeeeeee"), "abcde ghe");
        }
    }
}
