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
    public class Exercise18Test
    {

        [TestMethod]
        public void TestSumNumber()
        {
            var test = new Exercise18();

            Assert.AreEqual(test.SumSquareNumber(19), 82);
        }

        [TestMethod]
        public void TestIsHappy()
        {
            var test = new Exercise18();

            Assert.IsTrue(test.IsHappy(19));
            Assert.IsTrue(test.IsHappy(263331));
            Assert.IsTrue(test.IsHappy(638));
            Assert.IsTrue(test.IsHappy(10000));
            Assert.IsFalse(test.IsHappy(721));
            Assert.IsFalse(test.IsHappy(2451));
            Assert.IsTrue(test.IsHappy(291));
            
        }
    }
}
