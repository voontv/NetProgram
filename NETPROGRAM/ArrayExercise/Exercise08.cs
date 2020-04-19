using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise08
    {

        public int CountNumbers(int[] array)
        {

            return (from i in array
                   where (i % 3 == 0 && i % 5 != 0)
                   select i).Count();
        }
    }
}
