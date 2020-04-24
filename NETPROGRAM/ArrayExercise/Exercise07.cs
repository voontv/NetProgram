using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise07
    {

        public int[][] SplitArray(int[] array, int n)
        {

            return (from gr in (from index in Enumerable.Range(0, array.Length) 
                    group array[index] by (index / n)) 
                    select gr.ToArray()).ToArray();          
        }
    }
}
