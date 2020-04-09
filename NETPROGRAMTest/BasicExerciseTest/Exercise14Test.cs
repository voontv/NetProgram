using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise14Test
    {

        [TestMethod]
        public void TestCountNumberZero()
        {
            var test = new Exercise14();

            Assert.AreEqual(test.CountNumberZero(10), 2);
            Assert.AreEqual(test.CountNumberZero(4), 0);
            Assert.AreEqual(test.CountNumberZero(100), 21);
            Assert.AreEqual(test.CountNumberZero(14), 2);
            Assert.AreEqual(test.CountNumberZero(15), 3);
            Assert.AreEqual(test.CountNumberZero(20), 4);        
        }
    }
}
