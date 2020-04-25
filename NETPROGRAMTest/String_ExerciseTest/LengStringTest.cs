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
    public class LengStringTest
    {

        [TestMethod]
        public void TestLengOneString()
        {
            var test = new LengString();

            Assert.AreEqual(test.LengOneString("Toi la"), 6);
        }
    }
}
