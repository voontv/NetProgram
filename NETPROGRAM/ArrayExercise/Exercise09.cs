using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise09
    {

        public int[] CreatedArray(int n)
        {

            return Enumerable.Range(0, n).OrderBy(x => Guid.NewGuid()).ToArray();
        }
    }
}
