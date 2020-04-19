using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise07
    {

        public List<List<int>> SplitArray(int[] array, int n)
        {
            
            return (from i in Enumerable.Range(1, (int) Math.Ceiling(array.Length * 1.0 / n))
                   select array.Skip((i - 1) * n).Take( (array.Length - ((i - 1) * n) >= n) ? n : (array.Length - ((i - 1) * n))).ToList()).ToList();
        }
    }
}
