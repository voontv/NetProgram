using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise03
    {

        public int SubtractArray(int[] array)
        {

            return array.Sum(x => (x % 2 == 0) ? x : 0) - array.Sum(x => (x % 2 == 1) ? x : 0);
        }
    }
}
