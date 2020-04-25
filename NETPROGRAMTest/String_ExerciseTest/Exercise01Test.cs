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
    public class Exercise01Test
    {

        [TestMethod]
        public void TestSnakeCase()
        {
            var test = new Exercise01();

            Assert.AreEqual(test.SnakeCase("myProgram"), "my_program");
            Assert.AreEqual(test.SnakeCase("myProgramGood"), "my_program_good");
            Assert.AreEqual(test.SnakeCase("MatthewWestHelloMyNameIsLyrics"), "matthew_west_hello_my_name_is_lyrics");
        }
        
    }
}
