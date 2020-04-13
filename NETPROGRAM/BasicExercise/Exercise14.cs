using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.BasicExercise
{
    public class Exercise14
    {

        public long PowInt(int m, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            long multi = 1;

            for (int i = 0; i < n; i++)
            {
                multi *= m;
            }

            return multi;
        }

        public int CountZeroFactorial(int n)
        {
            var count = 0;

            for (int i = 1; i <= n; i++)
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
