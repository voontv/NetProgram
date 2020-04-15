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

            return (from n in array
                    orderby n descending
                    select n).Take(3).Sum(x => x);
        }
    }
}
