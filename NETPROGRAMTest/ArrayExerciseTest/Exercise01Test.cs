using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETPROGRAM.ArrayExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.ArrayExerciseTest
{
    
    [TestClass]
    public class Exercise01Test
    {

        [TestMethod]
        public void TestCorrectNumbers()
        {
            var test = new Exercise01();

            Assert.AreEqual(test.CorrectNumbers(new int[] { 1, 2, 4, 8, 2, 8, 2, 3, 2, 4 }).Count, 3);
            Assert.IsTrue(test.CorrectNumbers(new int[] { 1, 2, 4, 5, 6, 8, 9, 3, 2, 4 }).Contains(2));
            Assert.IsTrue(test.CorrectNumbers(new int[] { 1, 2, 4, 5, 6, 8, 9, 3, 2, 4 }).Contains(4));
            Assert.IsFalse(test.CorrectNumbers(new int[] { 1, 2, 4, 5, 6, 8, 9, 3, 2, 4 }).Contains(1));
        }
    }
}
