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

            Assert.AreEqual(test.CheckStringIp("123"), true);
            Assert.AreEqual(test.CheckStringIp("123", "456", "123", "1"), false);
            Assert.AreEqual(test.CheckStringIp("123", "456", "123"), false);
            Assert.AreEqual(test.CheckStringIp("123", "221", "123", "1"), true);
            Assert.AreEqual(test.CheckStringIp("123", "121", "12", "10"), true);
        }

        [TestMethod]
        public void TestFindRangeIP()
        {
            var test = new Exercise13();

            Assert.AreEqual(test.FindRangeIP("1234").Count, 1);
            Assert.AreEqual(test.FindRangeIP("12345").Count, 4);
            Assert.AreEqual(test.FindRangeIP("12345").IndexOf("12.3.4.5") != -1, true);
        }
    }
}
