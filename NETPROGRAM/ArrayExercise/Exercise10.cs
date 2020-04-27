using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise10
    {

        public bool IsSquareNumber(int n)
        {

            var left = -1;
            var right = n;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (mid * mid == n)
                {
                    return true;
                }

                if (mid * mid < n)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }

        public int SumSquare(int[] array)
        {

            return array.Where(IsSquareNumber).Sum();
        }
    }
}
