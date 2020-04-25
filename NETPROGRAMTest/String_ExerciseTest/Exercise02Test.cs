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
    public class Exercise02Test
    {

        [TestMethod]
        public void TestUpperCase()
        {
            var test = new Exercise02();

            Assert.AreEqual(test.UpperCase("my_program"), "MyProgram");
            Assert.AreEqual(test.UpperCase("i_love_you"), "ILoveYou");
        }
    }
}
