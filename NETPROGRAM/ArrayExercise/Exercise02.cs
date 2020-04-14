using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise02
    {

        public int SumMax(int[] array)
        {
            var numbers = (from n in array
                          orderby n descending
                          select n).ToArray();

            return Enumerable.Range(0,(numbers.Length >= 3) ? 3 : numbers.Length).Sum(x => numbers[x]);
        }
    }
}
