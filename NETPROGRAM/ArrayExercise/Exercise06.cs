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
            var left = 0;
            var right = array.Length - 1;
            var mid = 0;
            
            while (array[mid] != number && left != right)
            {
                mid = (left + right) / 2;

                if (number < array[mid])
                {
                     right = mid - 1;                    
                }
                else
                {
                    left = mid + 1;
                }             
            }
            
           
            return (array[mid] == number) ? mid : -1;
        }
    }
}
