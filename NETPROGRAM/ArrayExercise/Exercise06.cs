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
            var mid = -1;
            var arrayToUp = true;

            if (array[right] < array[left])
            {
                arrayToUp = false;
                Array.Reverse(array);
            }

            while (right != left)
            {
                mid = (left + right) / 2;

                if(number == array[mid])
                {
                    return arrayToUp ? mid : array.Length - 1 - mid;
                }
                else if (number < array[mid])
                {
                     right = mid - 1;                    
                }
                else
                {
                    left = mid + 1;
                }
                   
                if(right == left)
                {
                    return (number == array[left]) ? (arrayToUp ? mid : array.Length - 1 - right) : -1; 
                }
            }
            
           
            return mid;
        }
    }
}
