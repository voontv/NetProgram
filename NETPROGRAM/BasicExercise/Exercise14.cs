using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise14
    {

      
        public int CountZeroFactorial(int n)
        {
            var count = 0;

            for (var i = 1; i <= n; i += 5)
            {

                if (i % 5 == 0)
                {
                    var number = i;
                    do
                    {
                        number /= 5;
                        count++;
                    } while (number % 5 == 0);
                }
                
            }

            return count;
        }
    }
}
