using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NETPROGRAM.ArrayExercise;

namespace NETPROGRAMTest.ArrayExerciseTest
{

    [TestClass]
    public class Exercise09Test
    {

        [TestMethod]
        public void TestCreatedArrray()
        {
            var test = new Exercise09();

            Assert.AreEqual(test.CreatedArray(4).Where(x => (x == 3)).Sum(), 3);
            Assert.IsFalse(test.CreatedArray(4).Contains(4));
            Assert.IsTrue(test.CreatedArray(4).Contains(3));
        }
    }
}
