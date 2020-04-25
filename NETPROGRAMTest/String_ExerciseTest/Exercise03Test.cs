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
    public class Exercise03Test
    {

        [TestMethod]
        public void TestReverseString()
        {
            var test = new Exercise03();

            Assert.AreEqual(test.ReverseString("Toi la toi"), "iot al ioT");
        }              
    }
}
