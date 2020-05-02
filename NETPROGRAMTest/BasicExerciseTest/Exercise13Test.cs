using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

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

            Assert.IsTrue(Enumerable.SequenceEqual(test.FindRangeIP("1234"), new List<string>() { "1.2.3.4" }));
            Assert.IsTrue(test.FindRangeIP("1921681100").Contains("192.168.11.00"));
            Assert.IsTrue(test.FindRangeIP("1921681100").Contains("192.168.110.0"));
            Assert.IsTrue(test.FindRangeIP("1921681100").Contains("192.168.1.100"));
            Assert.IsTrue(test.FindRangeIP("1921681100").Contains("192.16.81.100"));
            Assert.IsFalse(test.FindRangeIP("1921681100").Contains("192.16.811.00"));
            Assert.IsFalse(test.FindRangeIP("1921681100").Contains("192.1.681.100"));
        }
    }
}
