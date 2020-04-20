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
            var random = new Random();
            var array = new int[n];

            array[0] = random.Next(0, n);
            for(var i = 1; i < n; i++)
            {
                array[i] = random.Next(0, n);

                for (var j = 0; j < i; j++)
                {
                    if(array[j] == array[i])
                    {
                        i--;
                        break;
                    }
                }
            }

            return array;
        }
    }
}
