using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class ArrayDemo
    {

        public int SumArray(int n)
        {
            var array = new int[] { 1, 3, 5, 7, 9 };

            return array.Sum(x => (x > n) ? x: 0);
        }
    }
}
