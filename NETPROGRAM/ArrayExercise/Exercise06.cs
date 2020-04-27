using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise06
    {

        public int PositionInArray(int[] array, int number)
        {
            var left = -1;
            var right = array.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (array[mid] == number)
                {
                    return mid;
                }

                if (number < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
