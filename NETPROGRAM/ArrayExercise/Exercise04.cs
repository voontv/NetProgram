using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETPROGRAM.ArrayExercise
{
    public class Exercise04
    {

        public bool IsPrime(int n)
        {
            if(n < 2)
            {
                return false;
            }

            for(var i = 2; i <= n / i; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int SumIPrime(int[] array)
        {

            return array.Where(IsPrime).Sum();
        }
    }
}
