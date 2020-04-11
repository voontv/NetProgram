using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise13Test
    {
        [TestMethod]
        public void TestcheckRangeIp()
        {
            var test = new Exercise13();

            Assert.IsTrue(test.CheckStringIp("123"));
            Assert.IsFalse(test.CheckStringIp("123", "456", "123", "1"));
            Assert.IsFalse(test.CheckStringIp("123", "456", "123"));
            Assert.IsTrue(test.CheckStringIp("123", "221", "123", "1"));
            Assert.IsTrue(test.CheckStringIp("123", "121", "12", "10"));
        }

        [TestMethod]
        public void TestFindRangeIP()
        {
            var test = new Exercise13();

            Assert.IsTrue(test.FindRangeIP("1234"));
            Assert.IsTrue(test.FindRangeIP("1921681100"));
            Assert.IsFalse(test.FindRangeIP("982123678987"));
            Assert.IsFalse(test.FindRangeIP("256123546721"));
            Assert.IsTrue(test.FindRangeIP("192168102104"));
        }
    }
}
